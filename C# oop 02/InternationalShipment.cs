using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__oop_02
{
    internal class InternationalShipment : Shipment
    {
        public InternationalShipment(string trackingCode, string description, double weight, decimal deliveryfee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryfee, destination)
        {
        }
        private string DestinationCountry;
        private decimal CustomsFee;
        public string destinationCountry
        {
            get => destinationCountry;
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("DestinationsCountry cannot be null,empty,or whitespace.");
                }
                destinationCountry = value;
            }
        }
        public decimal customsFee
        {
            get => customsFee;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "CustomsFee must be greater than or equal to 0.");
                }
            }
        }
        public InternationalShipment(
        string trackingCode,
        string destinationCountry,
        decimal customsFee) 
        : base(trackingCode) // بنبعت الـ trackingCode بس للـ base
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + CustomsFee;
            }
        }
    }


    }
