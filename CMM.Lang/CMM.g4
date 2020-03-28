grammar CMM;

expression//表达式
    :
    | '(' expression ')'
    | number
    | expression operatorMulDiv expression
    | expression operatorAddSub expression
    | field | field operatorAssign expression
    | 'print(' expression ')'
    ;

operatorAddSub//加减运算符
    : '+'|'-';

operatorMulDiv//乘除运算符
    : '*'|'/';

operatorAssign//赋值运算符
    : '=';

number
    : INT | FLOAT
    ;
    
field//字段
    : NAME
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
    
NAME//名称，可以是变量的
    : [a-zA-Z_][a-zA-Z_0-9]*
    ;
    
WS//跳过解析空格，转义字符
    : [ \t\r\n]+ -> skip
    ;