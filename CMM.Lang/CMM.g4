grammar CMM;

expression//表达式
    :
    | '(' expression ')'
    | number
    | expression operatorMulDiv expression
    | expression operatorAddSub expression
    ;

operatorAddSub//加减运算符
    : '+'|'-';

operatorMulDiv//乘除运算符
    : '*'|'/';

number
    : INT | FLOAT
    ;

fragment
Digit //数字
    : [0-9]
    ;
    
fragment
ExponentPart//指数
    : [eE] [+-]? Digit+
    ;
    
FLOAT
    : Digit+ '.' Digit* ExponentPart?
    | '.' Digit+ ExponentPart?
    | Digit+ ExponentPart
    ;

INT
    : Digit+
    ;