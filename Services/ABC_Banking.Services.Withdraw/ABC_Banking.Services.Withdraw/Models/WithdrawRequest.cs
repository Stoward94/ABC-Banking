﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ABC_Banking.Services.Withdraw.Models
{
    public class WithdrawRequest
    {
        /// <summary>
        /// The account holders name
        /// </summary>
        [Required]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The bank account number
        /// </summary>
        [Required, MinLength(8), MaxLength(8)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The card number used to request the withdraw
        /// </summary>
        [Required, MinLength(16), MaxLength(16)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Card PIN authorisation number
        /// </summary>
        [Required]
        public int Pin { get; set; }

        /// <summary>
        /// DateTime stamp the deposit was made
        /// </summary>
        [Required]
        public DateTime DateRequested { get; set; }

        /// <summary>
        /// The bank account sort code, required format "123456" (no hyphens)
        /// </summary>
        [Required, MinLength(6), MaxLength(6)]
        public string SortCode { get; set; }

        /// <summary>
        /// Total cash value requested to withdraw
        /// </summary>
        [Required]
        public decimal TotalCashValue { get; set; }
    }
}