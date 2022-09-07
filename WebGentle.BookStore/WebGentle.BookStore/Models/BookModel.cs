using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WebGentle.BookStore.Enums;
using WebGentle.BookStore.Data;
using WebGentle.BookStore.Helpers;
using Microsoft.AspNetCore.Http;

namespace WebGentle.BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Length of Title should be in the range of 2 to 50 characters")]
        [Required(ErrorMessage = "Please Enter Title of the book")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please Enter Author Name of the book")]
        public string Author { get; set; }

        [StringLength(500, MinimumLength = 30, ErrorMessage = "Length of Description should be in the range of 30 to 500 characters")]
        public string Description { get; set; }
        public string Category { get; set; }

        [Display(Name = "Language")]
        [Required(ErrorMessage = "Please Choose Language of the book")]
        public int LanguageId { get; set; }

        public string Language { get; set; }

        [Display(Name = "Total Pages")]
        [Required(ErrorMessage = "Please Enter Total Pages of the book")]
        public int? TotalPages { get; set; }

        [Display(Name = "Choose Cover Photo of book")]
        [Required(ErrorMessage = "Please Choose Cover Photo of book")]
        public IFormFile CoverPhoto { get; set; }
        public string CoverImageUrl { get; set; }

        [Display(Name = "Choose Gallery Images of book")]
        [Required(ErrorMessage = "Please Choose Gallery Images of book")]
        public IFormFileCollection GallaryFiles { get; set; }

        public List<GalleryModel> Gallery { get; set; }

        [Display(Name = "Upload book in pdf format")]
        [Required(ErrorMessage = "Upload book in pdf format")]
        public IFormFile BookPdf { get; set; }
        public string BookPdfUrl { get; set; }
    }
}
