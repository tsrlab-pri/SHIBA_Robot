	#Command Enums
	class Cmd():
		M1FORWARD = 0
		M1BACKWARD = 1
		SETMINMB = 2
		SETMAXMB = 3
		M2FORWARD = 4
		M2BACKWARD = 5
		M17BIT = 6
		M27BIT = 7
		MIXEDFORWARD = 8
		MIXEDBACKWARD = 9
		MIXEDRIGHT = 10
		MIXEDLEFT = 11
		MIXEDFB = 12
		MIXEDLR = 13
		GETM1ENC = 16
		GETM2ENC = 17
		GETM1SPEED = 18
		GETM2SPEED = 19
		RESETENC = 20
		GETVERSION = 21
		SETM1ENCCOUNT = 22
		SETM2ENCCOUNT = 23
		GETMBATT = 24
		GETLBATT = 25
		SETMINLB = 26
		SETMAXLB = 27
		SETM1PID = 28
		SETM2PID = 29
		GETM1ISPEED = 30
		GETM2ISPEED = 31
		M1DUTY = 32
		M2DUTY = 33
		MIXEDDUTY = 34
		M1SPEED = 35
		M2SPEED = 36
		MIXEDSPEED = 37
		M1SPEEDACCEL = 38
		M2SPEEDACCEL = 39
		MIXEDSPEEDACCEL = 40
		M1SPEEDDIST = 41
		M2SPEEDDIST = 42
		MIXEDSPEEDDIST = 43
		M1SPEEDACCELDIST = 44
		M2SPEEDACCELDIST = 45
		MIXEDSPEEDACCELDIST = 46
		GETBUFFERS = 47
		GETPWMS = 48
		GETCURRENTS = 49
		MIXEDSPEED2ACCEL = 50
		MIXEDSPEED2ACCELDIST = 51
		M1DUTYACCEL = 52
		M2DUTYACCEL = 53
		MIXEDDUTYACCEL = 54
		READM1PID = 55
		READM2PID = 56
		SETMAINVOLTAGES = 57
		SETLOGICVOLTAGES = 58
		GETMINMAXMAINVOLTAGES = 59
		GETMINMAXLOGICVOLTAGES = 60
		SETM1POSPID = 61
		SETM2POSPID = 62
		READM1POSPID = 63
		READM2POSPID = 64
		M1SPEEDACCELDECCELPOS = 65
		M2SPEEDACCELDECCELPOS = 66
		MIXEDSPEEDACCELDECCELPOS = 67
		SETM1DEFAULTACCEL = 68
		SETM2DEFAULTACCEL = 69
		SETPINFUNCTIONS = 74
		GETPINFUNCTIONS = 75
		SETDEADBAND = 76
		GETDEADBAND = 77
		RESTOREDEFAULTS = 80
		GETTEMP = 82
		GETTEMP2 = 83
		GETERROR = 90
		GETENCODERMODE = 91
		SETM1ENCODERMODE = 92
		SETM2ENCODERMODE = 93
		WRITENVM = 94
		READNVM = 95
		SETCONFIG = 98
		GETCONFIG = 99
		SETM1MAXCURRENT = 133
		SETM2MAXCURRENT = 134
		GETM1MAXCURRENT = 135
		GETM2MAXCURRENT = 136
		SETPWMMODE = 148
		GETPWMMODE = 149
		FLAGBOOTLOADER = 255			
	#User accessible functions
	def SendRandomData(self,cnt):

	def ForwardM1(self,address,val):
	・モータ1を前方に駆動する。 有効なデータ範囲は0〜127です。

	def BackwardM1(self,address,val):
	・モータ1を後方に駆動する。 有効なデータ範囲は0〜127です。
	
	def SetMinVoltageMainBattery(self,address,val):
	・メインバッテリー（B- / B +）の最小電圧レベルを設定します。 
	・バッテリ電圧がセットより下に下がると電圧レベルのRoboClawはモータの駆動を停止します。 
	・電圧は0.2ボルト単位で設定されます。 
	・A0の値は6Vの許容最小値を設定します。 有効なデータ範囲は0〜140（6V〜34V） 
	・電圧を計算する式は次のとおりです。（設定電圧 - 6）x 5 =値　有効な値は、6V = 0,8V = 10,11V = 25です。

	def SetMaxVoltageMainBattery(self,address,val):
	・メインバッテリー（B- / B +）の最大電圧レベルを設定します。 有効なデータ範囲は30〜175（6V〜34V） 
	・回生遮断中、バッテリを充電するために逆電圧が印加される。 
	・使用時電源を最大電圧レベルに設定することで、RoboClawはそれを超える前に、
	・電圧が設定された最大値を下回るまでハードブレーキングモードにします。
	・電圧を計算する式は次のとおりです。設定電圧x 5.12 =値 
	・有効な値の例は、12V = 62,16V = 82,24V = 123です。

	def ForwardM2(self,address,val):
	・モータ2を前方に駆動する。 有効なデータ範囲は0〜127です。

	def BackwardM2(self,address,val):
	・モータ2を後方に駆動する。 有効なデータ範囲は0〜127です。

	def ForwardBackwardM1(self,address,val):
	・モータ1を正転または逆転させます。 有効なデータ範囲は0〜127です。

	def ForwardBackwardM2(self,address,val):
	・モータ2を正転または逆転させます。 有効なデータ範囲は0〜127です。

	def ForwardMixed(self,address,val):
	・ミックスモードで前進させます。有効なデータ範囲は0〜127です。

	def BackwardMixed(self,address,val):
	・ミックスモードで後進させます。有効なデータ範囲は0〜127です。

	def TurnRightMixed(self,address,val):
	・ミックスモードで右旋回させます。有効なデータ範囲は0〜127です。
	def TurnLeftMixed(self,address,val):
	・ミックスモードで左旋回させます。有効なデータ範囲は0〜127です。
	def ForwardBackwardMixed(self,address,val):
	・ミックスモードで前進または更新させます。有効なデータ範囲は0〜127です。

	def LeftRightMixed(self,address,val):
	・ミックスモードで左旋回または右旋回させます。有効なデータ範囲は0〜127です。

	def ReadEncM1(self,address):
	・モータ1のエンコーダを読みます。

	def ReadEncM2(self,address):
	・モータ2のエンコーダを読みます。

	def ReadSpeedM1(self,address):
	・モータ1の速度を読みます。

	def ReadSpeedM2(self,address):
	・モータ2の速度を読みます。

	def ResetEncoders(self,address):
	・エンコーダをゼロリセットさせます。

	def ReadVersion(self,address):
	・モータドライバのファームウェアのバージョンを読みます。

	def SetEncM1(self,address,cnt):
	・	
	def SetEncM2(self,address,cnt):

	def ReadMainBatteryVoltage(self,address):
	・メインバッテリの電圧レベルを読みます。電圧は1/10の値

	def ReadLogicBatteryVoltage(self,address,):
	・ロジックバッテリの電圧レベルを読みます。電圧は1/10の値

	def SetMinVoltageLogicBattery(self,address,val):
	・ロジック入力（LB- / LB +）の最小電圧レベルを設定します。
	・RoboClawは設定した電圧より低い場合にでシャットダウンします。
	・電圧は0.2ボルト単位で設定されます。 許容される最小値は6Vです。 有効なデータ範囲は0〜140（6V〜34V）です。 
	・電圧の計算は、（設定電圧 - 6）×5 =値です。 

	def SetMaxVoltageLogicBattery(self,address,val):
	・ロジック入力（LB- / LB +）の最大電圧レベルを設定します。 有効なデータ範囲は30〜175（6V〜34V）
	・電圧がこのレベルを超えると、RoboClawはエラーで停止します。
	・電圧を計算は、設定電圧x 5.12 =値である。

	def SetM1VelocityPID(self,address,p,i,d,qpps):
	・モータ1の速度制御時のPID定数を設定
	
	def SetM2VelocityPID(self,address,p,i,d,qpps):
	・モータ2の速度制御時のPID定数を設定

	def ReadISpeedM1(self,address):
	・最後の300分の1秒でカウントされたパルスを読み取ります。 
	・返される値はエンコーダの1秒あたりのカウント数。

	def ReadISpeedM2(self,address):
	・最後の300分の1秒でカウントされたパルスを読み取ります。 
	・返される値はエンコーダの1秒あたりのカウント数。
	
	def DutyM1(self,address,val):
	・DutyCycleを使用してモータ1を制御します。

	def DutyM2(self,address,val):
	・DutyCycleを使用してモータ2を制御します。

	def DutyM1M2(self,address,m1,m2):
	・DutyCycleを使用してモータを制御します。

	def SpeedM1(self,address,val):
	・速度指令によって　モータ１を制御する。記号はモータの回転方向を示している。
	・エンコーダ値を使用して制御している。

	def SpeedM2(self,address,val):
	・速度指令によって　モータ2を制御する。記号はモータの回転方向を示している。
	・エンコーダ値を使用して制御している。
	
	def SpeedM1M2(self,address,m1,m2):
	・速度指令によって　モータを制御する。記号はモータの回転方向を示している。
	・エンコーダ値を使用して制御している。
	
	def SpeedAccelM1(self,address,accel,speed):
	・速度値と加速度指令によってモータ1を制御する。記号はモータの回転方向を示している。
	・エンコーダ値を使用して制御している。

	def SpeedAccelM2(self,address,accel,speed):
	・速度値と加速度指令によってモータ2を制御する。記号はモータの回転方向を示している。
	・エンコーダ値を使用して制御している。

	def SpeedAccelM1M2(self,address,accel,speed1,speed2):
	・速度値と加速度指令によってモータを制御する。記号はモータの回転方向を示している。
	・エンコーダ値を使用して制御している。

	def SpeedDistanceM1(self,address,speed,distance,buffer):
	・モータ1が移動する最高速度と距離を指定して制御することが出来る。記号はモータの回転方向を示している。
	
	def SpeedDistanceM2(self,address,speed,distance,buffer):
	・モータ2が移動する最高速度と距離を指定して制御することが出来る。記号はモータの回転方向を示している。

	def SpeedDistanceM1M2(self,address,speed1,distance1,speed2,distance2,buffer):
	・モータが移動する最高速度と距離を指定して制御することが出来る。記号はモータの回転方向を示している。

	def SpeedAccelDistanceM1(self,address,accel,speed,distance,buffer):
	・モータ1が移動する最高速度と加速度、距離を指定して制御することが出来る。記号はモータの回転方向を示している。	
	
	def SpeedAccelDistanceM2(self,address,accel,speed,distance,buffer):
	・モータ2が移動する最高速度と距離を指定して制御することが出来る。記号はモータの回転方向を示している。
	
	def SpeedAccelDistanceM1M2(self,address,accel,speed1,distance1,speed2,distance2,buffer):
	・モータが移動する最高速度と総距離を指定して制御することが出来る。記号はモータの回転方向を示している。

	def ReadBuffers(self,address):
	・モーターM1とM2の両方のバッファー長を読み取ります。 このコマンドを使用すると、実行を待っています。
	
	def ReadPWMs(self,address):
	
	def ReadCurrents(self,address):
	
	def SpeedAccelM1M2_2(self,address,accel1,speed1,accel2,speed2):
	
	def SpeedAccelDistanceM1M2_2(self,address,accel1,speed1,distance1,accel2,speed2,distance2,buffer):

	def DutyAccelM1(self,address,accel,duty):

	def DutyAccelM2(self,address,accel,duty):

	def DutyAccelM1M2(self,address,accel1,duty1,accel2,duty2):
		
	def ReadM1VelocityPID(self,address):
	・モータの速度制御時のPID定数を読み込みます。

	def ReadM2VelocityPID(self,address):
	・モータ2の速度制御時のPID定数を読み込みます。


	def SetMainVoltages(self,address,min, max):
	・メインバッテリのカットオフ値をの最小値と最大値を設定します。
	・電圧は10をかけて設定します。

	def SetLogicVoltages(self,address,min, max):
	・ロジックバッテリのカットオフ値をの最小値と最大値を設定します。
	・電圧は10をかけて設定します。

	def ReadMinMaxMainVoltages(self,address):
	・メインバッテリの電圧を読み込みます。電圧は10で割った値になります。

	def ReadMinMaxLogicVoltages(self,address):
	・ロジックバッテリの電圧を読み込みます。電圧は10で割った値になります。

	def SetM1PositionPID(self,address,kp,ki,kd,kimax,deadzone,min,max):
	・モータ１の位置制御時のPID定数を設定します。
	
	def SetM2PositionPID(self,address,kp,ki,kd,kimax,deadzone,min,max):
	・モータ2の位置制御時のPID定数を読み込みます。

	def ReadM1PositionPID(self,address):
	・モータ１の位置制御時のPID定数を読み込みます。

	def ReadM2PositionPID(self,address):
	・モータ2の位置制御時のPID定数を読み込みます。

	def SpeedAccelDeccelPositionM1(self,address,accel,speed,deccel,position,buffer):
	・加減速及び速度、到達位置をモータ１のみ設定する。

	def SpeedAccelDeccelPositionM2(self,address,accel,speed,deccel,position,buffer):
	・加減速及び速度、到達位置をモータ2のみ設定する。

	def SpeedAccelDeccelPositionM1M2(self,address,accel1,speed1,deccel1,position1,accel2,speed2,deccel2,position2,buffer):
	・加減速及び速度、到達位置をモータ１、2共に設定する。

	def SetM1DefaultAccel(self,address,accel):
	・DutyCycle(Cmds 32,33,34）を使用する場合　もしくは　標準シリアル、RC、およびアナログPWMモードを使用する場合
	のモータ1のデフォルトの加速度を設定する

	def SetM2DefaultAccel(self,address,accel):
	・DutyCycle(Cmds 32,33,34）を使用する場合　もしくは　標準シリアル、RC、およびアナログPWMモードを使用する場合
	のモータ2のデフォルトの加速度を設定する

	def SetPinFunctions(self,address,S3mode,S4mode,S5mode):
	・S3,S4,S5のピンの設定をします。
	・詳細はBasicMicro UserReferance　Ｐ72を参照
	・モードの説明
	無効：ピンは非アクティブです。
	デフォルト：シリアルモードでRC /アナログモードまたはE-Stop（ラッチ）の場合はフリップスイッチ。
	E-Stop（Latching）：ユニットの電源が切られるまで、Roboclawをシャットダウンします。
	E-Stop：E-Stop信号がクリアされるまでシャットダウン中にRoboclawを保持します。
	電圧クランプ：信号ピンを出力として設定して、外部電圧クランプ回路を駆動します
	ホーム（モータ１、２）：特定のモーターを停止させ、エンコーダーのカウントを0にリセットします。
	
	def ReadPinFunctions(self,address):
	・S3,S4,S5ピンの設定を読み込みます。

	def SetDeadBand(self,address,min,max):
	・RC /アナログモードの不感帯を10％単位で制御します。 
	・デフォルト値は25（2.5％ )
	・最小値は0（デッドバンドなし）、最大値は250（25％）です。

	def GetDeadBand(self,address):
	・dead Bandの設定を1/10パーセントで読み込みます。

	def RestoreDefaults(self,address):
	・工場出荷時の状態に設定します。

	def ReadTemp(self,address):
	・モータ1側の温度の読み込みを行います。
	・返される値は1/10度になります。
	

	def ReadTemp2(self,address):
	・モータ2側の温度の読み込みを行います。
	・返される値は1/10度になります。

	def ReadError(self,address):
	・現在のエラーステータスの読み込み
	・詳細はBasicMicro UserReferance　Ｐ74を参照

	def ReadEncoderModes(self,address):
	・モータ1、モータ2のエンコーダモードを読み込みます。

	def SetM1EncoderMode(self,address,mode):
	・エンコーダモードをモータ1に設定します。
	・Encoder Modeの詳細内容を設定できます。
	Bit 7 Enable RC/Analog Encoder support
	Bit 6-1 N/A
	Bit 0 Quadrature(0)/Absolute(1)

	def SetM2EncoderMode(self,address,mode):
	・エンコーダモードをモータ2に設定します。
	・Encoder Modeの詳細内容を設定できます。

	def WriteNVM(self,address):
	・全ての設定をEEPROMに書き込みます。電源投入後に値が読み込まれます。

	def ReadNVM(self,address):
	・全ての設定をEEPROMから読み込みます。
	
	def SetConfig(self,address,config):
	・設定を書き換えます。
	・詳細はBasicMicro UserReferance　Ｐ76を参照

	def GetConfig(self,address):
	・現在の設定を読み込みます。

	def SetM1MaxCurrent(self,address,max):
	・モータ1の最大電流制限を設定可能
	・値は10mA単位　設定可能な最大値は100(10A)

	def SetM2MaxCurrent(self,address,max):
	・モータ2の最大電流制限を設定可能
	・値は10mA単位　設定可能な最大値は100(10A)
	
	def ReadM1MaxCurrent(self,address):
	・モータ1の最大電流制限を読める。
	・値は10mA単位

	def ReadM2MaxCurrent(self,address):
	・モータ2の最大電流制限を読める。
	・値は10mA単位

	def SetPWMMode(self,address,mode):
	・PWMモードを設定する。
	・Locked　AntiPhase方式(0)とSignMagnitude方式(1)を切り替えることが出来る

	def ReadPWMMode(self,address):
	・PWMモードの読み込み

	def Open(self):
	・シリアルオープン