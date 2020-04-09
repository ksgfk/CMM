grammar CMM;

chunk//代码块,一个文件一个chunk
    : block EOF
    ;

block//子代码块
    : stat* retstat?
    ;
    
stat//语句
    : ';'
    | type funcname funcbody
    ;
    
retstat//返回语句,暂时没有用
    : 'return' explist? ';'?
    ;

funcname//函数名
    : NAME ('.' NAME)*
    ;
    
explist//表达式列表
    : expression (',' expression)*
    ;
    
funcbody//函数体
    : '(' paramlist? ')' '{' block '}'
    ;
    
paramlist//参数列表
    : param (',' param)?
    ;
    
param//参数
    : type NAME
    ;

expression//表达式
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

number//数字
    : INT       #Int
    | DOUBLE    #Double
    | FLOAT     #Float
    ;

field//字段
    : NAME
    ;
    
type//类型
    : ('void'
    | 'char'
    | 'int'
    | 'float'
    | 'double'
    | 'string')
    ;

fragment
Digit //数字
    : [0-9]
    ;

fragment
ExponentPart//指数
    : [eE] [+-]? Digit+
    ;

FLOATSIGN
    : 'f'
    | 'F'
    ;

FLOAT
    : Digit+ FLOATSIGN
    | Digit+ '.' Digit* ExponentPart? FLOATSIGN
    | '.' Digit+ ExponentPart? FLOATSIGN
    | Digit+ ExponentPart FLOATSIGN
    ;
    
DOUBLESIGN
    : 'd'
    | 'D'
    ;
    
DOUBLE
    : Digit+ DOUBLESIGN
    | Digit+ '.' Digit* ExponentPart? DOUBLESIGN
    | Digit+ '.' Digit* ExponentPart?
    | '.' Digit+ ExponentPart? DOUBLESIGN
    | '.' Digit+ ExponentPart?
    | Digit+ ExponentPart DOUBLESIGN
    | Digit+ ExponentPart
    ;

INT
    : Digit+
    ;

NAME//名称，可以是变量的
    : [a-zA-Z_][a-zA-Z_0-9]*
    ;

WS  
    : [ \t\u000C\r\n]+ -> skip
    ;
    
SHEBANG
    : '#' '!' ~('\n'|'\r')* -> channel(HIDDEN)
    ;