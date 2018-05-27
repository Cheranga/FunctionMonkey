﻿using AzureFromTheTrenches.Commanding.Abstractions;
using FunctionMonkey.Commanding.Abstractions.Validation;

namespace FunctionMonkey.Abstractions.Validation
{
    public interface IValidator
    {
        ValidationResult Validate<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
