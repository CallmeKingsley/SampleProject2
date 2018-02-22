//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleProject2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        public int UserID { get; set; }

        [DisplayName("User Name")]

        [Required(ErrorMessage = "you need a User Name")]

        public string UserName { get; set; }

        [DisplayName("Password")]

        [Required(ErrorMessage = "you need a password")]

        [DataType(DataType.Password)]

        public string UserPassword { get; set; }


        public string LoginErrorMsg { get; set; }
    }
}
