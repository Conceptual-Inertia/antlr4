/* Copyright (c) 2012-2016 The ANTLR Project. All rights reserved.
 * Use of this file is governed by the BSD 3-clause license that
 * can be found in the LICENSE.txt file in the project root.
 */
using Antlr4.Runtime;
using Antlr4.Runtime.Sharpen;
using Antlr4.Runtime.Tree;

namespace Antlr4.Runtime.Tree
{
    public interface ITerminalNode : IParseTree
    {
        IToken Symbol
        {
            get;
        }

        new IRuleNode Parent
        {
            get;
        }
    }
}
