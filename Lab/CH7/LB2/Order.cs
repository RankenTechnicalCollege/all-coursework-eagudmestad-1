using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class Order
    {
        //Instance Fields
        private short _itemNumber;
        private byte _quantity;
        private byte _esimatedDeliveryDays;

        //Constructor
        public Order(short itemNumber,byte quantity,byte estimatedDeliveryDays)
        {
            //if(itemNumber >= 100 && itemNumber <= 999)
            //{

            CheckItemNumber(itemNumber);

            CheckQuantity(quantity);

            CheckDeliveryDays(estimatedDeliveryDays);
            
            //Instance fields do not get set if an exception is thrown
            _itemNumber = itemNumber;
            _quantity = quantity;
            _esimatedDeliveryDays = estimatedDeliveryDays;
        }

        private void CheckDeliveryDays(byte days)
        {
            if (days < 1 || days > 30)
            {
                throw new InvalidDeliveryDaysException();
            }
        }

        private void CheckQuantity(byte quantity)
        {
            if (quantity < 1 || quantity > 12)
            {
                throw new InvalidQuantityException();
            }
        }

        private void CheckItemNumber(short itemNumber)
        {
            if (itemNumber < 100 || itemNumber > 999)
            {
                throw new InvalidItemNumberException();
            }
        }

        //Properties
        public short ItemNumber
        {
            get
            {
                return _itemNumber;
            }
            set
            {
                CheckItemNumber(value);
                _itemNumber = value;
            }
        }

        public byte Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                CheckQuantity(value);
                _quantity = value;
            }
        }

        public byte EsimatedDeliveryDays
        {
            get
            {
                return _esimatedDeliveryDays;
            }
            set
            {
                CheckDeliveryDays(value);
                _esimatedDeliveryDays = value;
            }
        }

    
    
    
    }

}
