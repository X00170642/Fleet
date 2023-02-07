using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fleet.Models
{
    public class Car
    {
        

        private string make;

        public string Make
        {
            get { return make; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Make cannot be empty;");
                }
                make = value;
            }
        }


        private string model;

        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model cannot be empty;");
                }
                model = value;
            }
        }

        
        private string registration;


        public string Registration
        {
            get { return registration; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Registration cannot be empty;");
                }
                registration = value;
            }
        }


        public int EngineSize { get; set; } 

        



        public Car(string make, string model, string registration, int enginesize)
        {
            this.make = make;
            this.model = model;
            this.registration = registration;
            this.EngineSize= enginesize;

        }

        public override string ToString()
        {
            return "Make: " + Make + "| Model: " + Model + " | Registration: " + Registration + " | Engine Size: " + EngineSize;
        }

    }
}