﻿namespace Core.Entities.Concrete
{
    public class UserOperationName:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

    }
}
