using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PencilJoyTests.Data
{
    class FullData
    {
        public CreateBookData createBookData { get; set; }
        public MessageData messageData { get; set; }
        public CheckoutAddressData checkoutAddressData { get; set; }
        public CheckoutPaymentData checkoutPaymentData { get; set; }

        public string Username { get; set; }

        public FullData()
        {

            createBookData = new CreateBookData();
            messageData = new MessageData();
            checkoutAddressData = new CheckoutAddressData();
            checkoutPaymentData = new CheckoutPaymentData();
        }
        public FullData(CreateBookData createBookData, MessageData messageData,
            CheckoutAddressData checkoutAddressData, CheckoutPaymentData checkoutPaymentData)
        {
            this.createBookData.Username = createBookData.Username;
            this.createBookData.NumberCharacter = createBookData.NumberCharacter;
            this.createBookData.NumberDay = createBookData.NumberDay;
            this.createBookData.NumberMonth = createBookData.NumberMonth;
            this.createBookData.NumberSex = createBookData.NumberSex;
            this.messageData.CustomerName = messageData.CustomerName;
            this.messageData.CustomerEmail = messageData.CustomerEmail;
            this.checkoutAddressData.Username = checkoutAddressData.Username;
            this.checkoutAddressData.City = checkoutAddressData.City;
            this.checkoutAddressData.Phone = checkoutAddressData.Phone;
            this.checkoutAddressData.Street = checkoutAddressData.Street;
            this.checkoutAddressData.ZipCode = checkoutAddressData.ZipCode;
            this.checkoutAddressData.Lastname = checkoutAddressData.Lastname;

          this.checkoutPaymentData = checkoutPaymentData;
        }
        /*
        public FullData(CreateBookData createBookData, MessageData messageData,
            CheckoutAddressData checkoutAddressData, CheckoutPaymentData checkoutPaymentData)
        {
            
            this.createBookData = createBookData;
            this.messageData = messageData;
            this.checkoutAddressData = checkoutAddressData;
            this.checkoutPaymentData = checkoutPaymentData;
        }
         */

    }
}
