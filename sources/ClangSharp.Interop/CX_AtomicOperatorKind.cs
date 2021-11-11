// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://github.com/microsoft/ClangSharp/blob/main/sources/libClangSharp

namespace ClangSharp.Interop
{
    public enum CX_AtomicOperatorKind
    {
        CX_AO_Invalid,
        CX_AO__c11_atomic_init,
        CX_AO__c11_atomic_load,
        CX_AO__c11_atomic_store,
        CX_AO__c11_atomic_exchange,
        CX_AO__c11_atomic_compare_exchange_strong,
        CX_AO__c11_atomic_compare_exchange_weak,
        CX_AO__c11_atomic_fetch_add,
        CX_AO__c11_atomic_fetch_sub,
        CX_AO__c11_atomic_fetch_and,
        CX_AO__c11_atomic_fetch_or,
        CX_AO__c11_atomic_fetch_xor,
        CX_AO__c11_atomic_fetch_max,
        CX_AO__c11_atomic_fetch_min,
        CX_AO__atomic_load,
        CX_AO__atomic_load_n,
        CX_AO__atomic_store,
        CX_AO__atomic_store_n,
        CX_AO__atomic_exchange,
        CX_AO__atomic_exchange_n,
        CX_AO__atomic_compare_exchange,
        CX_AO__atomic_compare_exchange_n,
        CX_AO__atomic_fetch_add,
        CX_AO__atomic_fetch_sub,
        CX_AO__atomic_fetch_and,
        CX_AO__atomic_fetch_or,
        CX_AO__atomic_fetch_xor,
        CX_AO__atomic_fetch_nand,
        CX_AO__atomic_add_fetch,
        CX_AO__atomic_sub_fetch,
        CX_AO__atomic_and_fetch,
        CX_AO__atomic_or_fetch,
        CX_AO__atomic_xor_fetch,
        CX_AO__atomic_max_fetch,
        CX_AO__atomic_min_fetch,
        CX_AO__atomic_nand_fetch,
        CX_AO__opencl_atomic_init,
        CX_AO__opencl_atomic_load,
        CX_AO__opencl_atomic_store,
        CX_AO__opencl_atomic_exchange,
        CX_AO__opencl_atomic_compare_exchange_strong,
        CX_AO__opencl_atomic_compare_exchange_weak,
        CX_AO__opencl_atomic_fetch_add,
        CX_AO__opencl_atomic_fetch_sub,
        CX_AO__opencl_atomic_fetch_and,
        CX_AO__opencl_atomic_fetch_or,
        CX_AO__opencl_atomic_fetch_xor,
        CX_AO__opencl_atomic_fetch_min,
        CX_AO__opencl_atomic_fetch_max,
        CX_AO__atomic_fetch_min,
        CX_AO__atomic_fetch_max,
    }
}
