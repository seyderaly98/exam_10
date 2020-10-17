﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Rating.ViewModels
{
    public class Register
    {
        [Required(ErrorMessage = "Это поле необходимо заполнить.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Это поле необходимо заполнить.")]
        [EmailAddress(ErrorMessage = "Пожалуйста, введите действительный адрес электронной почты.")]
        [Remote("CheckEmail","Validation",ErrorMessage = "Данный электронный адрес используется другим аккаунтом.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Это поле необходимо заполнить.")]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage = "Пароль должен содержать не менее 8 символов.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Это поле необходимо заполнить.")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Пароли не совпадают.")]
        [MinLength(8,ErrorMessage = "Пароль должен содержать не менее 8 символов.")]
        public string ConfirmPassword { get; set; }
    }
}