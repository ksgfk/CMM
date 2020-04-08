grammar CMM;

expression
    :'(' expression ')'                         #Parent
    | number                                    #Num
    | expression operatorMulDiv expression      #MulDiv
    | expression operatorAddSub expression      #AddSub
    | field                                     #Variable
    | field operatorAssign expression           #Assign
    ;

operatorAddSub//加减运算符
    : '+' #Add
    | '-' #Sub
    ;

operatorMulDiv//乘除运算符
    : '*' #Mul
    | '/' #Div
    ;

operatorAssign//赋值运算符
    : '='
    ;

number
    : INT       #Int
    | DOUBLE    #Double
    | FLOAT     #Float
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
    : Digit+ 'f'
    | Digit+ '.' Digit* ExponentPart? 'f'
    | '.' Digit+ ExponentPart? 'f'
    | Digit+ ExponentPart 'f'
    ;
    
DOUBLE
    : Digit+ 'd'
    | Digit+ '.' Digit* ExponentPart? 'd'
    | Digit+ '.' Digit* ExponentPart?
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