namespace Teleperformance.Final.Project.Domain.Base
{
    public abstract class BaseEntity
    {
        #region CTOR
        public BaseEntity()
        {
            CreatedDate = DateTime.UtcNow;
            IsActive = true;
        }

        #endregion

        #region PROPERTIES

        public virtual int Id { get; set; }

        public bool IsActive { get; set; }

        public virtual string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        #endregion

    }
}
