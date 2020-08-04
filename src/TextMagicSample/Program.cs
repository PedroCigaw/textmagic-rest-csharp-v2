using System;
using System.IO;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace ExampleApp
{
    class Program
    {
        private static string SenderId { get; } = "Your Sender Id";
        private static string SMSPhoneNumber { get; } = "PhoneNumber for sms 447808451451";
        private static string ApiKey { get; } = "Your api key";
        private static string UserName { get; } = "Your Username";
        

        static void Main(string[] args)
        {
            // put your Username and API Key from https://my.textmagic.com/online/api/rest-api/keys page.
            Configuration.Default.Username = UserName;
            Configuration.Default.Password = ApiKey;
            Configuration.Default.BasePath = "https://rest.textmagic.com";

            var apiInstance = new TextMagicApi();

            Ping(apiInstance);

            SendSMS(apiInstance);

            // GetAllOutboundMessages(apiInstance);

            // UploadAvatar(apiInstance);

            //TestVerify(apiInstance);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void TestVerify(TextMagicApi apiInstance)
        {
            Console.WriteLine("Test Verification Code");
            Console.Write("Enter Phone: ");
            var phone = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(phone))
            {
                return;
            }

            var verifyId = SendVerifyRequest(apiInstance, phone);
            if (string.IsNullOrEmpty(verifyId))
            {
                return;
            }

            Console.Write("Enter Code: ");
            var code = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(code))
            {
                return;
            }

            var verified = VerifyCode(apiInstance, verifyId, code);
            Console.WriteLine($"Verify Response: {verified}");
        }

        private static bool VerifyCode(TextMagicApi apiInstance, string verifyId, string code)
        {
            var obj = new CheckPhoneVerificationCodeTFAInputObject();

            // Required parameters
            obj.Code = int.Parse(code);
            obj.VerifyId = verifyId;

            try
            {
                apiInstance.CheckPhoneVerificationCodeTFA(obj);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling checkPhoneVerificationCodeTFA: " + e.Message);
            }

            return false;
        }

        private static string SendVerifyRequest(TextMagicApi apiInstance, string phoneNumber)
        {
            var obj = new SendPhoneVerificationCodeTFAInputObject();

            // Required parameters
            obj.Phone = phoneNumber;
            obj.Brand = "TextMagic";
            obj.CodeLength = 4;

            // Optional parameters, you can skip these setters calls
            obj.WorkflowId = "6";
            obj.Language = "en-gb";
            obj.SenderId = SenderId;
            obj.Country = "GB";

            try
            {
                // SendPhoneVerificationCodeResponse class object
                var result = apiInstance.SendPhoneVerificationCodeTFA(obj);
                return result.VerifyId;
                // ...
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling sendPhoneVerificationCodeTFA: " + e.Message);
            }

            return string.Empty;
        }

        private static void UploadAvatar(TextMagicApi apiInstance)
        {
            // Upload list avatar sample, 3223 here is a sample list id
            try
            {
                var stream = File.Open("/CustomPath/Images/test.png", FileMode.Open);
                var result = apiInstance.UploadListAvatar(stream, 3223);
                Console.WriteLine(result.Href);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling TextMagicApi.UploadListAvatar: " + e.Message);
            }
        }

        private static void GetAllOutboundMessages(TextMagicApi apiInstance)
        {
            // Get all outgoing messages sample
            try
            {
                var result = apiInstance.GetAllOutboundMessages(1, 10);
                Console.WriteLine(result.Resources[0].Id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling TextMagicApi.GetAllOutboundMessages: " + e.Message);
            }
        }

        private static void SendSMS(TextMagicApi apiInstance)
        {
            // Send a new message request sample
            try
            {
                var sendMessageInputObject = new SendMessageInputObject
                {
                    Text = "I love TextMagic!",
                    Phones = SMSPhoneNumber
                };

                var result = apiInstance.SendMessage(sendMessageInputObject);
                Console.WriteLine(result.Id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling TextMagicApi.SendMessage: " + e.Message);
            }
        }

        private static void Ping(TextMagicApi apiInstance)
        {
            // Simple Ping request sample
            try
            {
                var result = apiInstance.Ping();
                Console.WriteLine(result.Ping);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling TextMagicApi.Ping: " + e.Message);
            }
        }
    }
}