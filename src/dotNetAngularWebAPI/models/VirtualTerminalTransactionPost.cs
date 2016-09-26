using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetAngularWebAPI.models
{
    public class VirtualTerminalTransactionPost
    {
        public class LINEITEM
        {
            [DisplayName("Account")]
            public string PAYMENTID { get; set; }
            [DisplayName("Account Secondary")]
            
            public string PAYMENTID_SECONDARY { get; set; }
            [DisplayName("Line Item Amount")]
           
            public string ITEMAMOUNT { get; set; }
            [DisplayName("Customer Payment Type Identifier")]
            
            public string CUSTOMERPAYMENTTYPEID { get; set; }
            [DisplayName("Miscellaneous One")]
           
            public string MISC_ONE { get; set; }
            [DisplayName("Miscellaneous Two")]
            
            public string MISC_TWO { get; set; }
           
            [DisplayName("Miscellaneous Three")]
            public string MISC_THREE { get; set; }
          
            public string MISC_FOUR { get; set; }
            
            public string MISC_FIVE { get; set; }
            
            public string MISC_SIX { get; set; }
            
            public string MISC_SEVEN { get; set; }
            
            public string MISC_EIGHT { get; set; }
           
            public string MISC_NINE { get; set; }
           
            public string MISC_TEN { get; set; }
            
            public string MISC_ELEVEN { get; set; }
            
            public string MISC_TWELVE { get; set; }
            
            public string MISC_THIRTEEN { get; set; }
            
            public string MISC_FOURTEEN { get; set; }
            
            public string MISC_FIFTEEN { get; set; }
        }

        
        public class VT_TRANSACTION
        {
            [DisplayName("Client Key"), Description("herror")]
            
            public string CLIENTKEY { get; set; }
            [DisplayName("Transaction Identifier")]
            
            public string TRANSACTIONID { get; set; }
            [DisplayName("Collection Mode")]
            
            public string COLLECTIONMODE { get; set; }
            [DisplayName("Amount")]
            
            public string AMOUNT { get; set; }
            [DisplayName("Name")]
           
            public string NAME { get; set; }
            [DisplayName("Address")]
           
            public string ADDRESS { get; set; }
            [DisplayName("Address Two")]
            
            public string ADDRESSTWO { get; set; }
            [DisplayName("City")]
            
            public string CITY { get; set; }
            [DisplayName("County")]
           
            public string COUNTY { get; set; }
            [DisplayName("State")]
            [RegularExpression("[A-Z]{2}")]
           
            public string STATE { get; set; }
            [DisplayName("Country")]
            
            public string COUNTRY { get; set; }
            [DisplayName("Zip Code")]
            
            public string ZIP { get; set; }
            [DisplayName("Email Address")]
            
            public string EMAIL { get; set; }
            [DisplayName("Mobile Number")]
            
            public string PHONE { get; set; }
            [DisplayName("Notes")]
           
            public string NOTES { get; set; }
            [DisplayName("CSI User Identifier")]
           
            public string CSIUSERID { get; set; }
            
            public LINEITEM LINEITEM { get; set; }
            [DisplayName("URL Silent Post")]
            
            public string URLSILENTPOST { get; set; }
           
            public string URLRETURNPOST { get; set; }
           
            public string ALLOWEDPAYMENTMETHOD { get; set; }
        }
    }
}
