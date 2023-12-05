﻿using Serenity.ComponentModel;
using System;

namespace GXpert.Activation.Forms;

[FormScript("Activation.Activation")]
[BasedOnRow(typeof(ActivationRow), CheckNames = true)]
public class ActivationForm
{
    public int PlayListId { get; set; }
    public int TeacherId { get; set; }
    public int ActivationLogId { get; set; }
    public string DeviceId { get; set; }
    public string DeviceDetails { get; set; }
    public DateTime ActivationDate { get; set; }
    public DateTime ExpiryDate { get; set; }
    public short EStatus { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public short IsActive { get; set; }
}