using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPNETWebapp.models
{
    public class gradeCalcModel
    {
        //assignment model
        [Range(0,100)]
        public string assign { get; set; } //this line builds getters and setters for us
        // group project model
        [Range(0, 100)]
        public string gp { get; set; }
        // quiz model
        [Range(0, 100)]
        public string qz { get; set; }
        //exam model
        [Range(0, 100)]
        public string ex { get; set; }
        //intex model
        [Range(0, 100)]
        public string intx { get; set; }


        //setter
        //public void setFrom (string input)
        //{
        //    this.From = input;
        //}

        //getter
        //public string getFrom()
        //{
        //    return this.From;
        //}
    }
}
