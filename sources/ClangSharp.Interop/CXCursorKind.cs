// Copyright (c) .NET Foundation and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

// Ported from https://github.com/llvm/llvm-project/tree/llvmorg-13.0.0/clang/include/clang-c
// Original source is Copyright (c) the LLVM Project and Contributors. Licensed under the Apache License v2.0 with LLVM Exceptions. See NOTICE.txt in the project root for license information.

namespace ClangSharp.Interop
{
    public enum CXCursorKind
    {
        CXCursor_UnexposedDecl = 1,
        CXCursor_StructDecl = 2,
        CXCursor_UnionDecl = 3,
        CXCursor_ClassDecl = 4,
        CXCursor_EnumDecl = 5,
        CXCursor_FieldDecl = 6,
        CXCursor_EnumConstantDecl = 7,
        CXCursor_FunctionDecl = 8,
        CXCursor_VarDecl = 9,
        CXCursor_ParmDecl = 10,
        CXCursor_ObjCInterfaceDecl = 11,
        CXCursor_ObjCCategoryDecl = 12,
        CXCursor_ObjCProtocolDecl = 13,
        CXCursor_ObjCPropertyDecl = 14,
        CXCursor_ObjCIvarDecl = 15,
        CXCursor_ObjCInstanceMethodDecl = 16,
        CXCursor_ObjCClassMethodDecl = 17,
        CXCursor_ObjCImplementationDecl = 18,
        CXCursor_ObjCCategoryImplDecl = 19,
        CXCursor_TypedefDecl = 20,
        CXCursor_CXXMethod = 21,
        CXCursor_Namespace = 22,
        CXCursor_LinkageSpec = 23,
        CXCursor_Constructor = 24,
        CXCursor_Destructor = 25,
        CXCursor_ConversionFunction = 26,
        CXCursor_TemplateTypeParameter = 27,
        CXCursor_NonTypeTemplateParameter = 28,
        CXCursor_TemplateTemplateParameter = 29,
        CXCursor_FunctionTemplate = 30,
        CXCursor_ClassTemplate = 31,
        CXCursor_ClassTemplatePartialSpecialization = 32,
        CXCursor_NamespaceAlias = 33,
        CXCursor_UsingDirective = 34,
        CXCursor_UsingDeclaration = 35,
        CXCursor_TypeAliasDecl = 36,
        CXCursor_ObjCSynthesizeDecl = 37,
        CXCursor_ObjCDynamicDecl = 38,
        CXCursor_CXXAccessSpecifier = 39,
        CXCursor_FirstDecl = CXCursor_UnexposedDecl,
        CXCursor_LastDecl = CXCursor_CXXAccessSpecifier,
        CXCursor_FirstRef = 40,
        CXCursor_ObjCSuperClassRef = 40,
        CXCursor_ObjCProtocolRef = 41,
        CXCursor_ObjCClassRef = 42,
        CXCursor_TypeRef = 43,
        CXCursor_CXXBaseSpecifier = 44,
        CXCursor_TemplateRef = 45,
        CXCursor_NamespaceRef = 46,
        CXCursor_MemberRef = 47,
        CXCursor_LabelRef = 48,
        CXCursor_OverloadedDeclRef = 49,
        CXCursor_VariableRef = 50,
        CXCursor_LastRef = CXCursor_VariableRef,
        CXCursor_FirstInvalid = 70,
        CXCursor_InvalidFile = 70,
        CXCursor_NoDeclFound = 71,
        CXCursor_NotImplemented = 72,
        CXCursor_InvalidCode = 73,
        CXCursor_LastInvalid = CXCursor_InvalidCode,
        CXCursor_FirstExpr = 100,
        CXCursor_UnexposedExpr = 100,
        CXCursor_DeclRefExpr = 101,
        CXCursor_MemberRefExpr = 102,
        CXCursor_CallExpr = 103,
        CXCursor_ObjCMessageExpr = 104,
        CXCursor_BlockExpr = 105,
        CXCursor_IntegerLiteral = 106,
        CXCursor_FloatingLiteral = 107,
        CXCursor_ImaginaryLiteral = 108,
        CXCursor_StringLiteral = 109,
        CXCursor_CharacterLiteral = 110,
        CXCursor_ParenExpr = 111,
        CXCursor_UnaryOperator = 112,
        CXCursor_ArraySubscriptExpr = 113,
        CXCursor_BinaryOperator = 114,
        CXCursor_CompoundAssignOperator = 115,
        CXCursor_ConditionalOperator = 116,
        CXCursor_CStyleCastExpr = 117,
        CXCursor_CompoundLiteralExpr = 118,
        CXCursor_InitListExpr = 119,
        CXCursor_AddrLabelExpr = 120,
        CXCursor_StmtExpr = 121,
        CXCursor_GenericSelectionExpr = 122,
        CXCursor_GNUNullExpr = 123,
        CXCursor_CXXStaticCastExpr = 124,
        CXCursor_CXXDynamicCastExpr = 125,
        CXCursor_CXXReinterpretCastExpr = 126,
        CXCursor_CXXConstCastExpr = 127,
        CXCursor_CXXFunctionalCastExpr = 128,
        CXCursor_CXXTypeidExpr = 129,
        CXCursor_CXXBoolLiteralExpr = 130,
        CXCursor_CXXNullPtrLiteralExpr = 131,
        CXCursor_CXXThisExpr = 132,
        CXCursor_CXXThrowExpr = 133,
        CXCursor_CXXNewExpr = 134,
        CXCursor_CXXDeleteExpr = 135,
        CXCursor_UnaryExpr = 136,
        CXCursor_ObjCStringLiteral = 137,
        CXCursor_ObjCEncodeExpr = 138,
        CXCursor_ObjCSelectorExpr = 139,
        CXCursor_ObjCProtocolExpr = 140,
        CXCursor_ObjCBridgedCastExpr = 141,
        CXCursor_PackExpansionExpr = 142,
        CXCursor_SizeOfPackExpr = 143,
        CXCursor_LambdaExpr = 144,
        CXCursor_ObjCBoolLiteralExpr = 145,
        CXCursor_ObjCSelfExpr = 146,
        CXCursor_OMPArraySectionExpr = 147,
        CXCursor_ObjCAvailabilityCheckExpr = 148,
        CXCursor_FixedPointLiteral = 149,
        CXCursor_OMPArrayShapingExpr = 150,
        CXCursor_OMPIteratorExpr = 151,
        CXCursor_CXXAddrspaceCastExpr = 152,
        CXCursor_LastExpr = CXCursor_CXXAddrspaceCastExpr,
        CXCursor_FirstStmt = 200,
        CXCursor_UnexposedStmt = 200,
        CXCursor_LabelStmt = 201,
        CXCursor_CompoundStmt = 202,
        CXCursor_CaseStmt = 203,
        CXCursor_DefaultStmt = 204,
        CXCursor_IfStmt = 205,
        CXCursor_SwitchStmt = 206,
        CXCursor_WhileStmt = 207,
        CXCursor_DoStmt = 208,
        CXCursor_ForStmt = 209,
        CXCursor_GotoStmt = 210,
        CXCursor_IndirectGotoStmt = 211,
        CXCursor_ContinueStmt = 212,
        CXCursor_BreakStmt = 213,
        CXCursor_ReturnStmt = 214,
        CXCursor_GCCAsmStmt = 215,
        CXCursor_AsmStmt = CXCursor_GCCAsmStmt,
        CXCursor_ObjCAtTryStmt = 216,
        CXCursor_ObjCAtCatchStmt = 217,
        CXCursor_ObjCAtFinallyStmt = 218,
        CXCursor_ObjCAtThrowStmt = 219,
        CXCursor_ObjCAtSynchronizedStmt = 220,
        CXCursor_ObjCAutoreleasePoolStmt = 221,
        CXCursor_ObjCForCollectionStmt = 222,
        CXCursor_CXXCatchStmt = 223,
        CXCursor_CXXTryStmt = 224,
        CXCursor_CXXForRangeStmt = 225,
        CXCursor_SEHTryStmt = 226,
        CXCursor_SEHExceptStmt = 227,
        CXCursor_SEHFinallyStmt = 228,
        CXCursor_MSAsmStmt = 229,
        CXCursor_NullStmt = 230,
        CXCursor_DeclStmt = 231,
        CXCursor_OMPParallelDirective = 232,
        CXCursor_OMPSimdDirective = 233,
        CXCursor_OMPForDirective = 234,
        CXCursor_OMPSectionsDirective = 235,
        CXCursor_OMPSectionDirective = 236,
        CXCursor_OMPSingleDirective = 237,
        CXCursor_OMPParallelForDirective = 238,
        CXCursor_OMPParallelSectionsDirective = 239,
        CXCursor_OMPTaskDirective = 240,
        CXCursor_OMPMasterDirective = 241,
        CXCursor_OMPCriticalDirective = 242,
        CXCursor_OMPTaskyieldDirective = 243,
        CXCursor_OMPBarrierDirective = 244,
        CXCursor_OMPTaskwaitDirective = 245,
        CXCursor_OMPFlushDirective = 246,
        CXCursor_SEHLeaveStmt = 247,
        CXCursor_OMPOrderedDirective = 248,
        CXCursor_OMPAtomicDirective = 249,
        CXCursor_OMPForSimdDirective = 250,
        CXCursor_OMPParallelForSimdDirective = 251,
        CXCursor_OMPTargetDirective = 252,
        CXCursor_OMPTeamsDirective = 253,
        CXCursor_OMPTaskgroupDirective = 254,
        CXCursor_OMPCancellationPointDirective = 255,
        CXCursor_OMPCancelDirective = 256,
        CXCursor_OMPTargetDataDirective = 257,
        CXCursor_OMPTaskLoopDirective = 258,
        CXCursor_OMPTaskLoopSimdDirective = 259,
        CXCursor_OMPDistributeDirective = 260,
        CXCursor_OMPTargetEnterDataDirective = 261,
        CXCursor_OMPTargetExitDataDirective = 262,
        CXCursor_OMPTargetParallelDirective = 263,
        CXCursor_OMPTargetParallelForDirective = 264,
        CXCursor_OMPTargetUpdateDirective = 265,
        CXCursor_OMPDistributeParallelForDirective = 266,
        CXCursor_OMPDistributeParallelForSimdDirective = 267,
        CXCursor_OMPDistributeSimdDirective = 268,
        CXCursor_OMPTargetParallelForSimdDirective = 269,
        CXCursor_OMPTargetSimdDirective = 270,
        CXCursor_OMPTeamsDistributeDirective = 271,
        CXCursor_OMPTeamsDistributeSimdDirective = 272,
        CXCursor_OMPTeamsDistributeParallelForSimdDirective = 273,
        CXCursor_OMPTeamsDistributeParallelForDirective = 274,
        CXCursor_OMPTargetTeamsDirective = 275,
        CXCursor_OMPTargetTeamsDistributeDirective = 276,
        CXCursor_OMPTargetTeamsDistributeParallelForDirective = 277,
        CXCursor_OMPTargetTeamsDistributeParallelForSimdDirective = 278,
        CXCursor_OMPTargetTeamsDistributeSimdDirective = 279,
        CXCursor_BuiltinBitCastExpr = 280,
        CXCursor_OMPMasterTaskLoopDirective = 281,
        CXCursor_OMPParallelMasterTaskLoopDirective = 282,
        CXCursor_OMPMasterTaskLoopSimdDirective = 283,
        CXCursor_OMPParallelMasterTaskLoopSimdDirective = 284,
        CXCursor_OMPParallelMasterDirective = 285,
        CXCursor_OMPDepobjDirective = 286,
        CXCursor_OMPScanDirective = 287,
        CXCursor_OMPTileDirective = 288,
        CXCursor_OMPCanonicalLoop = 289,
        CXCursor_OMPInteropDirective = 290,
        CXCursor_OMPDispatchDirective = 291,
        CXCursor_OMPMaskedDirective = 292,
        CXCursor_OMPUnrollDirective = 293,
        CXCursor_LastStmt = CXCursor_OMPUnrollDirective,
        CXCursor_TranslationUnit = 300,
        CXCursor_FirstAttr = 400,
        CXCursor_UnexposedAttr = 400,
        CXCursor_IBActionAttr = 401,
        CXCursor_IBOutletAttr = 402,
        CXCursor_IBOutletCollectionAttr = 403,
        CXCursor_CXXFinalAttr = 404,
        CXCursor_CXXOverrideAttr = 405,
        CXCursor_AnnotateAttr = 406,
        CXCursor_AsmLabelAttr = 407,
        CXCursor_PackedAttr = 408,
        CXCursor_PureAttr = 409,
        CXCursor_ConstAttr = 410,
        CXCursor_NoDuplicateAttr = 411,
        CXCursor_CUDAConstantAttr = 412,
        CXCursor_CUDADeviceAttr = 413,
        CXCursor_CUDAGlobalAttr = 414,
        CXCursor_CUDAHostAttr = 415,
        CXCursor_CUDASharedAttr = 416,
        CXCursor_VisibilityAttr = 417,
        CXCursor_DLLExport = 418,
        CXCursor_DLLImport = 419,
        CXCursor_NSReturnsRetained = 420,
        CXCursor_NSReturnsNotRetained = 421,
        CXCursor_NSReturnsAutoreleased = 422,
        CXCursor_NSConsumesSelf = 423,
        CXCursor_NSConsumed = 424,
        CXCursor_ObjCException = 425,
        CXCursor_ObjCNSObject = 426,
        CXCursor_ObjCIndependentClass = 427,
        CXCursor_ObjCPreciseLifetime = 428,
        CXCursor_ObjCReturnsInnerPointer = 429,
        CXCursor_ObjCRequiresSuper = 430,
        CXCursor_ObjCRootClass = 431,
        CXCursor_ObjCSubclassingRestricted = 432,
        CXCursor_ObjCExplicitProtocolImpl = 433,
        CXCursor_ObjCDesignatedInitializer = 434,
        CXCursor_ObjCRuntimeVisible = 435,
        CXCursor_ObjCBoxable = 436,
        CXCursor_FlagEnum = 437,
        CXCursor_ConvergentAttr = 438,
        CXCursor_WarnUnusedAttr = 439,
        CXCursor_WarnUnusedResultAttr = 440,
        CXCursor_AlignedAttr = 441,
        CXCursor_LastAttr = CXCursor_AlignedAttr,
        CXCursor_PreprocessingDirective = 500,
        CXCursor_MacroDefinition = 501,
        CXCursor_MacroExpansion = 502,
        CXCursor_MacroInstantiation = CXCursor_MacroExpansion,
        CXCursor_InclusionDirective = 503,
        CXCursor_FirstPreprocessing = CXCursor_PreprocessingDirective,
        CXCursor_LastPreprocessing = CXCursor_InclusionDirective,
        CXCursor_ModuleImportDecl = 600,
        CXCursor_TypeAliasTemplateDecl = 601,
        CXCursor_StaticAssert = 602,
        CXCursor_FriendDecl = 603,
        CXCursor_FirstExtraDecl = CXCursor_ModuleImportDecl,
        CXCursor_LastExtraDecl = CXCursor_FriendDecl,
        CXCursor_OverloadCandidate = 700,
    }
}
