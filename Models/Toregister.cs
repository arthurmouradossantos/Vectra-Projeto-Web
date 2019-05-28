using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Original.Models
{
    public class Toregister

    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha Seu Nome")]
        [Display(Name = "Nome:")]
        public string Name { get; set; }

        [Display(Name = "Idade:")]


        [Required(ErrorMessage = "Preencha Sua Idade")]

        public int Idade { get; set; }

        [Required(ErrorMessage = "Preencha Seu CPF")]

        [Display(Name = "CPF:")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Preencha Seu Peso")]

        [Display(Name = "Peso:")]
        public double Peso { get; set; }

        [Required(ErrorMessage = "Preencha Sua Altura")]

       [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "Altura:")]
        public decimal Altura { get; set; }
        [Display(Name = "Telefone:")]

        public string Telefone { get; set; }


        [Display(Name = "Nascimento:")]
        [DataType(DataType.Date)]

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}" )]

        [Required(ErrorMessage = "Preencha Sua Data de Nascimento")]

        public DateTime Nascimento { get; set; }

        [Display(Name = "Sexo:")]
        public string Sexo { get; set; }

        


    }


    




    }


