/*
 * Copyright (c) 2012-2016 The ANTLR Project. All rights reserved.
 * Use of this file is governed by the BSD 3-clause license that
 * can be found in the LICENSE.txt file in the project root.
 */

package org.antlr.v4.codegen;

import org.antlr.v4.codegen.model.MatchToken;
import org.antlr.v4.tool.ast.GrammarAST;

public class Wildcard extends MatchToken {
	public Wildcard(OutputModelFactory factory, GrammarAST ast) {
		super(factory, ast);
	}
}
