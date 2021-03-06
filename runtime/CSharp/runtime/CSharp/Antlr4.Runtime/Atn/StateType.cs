/* Copyright (c) 2012-2016 The ANTLR Project. All rights reserved.
 * Use of this file is governed by the BSD 3-clause license that
 * can be found in the LICENSE.txt file in the project root.
 */
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Sharpen;

namespace Antlr4.Runtime.Atn
{
    public enum StateType
    {
        InvalidType,
        Basic,
        RuleStart,
        BlockStart,
        PlusBlockStart,
        StarBlockStart,
        TokenStart,
        RuleStop,
        BlockEnd,
        StarLoopBack,
        StarLoopEntry,
        PlusLoopBack,
        LoopEnd
    }
}
