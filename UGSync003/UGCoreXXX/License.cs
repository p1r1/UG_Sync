using System;
using ThinkSharp.Licensing;
using ThinkSharp.Signing;

namespace UGCore {
    public class License {

        ///CONST 
        private const string M_APP_CODE = "OFM";
        //private const string ENTROPY_VALUE = "Faruk";

        private static string m_publicKey;
        private static string m_privateKey;
        private static string m_name;
        private static string m_company;
        private static DateTime m_exprationDate;
        private string m_serialKey;
        private SignedLicense m_license;

        public DateTime exprationDateGet { get; }

        //public DateTime issueDateGet(string s) {
        //    SignedLicense newLicense = si

        //    return m_license.IssueDate;
        //}

        public static Tuple<string, string> generateKey() {
            //1publickey 2 privateKey
            SigningKeyPair keyPair = Lic.KeyGenerator.GenerateRsaKeyPair(); //Console.WriteLine(pair.PrivateKey); //Console.WriteLine(pair.PublicKey);
            Tuple<string, string> tupleKeyPair = new Tuple<string, string>(keyPair.PublicKey, keyPair.PrivateKey);
            return tupleKeyPair;
        }

        public void initLicense(string serialKey, string name, string company, DateTime exprationDate, string publicKey, string privateKey) {
            m_name = name;
            m_company = company;
            m_exprationDate = exprationDate;
            m_publicKey = publicKey;
            m_privateKey = privateKey;
            m_serialKey = serialKey;
        }

        public bool validateSerial(string serialKey) {
            return SerialNumber.IsCheckSumValid(serialKey);
        }

        public bool validateAppCode(string serialKey) {
            return SerialNumber.IsApplicationCodeValid(serialKey, M_APP_CODE);
        }

        //public bool compareOldSerials() {
        //    if (SerialNumber.IsApplicationCodeValid) {

        //    }
        //    return false;
        //}

        public string createSignedLicense() {
            m_license = Lic.Builder.WithRsaPrivateKey(m_privateKey).
                                    WithoutHardwareIdentifier().
                                    WithSerialNumber(SerialNumber.Create(M_APP_CODE)).
                                    ExpiresOn(m_exprationDate).
                                    WithProperty("Name", m_name).
                                    WithProperty("Company", m_company).
                                    SignAndCreate();

            return m_license.Serialize(); // return encrypted key
        }


        public Tuple<bool, string> verifyLicense(string publicKey, string licenseText) {
            try {
                var verified = Lic.Verifier.WithRsaPublicKey(publicKey).WithApplicationCode(M_APP_CODE).LoadAndVerify(licenseText);
                Tuple<bool, string> verifiedSerialTuple = new Tuple<bool, string>(true, verified.Serialize());
                return verifiedSerialTuple;
            }
            catch (SignedLicenseException ex) {
                Tuple<bool, string> expiredSerialTuple = new Tuple<bool, string>(false, ex.ToString());
                return expiredSerialTuple;
            }
        }


    }
}

/// <summary>
/// The class SignedLicense encapsulates some license related information and a signature for verifying it. The license can be serialized / deserialized for storing it on the client. It has following public properties:
///   - IssueDate: date of the issuing (when the license was created)
///   - ExpirationDate: date of the expiration (may be DateTime.MaxValue for licenses without expiration)
///   - SerialNumber Optional: a serial number (See class SerialNumber below)
///   - Properties IDictionary<string, string> with custom key value pairs
/// The static Lic class is the entry point for the fluent API that allows to work with signed licenses. It has the following static properties:
///   - Lic.Builder: Object for creating signed license objects
///   - Lic.Verifyer: Object for verifiying serialized signed licenses and deserialize it.
///   - Lic.KeyGenerator: Object for creating private/public key pairs to use for signing
/// </summary>
//private static string m_privateKey = "BwIAAACkAABSU0EyAAQAAAEAAQA9D9kxlsh1N5KPmhOsJj/QM9iZVaho5OzEG0gyO8s0Giycx7ttegjugLE1NY7Gw5FPJvSqrlRiBp9iNCsD9/NUJIa65mwfTsShzoce+v5tRLJrd4osZZ3WFA/e4oSk9BgCJNUWIShj1HKD4Lk1YqGWtaMZnx/uNLe8QZ4FGYkKvOWDl4FaLViZBbGfLBxMoMpPGQVmSbJtlOoqjyQr0J9stuuJCs564uTzXqJU9/ytInlFYGEDOpYanlkio4x38Px5WAF4+EPvplW6IszdwsR+Sd6hkSqwu8IPzkZwU6PsyvPF2tLQgomB4LVh/6gJcDpNCXJLWXm4GG+YuHpiCFG+6fPFbd0vcDc5Y4ByAtUADFQ0q2kdI+8K5znNJBd9xeuTF9mJLFKbvENJ58F+DPCtWLEWf5tYZXicZUfTa/tnmzFQKx1lc3wHYh5DyQttkmvsN4bXrp0whYU1S8eiI22H5meA5C6CiJZKSXWEGAAA2bpSgRt5ltS1WIR+wVGZ5iFkwnrkQldBZxecWCpj5HQexyDPcpsJipSotRllkNP8K8TubP8YafQGntQjeozZ4mOz2+V3f7GuC5DX229fGIv54ULq7ftWS3sqLSYzf1DJbN//bQkZQCAP5s5UXlx3n6G68cmkTaSE4ZP2slleqF6CEAaMS99jh2deYslQu1Jp395XkYoqnkzWiAIuoIYIaUxMn5+HWdqS6gqyGVHdbnWvlncdcoest/0waxkeSC86QqZ77QFzLaKSfDnYpHZ2t1o=";

//SignedLicense license = Lic.Builder
//                        .WithRsaPrivateKey(pk)                                           // .WithSigner(ISigner)
//                        .WithHardwareIdentifier(HardwareIdentifier.ForCurrentComputer()) // .WithoutHardwareIdentifier()
//                        .WithSerialNumber(SerialNumber.Create("ABC"))                    // .WithoutSerialNumber()
//                        .WithoutExpiration()                                             // .ExpiresIn(TimeSpan), .ExpiresOn(DateTime)
//                        .WithProperty("Name", "Bill Gates")
//                        .WithProperty("Company", "Microsoft")                            //... other key value pairs
//                        .SignAndCreate();
// //ABC = application code

// Private
// Public
//internal static string PublicKey = "BgIAAACkAABSU0ExAAQAAAEAAQA9D9kxlsh1N5KPmhOsJj/QM9iZVaho5OzEG0gyO8s0Giycx7ttegjugLE1NY7Gw5FPJvSqrlRiBp9iNCsD9/NUJIa65mwfTsShzoce+v5tRLJrd4osZZ3WFA/e4oSk9BgCJNUWIShj1HKD4Lk1YqGWtaMZnx/uNLe8QZ4FGYkKvA==";
/// <summary>
/// SNXXX-YYYY-YYYY-YYYY-ZZZ where XXX is the application code, YYYY is the random part and ZZZ is the check sum
/// A serial number is an identifier with an alpha-numeric application code (3 character), some random characters and a check sum. 
/// It looks like SNXXX-YYYY-YYYY-YYYY-ZZZ where XXX is the application code, YYYY is the random part and ZZZ is the check sum. E.g.:
/// SNABC-D156-KYJF-C4M5-1H96
/// SNOFM-D156-KYJF-C4M5-1H96
/// </summary>