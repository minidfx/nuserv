﻿namespace nuserv.Service.Contracts
{
    #region Usings

    using Ninject.Syntax;

    #endregion

    public interface IResolutionRootResolver
    {
        #region Public Methods and Operators

        IResolutionRoot Resolve();

        #endregion
    }
}