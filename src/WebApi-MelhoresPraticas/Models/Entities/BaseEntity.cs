using FluentValidation.Results;

namespace WebApi_MelhoresPraticas.Models
{
    public abstract class BaseEntity<Tid>
    {
        protected BaseEntity()
        {
            ValidationResult = new ValidationResult();
        }

        public Tid Id { get; set; }

        public ValidationResult ValidationResult { get; set; }
    }
}
