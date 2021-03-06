//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from CMM.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class CMMLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, FLOATSIGN=20, FLOAT=21, DOUBLESIGN=22, DOUBLE=23, 
		INT=24, NAME=25, WS=26, SHEBANG=27;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "Digit", "ExponentPart", "FLOATSIGN", "FLOAT", "DOUBLESIGN", 
		"DOUBLE", "INT", "NAME", "WS", "SHEBANG"
	};


	public CMMLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public CMMLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "'return'", "'.'", "','", "'('", "')'", "'{'", "'}'", "'+'", 
		"'-'", "'*'", "'/'", "'='", "'void'", "'char'", "'int'", "'float'", "'double'", 
		"'string'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, "FLOATSIGN", "FLOAT", 
		"DOUBLESIGN", "DOUBLE", "INT", "NAME", "WS", "SHEBANG"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "CMM.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static CMMLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x1D', '\x123', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', 
		'\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', 
		'\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', 
		'\x5', '\x16', '\x83', '\n', '\x16', '\x3', '\x16', '\x6', '\x16', '\x86', 
		'\n', '\x16', '\r', '\x16', '\xE', '\x16', '\x87', '\x3', '\x17', '\x3', 
		'\x17', '\x3', '\x18', '\x6', '\x18', '\x8D', '\n', '\x18', '\r', '\x18', 
		'\xE', '\x18', '\x8E', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x6', 
		'\x18', '\x94', '\n', '\x18', '\r', '\x18', '\xE', '\x18', '\x95', '\x3', 
		'\x18', '\x3', '\x18', '\a', '\x18', '\x9A', '\n', '\x18', '\f', '\x18', 
		'\xE', '\x18', '\x9D', '\v', '\x18', '\x3', '\x18', '\x5', '\x18', '\xA0', 
		'\n', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', 
		'\x6', '\x18', '\xA6', '\n', '\x18', '\r', '\x18', '\xE', '\x18', '\xA7', 
		'\x3', '\x18', '\x5', '\x18', '\xAB', '\n', '\x18', '\x3', '\x18', '\x3', 
		'\x18', '\x3', '\x18', '\x6', '\x18', '\xB0', '\n', '\x18', '\r', '\x18', 
		'\xE', '\x18', '\xB1', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x5', 
		'\x18', '\xB7', '\n', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', 
		'\x6', '\x1A', '\xBC', '\n', '\x1A', '\r', '\x1A', '\xE', '\x1A', '\xBD', 
		'\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x6', '\x1A', '\xC3', '\n', 
		'\x1A', '\r', '\x1A', '\xE', '\x1A', '\xC4', '\x3', '\x1A', '\x3', '\x1A', 
		'\a', '\x1A', '\xC9', '\n', '\x1A', '\f', '\x1A', '\xE', '\x1A', '\xCC', 
		'\v', '\x1A', '\x3', '\x1A', '\x5', '\x1A', '\xCF', '\n', '\x1A', '\x3', 
		'\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x6', '\x1A', '\xD4', '\n', '\x1A', 
		'\r', '\x1A', '\xE', '\x1A', '\xD5', '\x3', '\x1A', '\x3', '\x1A', '\a', 
		'\x1A', '\xDA', '\n', '\x1A', '\f', '\x1A', '\xE', '\x1A', '\xDD', '\v', 
		'\x1A', '\x3', '\x1A', '\x5', '\x1A', '\xE0', '\n', '\x1A', '\x3', '\x1A', 
		'\x3', '\x1A', '\x6', '\x1A', '\xE4', '\n', '\x1A', '\r', '\x1A', '\xE', 
		'\x1A', '\xE5', '\x3', '\x1A', '\x5', '\x1A', '\xE9', '\n', '\x1A', '\x3', 
		'\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x6', '\x1A', '\xEF', 
		'\n', '\x1A', '\r', '\x1A', '\xE', '\x1A', '\xF0', '\x3', '\x1A', '\x5', 
		'\x1A', '\xF4', '\n', '\x1A', '\x3', '\x1A', '\x6', '\x1A', '\xF7', '\n', 
		'\x1A', '\r', '\x1A', '\xE', '\x1A', '\xF8', '\x3', '\x1A', '\x3', '\x1A', 
		'\x3', '\x1A', '\x3', '\x1A', '\x6', '\x1A', '\xFF', '\n', '\x1A', '\r', 
		'\x1A', '\xE', '\x1A', '\x100', '\x3', '\x1A', '\x3', '\x1A', '\x5', '\x1A', 
		'\x105', '\n', '\x1A', '\x3', '\x1B', '\x6', '\x1B', '\x108', '\n', '\x1B', 
		'\r', '\x1B', '\xE', '\x1B', '\x109', '\x3', '\x1C', '\x3', '\x1C', '\a', 
		'\x1C', '\x10E', '\n', '\x1C', '\f', '\x1C', '\xE', '\x1C', '\x111', '\v', 
		'\x1C', '\x3', '\x1D', '\x6', '\x1D', '\x114', '\n', '\x1D', '\r', '\x1D', 
		'\xE', '\x1D', '\x115', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', '\x3', 
		'\x1E', '\x3', '\x1E', '\a', '\x1E', '\x11D', '\n', '\x1E', '\f', '\x1E', 
		'\xE', '\x1E', '\x120', '\v', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x2', 
		'\x2', '\x1F', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', 
		'\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', 
		'\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', 
		'!', '\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x2', '+', 
		'\x2', '-', '\x16', '/', '\x17', '\x31', '\x18', '\x33', '\x19', '\x35', 
		'\x1A', '\x37', '\x1B', '\x39', '\x1C', ';', '\x1D', '\x3', '\x2', '\v', 
		'\x3', '\x2', '\x32', ';', '\x4', '\x2', 'G', 'G', 'g', 'g', '\x4', '\x2', 
		'-', '-', '/', '/', '\x4', '\x2', 'H', 'H', 'h', 'h', '\x4', '\x2', '\x46', 
		'\x46', '\x66', '\x66', '\x5', '\x2', '\x43', '\\', '\x61', '\x61', '\x63', 
		'|', '\x6', '\x2', '\x32', ';', '\x43', '\\', '\x61', '\x61', '\x63', 
		'|', '\x5', '\x2', '\v', '\f', '\xE', '\xF', '\"', '\"', '\x4', '\x2', 
		'\f', '\f', '\xF', '\xF', '\x2', '\x143', '\x2', '\x3', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\'', '\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x39', '\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '=', '\x3', '\x2', '\x2', '\x2', '\x5', '?', '\x3', '\x2', '\x2', 
		'\x2', '\a', '\x46', '\x3', '\x2', '\x2', '\x2', '\t', 'H', '\x3', '\x2', 
		'\x2', '\x2', '\v', 'J', '\x3', '\x2', '\x2', '\x2', '\r', 'L', '\x3', 
		'\x2', '\x2', '\x2', '\xF', 'N', '\x3', '\x2', '\x2', '\x2', '\x11', 'P', 
		'\x3', '\x2', '\x2', '\x2', '\x13', 'R', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'T', '\x3', '\x2', '\x2', '\x2', '\x17', 'V', '\x3', '\x2', '\x2', '\x2', 
		'\x19', 'X', '\x3', '\x2', '\x2', '\x2', '\x1B', 'Z', '\x3', '\x2', '\x2', 
		'\x2', '\x1D', '\\', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x61', '\x3', 
		'\x2', '\x2', '\x2', '!', '\x66', '\x3', '\x2', '\x2', '\x2', '#', 'j', 
		'\x3', '\x2', '\x2', '\x2', '%', 'p', '\x3', '\x2', '\x2', '\x2', '\'', 
		'w', '\x3', '\x2', '\x2', '\x2', ')', '~', '\x3', '\x2', '\x2', '\x2', 
		'+', '\x80', '\x3', '\x2', '\x2', '\x2', '-', '\x89', '\x3', '\x2', '\x2', 
		'\x2', '/', '\xB6', '\x3', '\x2', '\x2', '\x2', '\x31', '\xB8', '\x3', 
		'\x2', '\x2', '\x2', '\x33', '\x104', '\x3', '\x2', '\x2', '\x2', '\x35', 
		'\x107', '\x3', '\x2', '\x2', '\x2', '\x37', '\x10B', '\x3', '\x2', '\x2', 
		'\x2', '\x39', '\x113', '\x3', '\x2', '\x2', '\x2', ';', '\x119', '\x3', 
		'\x2', '\x2', '\x2', '=', '>', '\a', '=', '\x2', '\x2', '>', '\x4', '\x3', 
		'\x2', '\x2', '\x2', '?', '@', '\a', 't', '\x2', '\x2', '@', '\x41', '\a', 
		'g', '\x2', '\x2', '\x41', '\x42', '\a', 'v', '\x2', '\x2', '\x42', '\x43', 
		'\a', 'w', '\x2', '\x2', '\x43', '\x44', '\a', 't', '\x2', '\x2', '\x44', 
		'\x45', '\a', 'p', '\x2', '\x2', '\x45', '\x6', '\x3', '\x2', '\x2', '\x2', 
		'\x46', 'G', '\a', '\x30', '\x2', '\x2', 'G', '\b', '\x3', '\x2', '\x2', 
		'\x2', 'H', 'I', '\a', '.', '\x2', '\x2', 'I', '\n', '\x3', '\x2', '\x2', 
		'\x2', 'J', 'K', '\a', '*', '\x2', '\x2', 'K', '\f', '\x3', '\x2', '\x2', 
		'\x2', 'L', 'M', '\a', '+', '\x2', '\x2', 'M', '\xE', '\x3', '\x2', '\x2', 
		'\x2', 'N', 'O', '\a', '}', '\x2', '\x2', 'O', '\x10', '\x3', '\x2', '\x2', 
		'\x2', 'P', 'Q', '\a', '\x7F', '\x2', '\x2', 'Q', '\x12', '\x3', '\x2', 
		'\x2', '\x2', 'R', 'S', '\a', '-', '\x2', '\x2', 'S', '\x14', '\x3', '\x2', 
		'\x2', '\x2', 'T', 'U', '\a', '/', '\x2', '\x2', 'U', '\x16', '\x3', '\x2', 
		'\x2', '\x2', 'V', 'W', '\a', ',', '\x2', '\x2', 'W', '\x18', '\x3', '\x2', 
		'\x2', '\x2', 'X', 'Y', '\a', '\x31', '\x2', '\x2', 'Y', '\x1A', '\x3', 
		'\x2', '\x2', '\x2', 'Z', '[', '\a', '?', '\x2', '\x2', '[', '\x1C', '\x3', 
		'\x2', '\x2', '\x2', '\\', ']', '\a', 'x', '\x2', '\x2', ']', '^', '\a', 
		'q', '\x2', '\x2', '^', '_', '\a', 'k', '\x2', '\x2', '_', '`', '\a', 
		'\x66', '\x2', '\x2', '`', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x61', 
		'\x62', '\a', '\x65', '\x2', '\x2', '\x62', '\x63', '\a', 'j', '\x2', 
		'\x2', '\x63', '\x64', '\a', '\x63', '\x2', '\x2', '\x64', '\x65', '\a', 
		't', '\x2', '\x2', '\x65', ' ', '\x3', '\x2', '\x2', '\x2', '\x66', 'g', 
		'\a', 'k', '\x2', '\x2', 'g', 'h', '\a', 'p', '\x2', '\x2', 'h', 'i', 
		'\a', 'v', '\x2', '\x2', 'i', '\"', '\x3', '\x2', '\x2', '\x2', 'j', 'k', 
		'\a', 'h', '\x2', '\x2', 'k', 'l', '\a', 'n', '\x2', '\x2', 'l', 'm', 
		'\a', 'q', '\x2', '\x2', 'm', 'n', '\a', '\x63', '\x2', '\x2', 'n', 'o', 
		'\a', 'v', '\x2', '\x2', 'o', '$', '\x3', '\x2', '\x2', '\x2', 'p', 'q', 
		'\a', '\x66', '\x2', '\x2', 'q', 'r', '\a', 'q', '\x2', '\x2', 'r', 's', 
		'\a', 'w', '\x2', '\x2', 's', 't', '\a', '\x64', '\x2', '\x2', 't', 'u', 
		'\a', 'n', '\x2', '\x2', 'u', 'v', '\a', 'g', '\x2', '\x2', 'v', '&', 
		'\x3', '\x2', '\x2', '\x2', 'w', 'x', '\a', 'u', '\x2', '\x2', 'x', 'y', 
		'\a', 'v', '\x2', '\x2', 'y', 'z', '\a', 't', '\x2', '\x2', 'z', '{', 
		'\a', 'k', '\x2', '\x2', '{', '|', '\a', 'p', '\x2', '\x2', '|', '}', 
		'\a', 'i', '\x2', '\x2', '}', '(', '\x3', '\x2', '\x2', '\x2', '~', '\x7F', 
		'\t', '\x2', '\x2', '\x2', '\x7F', '*', '\x3', '\x2', '\x2', '\x2', '\x80', 
		'\x82', '\t', '\x3', '\x2', '\x2', '\x81', '\x83', '\t', '\x4', '\x2', 
		'\x2', '\x82', '\x81', '\x3', '\x2', '\x2', '\x2', '\x82', '\x83', '\x3', 
		'\x2', '\x2', '\x2', '\x83', '\x85', '\x3', '\x2', '\x2', '\x2', '\x84', 
		'\x86', '\x5', ')', '\x15', '\x2', '\x85', '\x84', '\x3', '\x2', '\x2', 
		'\x2', '\x86', '\x87', '\x3', '\x2', '\x2', '\x2', '\x87', '\x85', '\x3', 
		'\x2', '\x2', '\x2', '\x87', '\x88', '\x3', '\x2', '\x2', '\x2', '\x88', 
		',', '\x3', '\x2', '\x2', '\x2', '\x89', '\x8A', '\t', '\x5', '\x2', '\x2', 
		'\x8A', '.', '\x3', '\x2', '\x2', '\x2', '\x8B', '\x8D', '\x5', ')', '\x15', 
		'\x2', '\x8C', '\x8B', '\x3', '\x2', '\x2', '\x2', '\x8D', '\x8E', '\x3', 
		'\x2', '\x2', '\x2', '\x8E', '\x8C', '\x3', '\x2', '\x2', '\x2', '\x8E', 
		'\x8F', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x90', '\x3', '\x2', '\x2', 
		'\x2', '\x90', '\x91', '\x5', '-', '\x17', '\x2', '\x91', '\xB7', '\x3', 
		'\x2', '\x2', '\x2', '\x92', '\x94', '\x5', ')', '\x15', '\x2', '\x93', 
		'\x92', '\x3', '\x2', '\x2', '\x2', '\x94', '\x95', '\x3', '\x2', '\x2', 
		'\x2', '\x95', '\x93', '\x3', '\x2', '\x2', '\x2', '\x95', '\x96', '\x3', 
		'\x2', '\x2', '\x2', '\x96', '\x97', '\x3', '\x2', '\x2', '\x2', '\x97', 
		'\x9B', '\a', '\x30', '\x2', '\x2', '\x98', '\x9A', '\x5', ')', '\x15', 
		'\x2', '\x99', '\x98', '\x3', '\x2', '\x2', '\x2', '\x9A', '\x9D', '\x3', 
		'\x2', '\x2', '\x2', '\x9B', '\x99', '\x3', '\x2', '\x2', '\x2', '\x9B', 
		'\x9C', '\x3', '\x2', '\x2', '\x2', '\x9C', '\x9F', '\x3', '\x2', '\x2', 
		'\x2', '\x9D', '\x9B', '\x3', '\x2', '\x2', '\x2', '\x9E', '\xA0', '\x5', 
		'+', '\x16', '\x2', '\x9F', '\x9E', '\x3', '\x2', '\x2', '\x2', '\x9F', 
		'\xA0', '\x3', '\x2', '\x2', '\x2', '\xA0', '\xA1', '\x3', '\x2', '\x2', 
		'\x2', '\xA1', '\xA2', '\x5', '-', '\x17', '\x2', '\xA2', '\xB7', '\x3', 
		'\x2', '\x2', '\x2', '\xA3', '\xA5', '\a', '\x30', '\x2', '\x2', '\xA4', 
		'\xA6', '\x5', ')', '\x15', '\x2', '\xA5', '\xA4', '\x3', '\x2', '\x2', 
		'\x2', '\xA6', '\xA7', '\x3', '\x2', '\x2', '\x2', '\xA7', '\xA5', '\x3', 
		'\x2', '\x2', '\x2', '\xA7', '\xA8', '\x3', '\x2', '\x2', '\x2', '\xA8', 
		'\xAA', '\x3', '\x2', '\x2', '\x2', '\xA9', '\xAB', '\x5', '+', '\x16', 
		'\x2', '\xAA', '\xA9', '\x3', '\x2', '\x2', '\x2', '\xAA', '\xAB', '\x3', 
		'\x2', '\x2', '\x2', '\xAB', '\xAC', '\x3', '\x2', '\x2', '\x2', '\xAC', 
		'\xAD', '\x5', '-', '\x17', '\x2', '\xAD', '\xB7', '\x3', '\x2', '\x2', 
		'\x2', '\xAE', '\xB0', '\x5', ')', '\x15', '\x2', '\xAF', '\xAE', '\x3', 
		'\x2', '\x2', '\x2', '\xB0', '\xB1', '\x3', '\x2', '\x2', '\x2', '\xB1', 
		'\xAF', '\x3', '\x2', '\x2', '\x2', '\xB1', '\xB2', '\x3', '\x2', '\x2', 
		'\x2', '\xB2', '\xB3', '\x3', '\x2', '\x2', '\x2', '\xB3', '\xB4', '\x5', 
		'+', '\x16', '\x2', '\xB4', '\xB5', '\x5', '-', '\x17', '\x2', '\xB5', 
		'\xB7', '\x3', '\x2', '\x2', '\x2', '\xB6', '\x8C', '\x3', '\x2', '\x2', 
		'\x2', '\xB6', '\x93', '\x3', '\x2', '\x2', '\x2', '\xB6', '\xA3', '\x3', 
		'\x2', '\x2', '\x2', '\xB6', '\xAF', '\x3', '\x2', '\x2', '\x2', '\xB7', 
		'\x30', '\x3', '\x2', '\x2', '\x2', '\xB8', '\xB9', '\t', '\x6', '\x2', 
		'\x2', '\xB9', '\x32', '\x3', '\x2', '\x2', '\x2', '\xBA', '\xBC', '\x5', 
		')', '\x15', '\x2', '\xBB', '\xBA', '\x3', '\x2', '\x2', '\x2', '\xBC', 
		'\xBD', '\x3', '\x2', '\x2', '\x2', '\xBD', '\xBB', '\x3', '\x2', '\x2', 
		'\x2', '\xBD', '\xBE', '\x3', '\x2', '\x2', '\x2', '\xBE', '\xBF', '\x3', 
		'\x2', '\x2', '\x2', '\xBF', '\xC0', '\x5', '\x31', '\x19', '\x2', '\xC0', 
		'\x105', '\x3', '\x2', '\x2', '\x2', '\xC1', '\xC3', '\x5', ')', '\x15', 
		'\x2', '\xC2', '\xC1', '\x3', '\x2', '\x2', '\x2', '\xC3', '\xC4', '\x3', 
		'\x2', '\x2', '\x2', '\xC4', '\xC2', '\x3', '\x2', '\x2', '\x2', '\xC4', 
		'\xC5', '\x3', '\x2', '\x2', '\x2', '\xC5', '\xC6', '\x3', '\x2', '\x2', 
		'\x2', '\xC6', '\xCA', '\a', '\x30', '\x2', '\x2', '\xC7', '\xC9', '\x5', 
		')', '\x15', '\x2', '\xC8', '\xC7', '\x3', '\x2', '\x2', '\x2', '\xC9', 
		'\xCC', '\x3', '\x2', '\x2', '\x2', '\xCA', '\xC8', '\x3', '\x2', '\x2', 
		'\x2', '\xCA', '\xCB', '\x3', '\x2', '\x2', '\x2', '\xCB', '\xCE', '\x3', 
		'\x2', '\x2', '\x2', '\xCC', '\xCA', '\x3', '\x2', '\x2', '\x2', '\xCD', 
		'\xCF', '\x5', '+', '\x16', '\x2', '\xCE', '\xCD', '\x3', '\x2', '\x2', 
		'\x2', '\xCE', '\xCF', '\x3', '\x2', '\x2', '\x2', '\xCF', '\xD0', '\x3', 
		'\x2', '\x2', '\x2', '\xD0', '\xD1', '\x5', '\x31', '\x19', '\x2', '\xD1', 
		'\x105', '\x3', '\x2', '\x2', '\x2', '\xD2', '\xD4', '\x5', ')', '\x15', 
		'\x2', '\xD3', '\xD2', '\x3', '\x2', '\x2', '\x2', '\xD4', '\xD5', '\x3', 
		'\x2', '\x2', '\x2', '\xD5', '\xD3', '\x3', '\x2', '\x2', '\x2', '\xD5', 
		'\xD6', '\x3', '\x2', '\x2', '\x2', '\xD6', '\xD7', '\x3', '\x2', '\x2', 
		'\x2', '\xD7', '\xDB', '\a', '\x30', '\x2', '\x2', '\xD8', '\xDA', '\x5', 
		')', '\x15', '\x2', '\xD9', '\xD8', '\x3', '\x2', '\x2', '\x2', '\xDA', 
		'\xDD', '\x3', '\x2', '\x2', '\x2', '\xDB', '\xD9', '\x3', '\x2', '\x2', 
		'\x2', '\xDB', '\xDC', '\x3', '\x2', '\x2', '\x2', '\xDC', '\xDF', '\x3', 
		'\x2', '\x2', '\x2', '\xDD', '\xDB', '\x3', '\x2', '\x2', '\x2', '\xDE', 
		'\xE0', '\x5', '+', '\x16', '\x2', '\xDF', '\xDE', '\x3', '\x2', '\x2', 
		'\x2', '\xDF', '\xE0', '\x3', '\x2', '\x2', '\x2', '\xE0', '\x105', '\x3', 
		'\x2', '\x2', '\x2', '\xE1', '\xE3', '\a', '\x30', '\x2', '\x2', '\xE2', 
		'\xE4', '\x5', ')', '\x15', '\x2', '\xE3', '\xE2', '\x3', '\x2', '\x2', 
		'\x2', '\xE4', '\xE5', '\x3', '\x2', '\x2', '\x2', '\xE5', '\xE3', '\x3', 
		'\x2', '\x2', '\x2', '\xE5', '\xE6', '\x3', '\x2', '\x2', '\x2', '\xE6', 
		'\xE8', '\x3', '\x2', '\x2', '\x2', '\xE7', '\xE9', '\x5', '+', '\x16', 
		'\x2', '\xE8', '\xE7', '\x3', '\x2', '\x2', '\x2', '\xE8', '\xE9', '\x3', 
		'\x2', '\x2', '\x2', '\xE9', '\xEA', '\x3', '\x2', '\x2', '\x2', '\xEA', 
		'\xEB', '\x5', '\x31', '\x19', '\x2', '\xEB', '\x105', '\x3', '\x2', '\x2', 
		'\x2', '\xEC', '\xEE', '\a', '\x30', '\x2', '\x2', '\xED', '\xEF', '\x5', 
		')', '\x15', '\x2', '\xEE', '\xED', '\x3', '\x2', '\x2', '\x2', '\xEF', 
		'\xF0', '\x3', '\x2', '\x2', '\x2', '\xF0', '\xEE', '\x3', '\x2', '\x2', 
		'\x2', '\xF0', '\xF1', '\x3', '\x2', '\x2', '\x2', '\xF1', '\xF3', '\x3', 
		'\x2', '\x2', '\x2', '\xF2', '\xF4', '\x5', '+', '\x16', '\x2', '\xF3', 
		'\xF2', '\x3', '\x2', '\x2', '\x2', '\xF3', '\xF4', '\x3', '\x2', '\x2', 
		'\x2', '\xF4', '\x105', '\x3', '\x2', '\x2', '\x2', '\xF5', '\xF7', '\x5', 
		')', '\x15', '\x2', '\xF6', '\xF5', '\x3', '\x2', '\x2', '\x2', '\xF7', 
		'\xF8', '\x3', '\x2', '\x2', '\x2', '\xF8', '\xF6', '\x3', '\x2', '\x2', 
		'\x2', '\xF8', '\xF9', '\x3', '\x2', '\x2', '\x2', '\xF9', '\xFA', '\x3', 
		'\x2', '\x2', '\x2', '\xFA', '\xFB', '\x5', '+', '\x16', '\x2', '\xFB', 
		'\xFC', '\x5', '\x31', '\x19', '\x2', '\xFC', '\x105', '\x3', '\x2', '\x2', 
		'\x2', '\xFD', '\xFF', '\x5', ')', '\x15', '\x2', '\xFE', '\xFD', '\x3', 
		'\x2', '\x2', '\x2', '\xFF', '\x100', '\x3', '\x2', '\x2', '\x2', '\x100', 
		'\xFE', '\x3', '\x2', '\x2', '\x2', '\x100', '\x101', '\x3', '\x2', '\x2', 
		'\x2', '\x101', '\x102', '\x3', '\x2', '\x2', '\x2', '\x102', '\x103', 
		'\x5', '+', '\x16', '\x2', '\x103', '\x105', '\x3', '\x2', '\x2', '\x2', 
		'\x104', '\xBB', '\x3', '\x2', '\x2', '\x2', '\x104', '\xC2', '\x3', '\x2', 
		'\x2', '\x2', '\x104', '\xD3', '\x3', '\x2', '\x2', '\x2', '\x104', '\xE1', 
		'\x3', '\x2', '\x2', '\x2', '\x104', '\xEC', '\x3', '\x2', '\x2', '\x2', 
		'\x104', '\xF6', '\x3', '\x2', '\x2', '\x2', '\x104', '\xFE', '\x3', '\x2', 
		'\x2', '\x2', '\x105', '\x34', '\x3', '\x2', '\x2', '\x2', '\x106', '\x108', 
		'\x5', ')', '\x15', '\x2', '\x107', '\x106', '\x3', '\x2', '\x2', '\x2', 
		'\x108', '\x109', '\x3', '\x2', '\x2', '\x2', '\x109', '\x107', '\x3', 
		'\x2', '\x2', '\x2', '\x109', '\x10A', '\x3', '\x2', '\x2', '\x2', '\x10A', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\x10B', '\x10F', '\t', '\a', '\x2', 
		'\x2', '\x10C', '\x10E', '\t', '\b', '\x2', '\x2', '\x10D', '\x10C', '\x3', 
		'\x2', '\x2', '\x2', '\x10E', '\x111', '\x3', '\x2', '\x2', '\x2', '\x10F', 
		'\x10D', '\x3', '\x2', '\x2', '\x2', '\x10F', '\x110', '\x3', '\x2', '\x2', 
		'\x2', '\x110', '\x38', '\x3', '\x2', '\x2', '\x2', '\x111', '\x10F', 
		'\x3', '\x2', '\x2', '\x2', '\x112', '\x114', '\t', '\t', '\x2', '\x2', 
		'\x113', '\x112', '\x3', '\x2', '\x2', '\x2', '\x114', '\x115', '\x3', 
		'\x2', '\x2', '\x2', '\x115', '\x113', '\x3', '\x2', '\x2', '\x2', '\x115', 
		'\x116', '\x3', '\x2', '\x2', '\x2', '\x116', '\x117', '\x3', '\x2', '\x2', 
		'\x2', '\x117', '\x118', '\b', '\x1D', '\x2', '\x2', '\x118', ':', '\x3', 
		'\x2', '\x2', '\x2', '\x119', '\x11A', '\a', '%', '\x2', '\x2', '\x11A', 
		'\x11E', '\a', '#', '\x2', '\x2', '\x11B', '\x11D', '\n', '\n', '\x2', 
		'\x2', '\x11C', '\x11B', '\x3', '\x2', '\x2', '\x2', '\x11D', '\x120', 
		'\x3', '\x2', '\x2', '\x2', '\x11E', '\x11C', '\x3', '\x2', '\x2', '\x2', 
		'\x11E', '\x11F', '\x3', '\x2', '\x2', '\x2', '\x11F', '\x121', '\x3', 
		'\x2', '\x2', '\x2', '\x120', '\x11E', '\x3', '\x2', '\x2', '\x2', '\x121', 
		'\x122', '\b', '\x1E', '\x3', '\x2', '\x122', '<', '\x3', '\x2', '\x2', 
		'\x2', '\x1F', '\x2', '\x82', '\x87', '\x8E', '\x95', '\x9B', '\x9F', 
		'\xA7', '\xAA', '\xB1', '\xB6', '\xBD', '\xC4', '\xCA', '\xCE', '\xD5', 
		'\xDB', '\xDF', '\xE5', '\xE8', '\xF0', '\xF3', '\xF8', '\x100', '\x104', 
		'\x109', '\x10F', '\x115', '\x11E', '\x4', '\b', '\x2', '\x2', '\x2', 
		'\x3', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
