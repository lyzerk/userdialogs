﻿using System;


namespace Acr.UserDialogs
{

    public class PromptConfig : IStandardDialogConfig, IAndroidStyleDialogConfig
    {
        public static string DefaultOkText { get; set; } = "Ok";
        public static string DefaultCancelText { get; set; } = "Cancel";
        public static int? DefaultAndroidStyleId { get; set; }

        public string Title { get; set; }
        public string Message { get; set; }
        public Action<PromptResult> OnResult { get; set; }

        public bool IsCancellable { get; set; } = true;
        public string Text { get; set; }

        public string OkText { get; set; } = DefaultOkText;
        public string CancelText { get; set; } = DefaultCancelText;
        public string Placeholder { get; set; }
        public int? AndroidStyleId { get; set; }
        public InputType InputType { get; set; } = InputType.Default;


        public PromptConfig SetTitle(string title)
        {
            this.Title = title;
            return this;
        }


        public PromptConfig SetMessage(string message)
        {
            this.Message = message;
            return this;
        }


        public PromptConfig SetCancellable(bool cancel)
        {
            this.IsCancellable = cancel;
            return this;
        }


        public PromptConfig SetOkText(string text)
        {
            this.OkText = text;
            return this;
        }


        public PromptConfig SetText(string text)
        {
            this.Text = text;
            return this;
        }


        public PromptConfig SetCancelText(string cancelText)
        {
            this.IsCancellable = true;
            this.CancelText = cancelText;
            return this;
        }


        public PromptConfig SetPlaceholder(string placeholder)
        {
            this.Placeholder = placeholder;
            return this;
        }


        public PromptConfig SetInputMode(InputType inputType)
        {
            this.InputType = inputType;
            return this;
        }
    }
}
