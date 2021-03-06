using System.Text.Json.Serialization;

namespace Pizza_Project.database.Models.customer_info.payment
{
    public class CreditCardInfo
    {

        [JsonPropertyName("nameOnCard")]
        public string NameOnCard { get; set; }
        
        [JsonPropertyName("cardNumber")]
        public string CardNumber { get; set; }
        
        [JsonPropertyName("expDate")]
        public string ExpDate { get; set; }
        
        [JsonPropertyName("cvc")]
        public string CVC { get; set; }

        public string [] arrayOfInfo()
        {
            return new string [] { NameOnCard, CardNumber, ExpDate, CVC };
        }
    }
}