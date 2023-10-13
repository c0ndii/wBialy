﻿using FluentValidation;

namespace wBialy.Models.Validators
{
    public class EditGastroPostDtoValidator : AbstractValidator<EditGastroPostDto>
    {
        public EditGastroPostDtoValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .MaximumLength(50);
            RuleFor(x => x.Description)
                .NotEmpty()
                .MaximumLength(250);
            RuleFor(x => x.Place)
                .NotEmpty();
            RuleFor(x => x.Day)
                .NotEmpty();
            RuleFor(x => x.Tags)
                .NotEmpty();
        }
    }
}
