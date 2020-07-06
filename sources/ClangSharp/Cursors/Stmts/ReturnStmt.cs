// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

using System;
using ClangSharp.Interop;

namespace ClangSharp
{
    public sealed class ReturnStmt : Stmt
    {
        private readonly Lazy<VarDecl> _nrvoCandidate;
        private readonly Lazy<Expr> _retValue;

        internal ReturnStmt(CXCursor handle) : base(handle, CXCursorKind.CXCursor_ReturnStmt, CX_StmtClass.CX_StmtClass_ReturnStmt)
        {
            _nrvoCandidate = new Lazy<VarDecl>(() => TranslationUnit.GetOrCreate<VarDecl>(Handle.Referenced));
            _retValue = new Lazy<Expr>(() => TranslationUnit.GetOrCreate<Expr>(Handle.SubStmt));
        }

        public VarDecl NRVOCandidate => _nrvoCandidate.Value;

        public Expr RetValue => _retValue.Value;
    }
}
