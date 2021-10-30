Ã;
FC:\Users\chris\source\repos\dwmConanLauncher\LaunchGame\frmLauncher.cs
	namespace 	

LaunchGame
 
{ 
public		 

partial		 
class		 
frmLauncher		 $
:		% &
Form		' +
{

 
public 
frmLauncher 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
frmLauncher_Load %
(% &
object& ,
sender- 3
,3 4
	EventArgs5 >
e? @
)@ A
{ 	
txtPassword 
. 
Text 
= 
GetPasswordFromFile 2
(2 3
)3 4
;4 5
if 
( 
txtPassword 
. 
Text  
!=! #
$str$ &
)& '
{ 
chkSavePassword 
.  
Checked  '
=( )
true* .
;. /
} 
txtUrlToResolve 
. 
Text  
=! "
$str# 8
;8 9
	ResolveIp 
( 
) 
; 
} 	
private 
void 
	ResolveIp 
( 
)  
{ 	
try 
{   
	IPAddress!! 
[!! 
]!! 
	addresses!! !
=!!" #
Dns!!$ '
.!!' (
GetHostAddresses!!( 8
(!!8 9
txtUrlToResolve!!9 H
.!!H I
Text!!I M
)!!M N
;!!N O
lblResolvedIp"" 
."" 
Text"" 
=""  
	addresses""! *
[""* +
$num""+ ,
]"", -
.""- .
ToString"". 6
(""6 7
)""7 8
;""8 9
}## 
catch$$ 
($$ 
	Exception$$ 
ex$$ 
)$$  
{%% 
if&& 
(&& 
ex&& 
.&& 
Message&& 
==&&  
$str&&! 8
)&&8 9
{'' 

lblMessage(( 
.(( 
Text(( #
=(($ %
$str((& B
;((B C
})) 
else** 
throw** 
;** 
}++ 
}-- 	
private// 
void//  
btnLaunchConan_Click// )
(//) *
object//* 0
sender//1 7
,//7 8
	EventArgs//9 B
e//C D
)//D E
{00 	
var11 
launchString11 
=11 
$str11 E
+11F G
lblResolvedIp11H U
.11U V
Text11V Z
+11[ \
$str11] o
+11p q
txtPassword11r }
.11} ~
Text	11~ ‚
;
11‚ ƒ
Process22 
.22 
Start22 
(22 
launchString22 &
)22& '
;22' (
}33 	
private44 
string44 
GetPasswordFromFile44 *
(44* +
)44+ ,
{55 	
string66 
password66 
=66 
$str66  
;66  !
if77 
(77 
File77 
.77 
Exists77 
(77 
$str77 (
)77( )
)77) *
{88 
StreamReader:: 
passwordReader:: +
=::, -
new::. 1
StreamReader::2 >
(::> ?
$str::? K
)::K L
;::L M
password;; 
=;; 
passwordReader;; )
.;;) *
ReadLine;;* 2
(;;2 3
);;3 4
;;;4 5
passwordReader<< 
.<< 
Close<< $
(<<$ %
)<<% &
;<<& '
}>> 
return?? 
password?? 
;?? 
}@@ 	
privateAA 
voidAA 
StorePasswordAA "
(AA" #
stringAA# )
passwordAA* 2
)AA2 3
{BB 	
SystemCC 
.CC 
IOCC 
.CC 
FileCC 
.CC 
WriteAllTextCC '
(CC' (
$strCC( 4
,CC4 5
stringCC6 <
.CC< =
EmptyCC= B
)CCB C
;CCC D
StreamWriterDD 
passwordWriterDD '
=DD( )
newDD* -
StreamWriterDD. :
(DD: ;
$strDD; G
)DDG H
;DDH I
passwordWriterEE 
.EE 
	WriteLineEE $
(EE$ %
passwordEE% -
)EE- .
;EE. /
passwordWriterFF 
.FF 
CloseFF  
(FF  !
)FF! "
;FF" #
}GG 	
privateII 
voidII *
chkSavePassword_CheckedChangedII 3
(II3 4
objectII4 :
senderII; A
,IIA B
	EventArgsIIC L
eIIM N
)IIN O
{JJ 	
ifKK 
(KK 
chkSavePasswordKK 
.KK  
CheckedKK  '
&&KK( *
txtPasswordKK+ 6
.KK6 7
TextKK7 ;
!=KK< >
$strKK? A
)KKA B
{LL 
ifMM 
(MM 
GetPasswordFromFileMM '
(MM' (
)MM( )
==MM* ,
$strMM- /
)MM/ 0
{NN 
StorePasswordOO !
(OO! "
txtPasswordOO" -
.OO- .
TextOO. 2
)OO2 3
;OO3 4
}PP 
elseQQ 
ifQQ 
(QQ 
GetPasswordFromFileQQ ,
(QQ, -
)QQ- .
!=QQ/ 1
txtPasswordQQ2 =
.QQ= >
TextQQ> B
)QQB C
{RR 
varSS 
resultSS 
=SS  

MessageBoxSS! +
.SS+ ,
ShowSS, 0
(SS0 1
$strSS1 I
,SSI J
$strSSK c
,SSc d
MessageBoxButtonsSSe v
.SSv w
YesNoSSw |
)SS| }
;SS} ~
ifTT 
(TT 
resultTT 
==TT !
SystemTT" (
.TT( )
WindowsTT) 0
.TT0 1
FormsTT1 6
.TT6 7
DialogResultTT7 C
.TTC D
YesTTD G
)TTG H
{UU 
StorePasswordVV %
(VV% &
txtPasswordVV& 1
.VV1 2
TextVV2 6
)VV6 7
;VV7 8
}WW 
}XX 
}[[ 
}\\ 	
private^^ 
void^^ #
txtPassword_TextChanged^^ ,
(^^, -
object^^- 3
sender^^4 :
,^^: ;
	EventArgs^^< E
e^^F G
)^^G H
{__ 	
chkSavePassword`` 
.`` 
Checked`` #
=``$ %
false``& +
;``+ ,
}aa 	
privatecc 
voidcc 
btnRefresh_Click_1cc '
(cc' (
objectcc( .
sendercc/ 5
,cc5 6
	EventArgscc7 @
eccA B
)ccB C
{dd 	

lblMessageee 
.ee 
Textee 
=ee 
$stree  
;ee  !
	ResolveIpff 
(ff 
)ff 
;ff 
}gg 	
privateii 
voidii 
btnCopy_Clickii "
(ii" #
objectii# )
senderii* 0
,ii0 1
	EventArgsii2 ;
eii< =
)ii= >
{jj 	
	Clipboardkk 
.kk 
SetTextkk 
(kk 
lblResolvedIpkk +
.kk+ ,
Textkk, 0
+kk1 2
$strkk3 :
)kk: ;
;kk; <
}ll 	
}mm 
}nn È
BC:\Users\chris\source\repos\dwmConanLauncher\LaunchGame\Program.cs
	namespace 	

LaunchGame
 
{ 
static 

class 
Program 
{ 
[ 	
	STAThread	 
] 
static 
void 
Main 
( 
) 
{ 	
Application 
. 
EnableVisualStyles *
(* +
)+ ,
;, -
Application 
. -
!SetCompatibleTextRenderingDefault 9
(9 :
false: ?
)? @
;@ A
Application 
. 
Run 
( 
new 
frmLauncher  +
(+ ,
), -
)- .
;. /
} 	
} 
} ý
RC:\Users\chris\source\repos\dwmConanLauncher\LaunchGame\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str %
)% &
]& '
[ 
assembly 	
:	 

AssemblyDescription 
( 
$str !
)! "
]" #
[		 
assembly		 	
:			 
!
AssemblyConfiguration		  
(		  !
$str		! #
)		# $
]		$ %
[

 
assembly

 	
:

	 

AssemblyCompany

 
(

 
$str

 
)

 
]

 
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str '
)' (
]( )
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
["" 
assembly"" 	
:""	 

AssemblyVersion"" 
("" 
$str"" $
)""$ %
]""% &
[## 
assembly## 	
:##	 

AssemblyFileVersion## 
(## 
$str## (
)##( )
]##) *