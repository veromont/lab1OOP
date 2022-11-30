grammar AntlrCalc;

compileUnit : expression EOF;
expression :
	LPAREN expression RPAREN #ParenthesizedExpr
	|expression EXPONENT expression #ExponentialExpr
	| expression operatorToken=(MULTIPLY | DIVIDE) expression #MultiplicativeExpr
	| expression operatorToken=(ADD | SUBTRACT) expression #AdditiveExpr
	| NUMBER #NumberExpr
	| IDENTIFIER #IdentifierExpr
	;

NUMBER : INT ('.' INT)?;
IDENTIFIER : [A-Z]+ [1-9]([0-9]+)?;
INT : ('0'..'9')+;
EXPONENT : '^';
MULTIPLY : '*';
DIVIDE : '/';
SUBTRACT : '-';
ADD : '+';
LPAREN : '(';
RPAREN : ')';

WS : [ \t\r\n] -> channel(HIDDEN);