S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 20509
Date: 2017-06-02 20:28:27+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 20509, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x0000501d
r2   = 0x00000006, r3   = 0xb404d4c0
r4   = 0x00000002, r5   = 0xb404d000
r6   = 0xb6a1b09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb6508708
r10  = 0x2a22ba40, fp   = 0x8009389f
ip   = 0x00000000, sp   = 0xbefff2bc
lr   = 0xb6911f18, pc   = 0xb6910b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     60820 KB
Buffers:     82708 KB
Cached:     276836 KB
VmPeak:     117016 KB
VmSize:     116392 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26264 KB
VmRSS:       26152 KB
VmData:      38308 KB
VmStk:         136 KB
VmExe:         192 KB
VmLib:       28492 KB
VmPTE:          90 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 20509 TID = 20509
20509 20521 20529 20532 

Maps Information
2a000000 2a030000 r-xp /opt/usr/apps/org.example.client/bin/client
2a040000 2a426000 rw-p [heap]
afc65000 b0464000 rw-p [stack:20532]
b2599000 b25a1000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b25b2000 b25bf000 r-xp /usr/lib/libmdm-common.so.1.0.98
b25d0000 b2611000 r-xp /usr/lib/libmdm.so.1.2.12
b2621000 b2629000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b2638000 b2648000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b2669000 b26c9000 r-xp /usr/lib/libasound.so.2.0.0
b26db000 b26de000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b26ee000 b26f1000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b2701000 b2706000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b2716000 b2721000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b2735000 b273a000 r-xp /usr/lib/libmmfsession.so.0.0.1
b274a000 b2765000 r-xp /usr/lib/libmmfsound.so.0.1.0
b2775000 b277c000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b278c000 b2796000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b27a6000 b27a8000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b27b8000 b27b9000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b27c9000 b27d1000 r-xp /usr/lib/libfeedback.so.0.1.4
b27f9000 b27fa000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b280a000 b281e000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b297a000 b297b000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b298b000 b298e000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b299f000 b29a0000 r-xp /usr/lib/libxshmfence.so.1.0.0
b29b0000 b29b2000 r-xp /usr/lib/libxcb-present.so.0.0.0
b29c2000 b29c4000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b29d4000 b29d5000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b29e7000 b29ed000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29fd000 b2a0d000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2a1d000 b2a29000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2a3b000 b323a000 rw-p [stack:20529]
b356b000 b3575000 r-xp /lib/libnss_files-2.20-2014.11.so
b3586000 b358f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b35a0000 b35b1000 r-xp /lib/libnsl-2.20-2014.11.so
b35c4000 b35ca000 r-xp /lib/libnss_compat-2.20-2014.11.so
b35db000 b35df000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35f0000 b36d3000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b370a000 b3732000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b3744000 b3f43000 rw-p [stack:20521]
b3f43000 b3f45000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3f55000 b4033000 r-xp /usr/lib/libCOREGL.so.4.0
b4052000 b4055000 r-xp /lib/libattr.so.1.1.0
b4066000 b406d000 r-xp /lib/libcrypt-2.20-2014.11.so
b40a5000 b40a8000 r-xp /lib/libcap.so.2.21
b40b8000 b40ba000 r-xp /usr/lib/libiri.so
b40ca000 b40ea000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b40ec000 b40ef000 r-xp /usr/lib/libuuid.so.1.3.0
b40ff000 b4116000 r-xp /usr/lib/libblkid.so.1.1.0
b4127000 b4150000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4161000 b41a8000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41b9000 b41bf000 r-xp /usr/lib/libjson-c.so.2.0.1
b41d1000 b41d5000 r-xp /usr/lib/libogg.so.0.7.1
b41e5000 b4207000 r-xp /usr/lib/libvorbis.so.0.4.3
b4217000 b42fb000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4317000 b4322000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4332000 b4335000 r-xp /usr/lib/libEGL.so.1.4
b4346000 b434c000 r-xp /usr/lib/libxcb-render.so.0.0.0
b435c000 b435e000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b436e000 b437b000 r-xp /usr/lib/libGLESv2.so.2.0
b438c000 b43a4000 r-xp /usr/lib/libmount.so.1.1.0
b43b6000 b43b8000 r-xp /usr/lib/libXau.so.6.0.0
b43c8000 b43fe000 r-xp /usr/lib/libpulse.so.0.16.2
b440f000 b4452000 r-xp /usr/lib/libsndfile.so.1.0.25
b4467000 b44e1000 r-xp /usr/lib/libgcrypt.so.20.0.3
b44f6000 b44fd000 r-xp /usr/lib/libsensord-share.so
b450e000 b4570000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4585000 b4588000 r-xp /usr/lib/libXv.so.1.0.0
b4598000 b459d000 r-xp /usr/lib/libutilX.so.1.1.0
b45ad000 b45b2000 r-xp /usr/lib/libffi.so.6.0.2
b45c2000 b45d3000 r-xp /lib/libresolv-2.20-2014.11.so
b45e8000 b45ea000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b45fa000 b460f000 r-xp /lib/libexpat.so.1.5.2
b4621000 b46df000 r-xp /usr/lib/libcairo.so.2.11200.14
b46f2000 b46fa000 r-xp /usr/lib/libdrm.so.2.4.0
b470b000 b470e000 r-xp /usr/lib/libdri2.so.0.0.0
b471e000 b476c000 r-xp /usr/lib/libssl.so.1.0.0
b4781000 b478d000 r-xp /usr/lib/libeeze.so.1.13.0
b479d000 b47a6000 r-xp /usr/lib/libethumb.so.1.13.0
b47b7000 b47ba000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b47ca000 b4981000 r-xp /usr/lib/libcrypto.so.1.0.0
b576b000 b5774000 r-xp /usr/lib/libXi.so.6.1.0
b5785000 b5787000 r-xp /usr/lib/libXgesture.so.7.0.0
b5797000 b579b000 r-xp /usr/lib/libXtst.so.6.1.0
b57ab000 b57b1000 r-xp /usr/lib/libXrender.so.1.3.0
b57c1000 b57c7000 r-xp /usr/lib/libXrandr.so.2.2.0
b57d7000 b57d9000 r-xp /usr/lib/libXinerama.so.1.0.0
b57e9000 b57ec000 r-xp /usr/lib/libXfixes.so.3.1.0
b57fd000 b5808000 r-xp /usr/lib/libXext.so.6.4.0
b5818000 b581a000 r-xp /usr/lib/libXdamage.so.1.1.0
b582a000 b582c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b583c000 b5843000 r-xp /usr/lib/libXcursor.so.1.0.2
b5853000 b586b000 r-xp /usr/lib/libudev.so.1.6.0
b586e000 b5882000 r-xp /usr/lib/libxcb.so.1.1.0
b5892000 b5894000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b58a4000 b58ab000 r-xp /usr/lib/libembryo.so.1.13.0
b58bb000 b58c5000 r-xp /usr/lib/libecore_audio.so.1.13.0
b58d6000 b58ee000 r-xp /lib/libz.so.1.2.8
b58ff000 b593b000 r-xp /usr/lib/libsystemd.so.0.4.0
b593d000 b5955000 r-xp /usr/lib/libsensor.so.1.1.0
b5966000 b596d000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b597d000 b5984000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b5996000 b5998000 r-xp /usr/lib/libappsvc.so.0.1.0
b59a8000 b59ab000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b59bb000 b59d4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b59e5000 b5a1c000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b5a2d000 b5b18000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b5b2b000 b5ba4000 r-xp /usr/lib/libsqlite3.so.0.8.6
b5bb6000 b5bc0000 r-xp /usr/lib/libvconf.so.0.2.45
b5bd0000 b5bd2000 r-xp /usr/lib/libvasum.so.0.3.1
b5be2000 b5be6000 r-xp /usr/lib/libsmack.so.1.0.0
b5bf6000 b5bfb000 r-xp /usr/lib/libxdgmime.so.1.1.0
b5c0c000 b5c36000 r-xp /usr/lib/libdbus-1.so.3.8.12
b5c47000 b5c5e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b5c6f000 b5c72000 r-xp /usr/lib/libbundle.so.0.1.22
b5c82000 b5c9a000 r-xp /usr/lib/libpng12.so.0.50.0
b5cab000 b5cce000 r-xp /usr/lib/libjpeg.so.8.0.2
b5cef000 b5d03000 r-xp /usr/lib/libector.so.1.13.0
b5d14000 b5d2c000 r-xp /usr/lib/liblua-5.1.so
b5d3d000 b5d94000 r-xp /usr/lib/libfreetype.so.6.11.3
b5da8000 b5dd0000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5de1000 b5df4000 r-xp /usr/lib/libfribidi.so.0.3.1
b5e05000 b5e3f000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5e50000 b5e5e000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e6e000 b5e76000 r-xp /usr/lib/libtbm.so.1.0.0
b5e86000 b5e93000 r-xp /usr/lib/libeio.so.1.13.0
b5ea3000 b5ea5000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5eb5000 b5eba000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5eca000 b5ee1000 r-xp /usr/lib/libefreet.so.1.13.0
b5ef3000 b5f13000 r-xp /usr/lib/libeldbus.so.1.13.0
b5f23000 b5f43000 r-xp /usr/lib/libecore_con.so.1.13.0
b5f45000 b5f4b000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f5b000 b5f6c000 r-xp /usr/lib/libemotion.so.1.13.0
b5f7d000 b5f84000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f94000 b5fa6000 r-xp /usr/lib/libecore_input.so.1.13.0
b5fb7000 b5fbc000 r-xp /usr/lib/libecore_file.so.1.13.0
b5fcc000 b5fe5000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ff5000 b6012000 r-xp /usr/lib/libeet.so.1.13.0
b602b000 b603b000 r-xp /usr/lib/libefl.so.1.13.0
b604c000 b6131000 r-xp /usr/lib/libicuuc.so.51.1
b614e000 b628e000 r-xp /usr/lib/libicui18n.so.51.1
b62a5000 b62dd000 r-xp /usr/lib/libecore_x.so.1.13.0
b62ef000 b62f1000 r-xp /usr/lib/libttrace.so.1.1
b6301000 b63e3000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b63f4000 b64d6000 r-xp /usr/lib/libX11.so.6.3.0
b64e9000 b64f8000 r-xp /usr/lib/libeo.so.1.13.0
b6509000 b658c000 r-xp /usr/lib/libedje.so.1.13.0
b659f000 b65bd000 r-xp /usr/lib/libecore.so.1.13.0
b65dd000 b66b2000 r-xp /usr/lib/libxml2.so.2.9.2
b66c7000 b66ca000 r-xp /usr/lib/libiniparser.so.0
b66da000 b6722000 r-xp /usr/lib/libeina.so.1.13.0
b6733000 b6738000 r-xp /usr/lib/libappcore-common.so.1.1
b6748000 b674d000 r-xp /usr/lib/libappcore-efl.so.1.1
b675d000 b6762000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6773000 b6799000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b67a9000 b67c1000 r-xp /usr/lib/libaul.so.0.1.0
b67d3000 b683e000 r-xp /lib/libm-2.20-2014.11.so
b684f000 b6855000 r-xp /lib/librt-2.20-2014.11.so
b6866000 b6868000 r-xp /lib/libdl-2.20-2014.11.so
b6879000 b6886000 r-xp /usr/lib/libunwind.so.8.0.1
b68bc000 b68d5000 r-xp /lib/libgcc_s-4.9.so.1
b68e5000 b6a09000 r-xp /lib/libc-2.20-2014.11.so
b6a1e000 b6ab9000 r-xp /usr/lib/libstdc++.so.6.0.20
b6ad5000 b6c5c000 r-xp /usr/lib/libevas.so.1.13.0
b6c91000 b6ec5000 r-xp /usr/lib/libelementary.so.1.13.0
b6ef4000 b6efb000 r-xp /usr/lib/libefl-extension.so.0.1.0
b6f0c000 b6f0e000 r-xp /usr/lib/libdlog.so.0.0.0
b6f1e000 b6f23000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6f33000 b6f37000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6f48000 b6f4a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b6f5b000 b6f6f000 r-xp /lib/libpthread-2.20-2014.11.so
b6f9b000 b6fa8000 r-xp /usr/lib/liblptcp.so
b6fba000 b6fbe000 r-xp /usr/lib/libsys-assert.so
b6fcf000 b6fef000 r-xp /lib/ld-2.20-2014.11.so
befdf000 bf000000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20509)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6910b84) [/lib/libc.so.6] + 0x2bb84
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
04+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-02 20:24:56.804+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:24:56.804+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:24:56.804+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-02 20:24:56.804+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-02 20:24:56.844+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-02 20:24:56.884+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:24:56.884+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-02 20:24:56.884+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:24:56.884+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-02 20:24:56.894+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-02 20:24:56.914+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
06-02 20:24:56.914+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
06-02 20:24:56.914+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:24:56.924+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:24:56.934+0900 E/weather-common( 1310): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
06-02 20:24:56.944+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-02 20:24:56.944+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 20:24:56.954+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_create(409) > New handle created[0xb8201008]
06-02 20:24:56.954+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_get_type(463) > Connected Network = 2
06-02 20:24:56.954+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_destroy(427) > Destroy handle: 0xb8201008
06-02 20:24:56.954+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-02 20:24:56.954+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 20:24:56.954+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 20:24:56.954+0900 E/weather-common( 1310): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
06-02 20:24:56.964+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
06-02 20:24:56.964+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-02 20:24:56.964+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-02 20:24:56.964+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: fg
06-02 20:25:00.548+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-02 20:25:00.548+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 8:25
06-02 20:25:00.548+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 8:25"
06-02 20:25:00.548+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 8:25"
06-02 20:25:00.558+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-02 20:25:00.558+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145706480 Time: <font_size=31> </font_size> <font_size=31> 오후 8:25</font_size></font>"
06-02 20:25:16.103+0900 E/PKGMGR_SERVER(20015): pkgmgr-server.c: main(2414) > package manager server start
06-02 20:25:16.153+0900 E/PKGMGR  (20013): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
06-02 20:25:16.193+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 14
06-02 20:25:16.193+0900 E/AUL_AMD (  612): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 19902
06-02 20:25:16.203+0900 W/AUL_AMD (  612): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-02 20:25:16.213+0900 E/PKGMGR_SERVER(20015): pkgmgr-server.c: sighandler(417) > child NORMAL exit [20018]
06-02 20:25:18.635+0900 W/AUL     (20070): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-02 20:25:18.635+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
06-02 20:25:18.645+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-02 20:25:18.655+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-02 20:25:18.655+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-02 20:25:18.655+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 20070
06-02 20:25:18.655+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-02 20:25:18.665+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
06-02 20:25:18.665+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-02 20:25:18.665+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-4)
06-02 20:25:18.785+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 20072, appid: org.example.client
06-02 20:25:18.785+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-02 20:25:18.785+0900 W/AUL     (20070): launch.c: app_request_to_launchpad(425) > request cmd(0) result(20072)
06-02 20:25:18.835+0900 E/PKGMGR_SERVER(20015): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-02 20:25:18.835+0900 E/PKGMGR_SERVER(20015): pkgmgr-server.c: main(2471) > package manager server terminated.
06-02 20:25:19.786+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:25:19.786+0900 W/AUL_AMD (  612): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-02 20:25:23.800+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(20072)
06-02 20:25:23.800+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 20072, appid: org.example.client, status: bg
06-02 20:25:37.253+0900 E/PKGMGR_SERVER(20128): pkgmgr-server.c: main(2414) > package manager server start
06-02 20:25:37.303+0900 E/PKGMGR  (20126): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
06-02 20:25:37.343+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 14
06-02 20:25:37.343+0900 E/AUL_AMD (  612): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 20072
06-02 20:25:37.353+0900 W/AUL_AMD (  612): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-02 20:25:37.363+0900 E/PKGMGR_SERVER(20128): pkgmgr-server.c: sighandler(417) > child NORMAL exit [20131]
06-02 20:25:39.766+0900 W/AUL     (20183): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-02 20:25:39.766+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
06-02 20:25:39.776+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-02 20:25:39.786+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-02 20:25:39.786+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-02 20:25:39.786+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 20183
06-02 20:25:39.786+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-02 20:25:39.786+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
06-02 20:25:39.796+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-02 20:25:39.796+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-4)
06-02 20:25:39.836+0900 E/PKGMGR_SERVER(20128): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-02 20:25:39.836+0900 E/PKGMGR_SERVER(20128): pkgmgr-server.c: main(2471) > package manager server terminated.
06-02 20:25:39.906+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 20185, appid: org.example.client
06-02 20:25:39.906+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-02 20:25:39.926+0900 W/AUL     (20183): launch.c: app_request_to_launchpad(425) > request cmd(0) result(20185)
06-02 20:25:40.917+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:25:40.917+0900 W/AUL_AMD (  612): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-02 20:25:44.921+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(20185)
06-02 20:25:44.921+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 20185, appid: org.example.client, status: bg
06-02 20:25:45.942+0900 I/abc     (20185): abc
06-02 20:25:45.952+0900 I/CAPI_APPFW_APPLICATION(20185): app_main.c: ui_app_main(789) > app_efl_main
06-02 20:25:47.143+0900 I/CAPI_APPFW_APPLICATION(20185): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-02 20:25:49.455+0900 E/TBM     (20185): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-02 20:25:50.616+0900 I/APP_CORE(20185): appcore-efl.c: __do_app(514) > [APP 20185] Event: RESET State: CREATED
06-02 20:25:50.616+0900 I/CAPI_APPFW_APPLICATION(20185): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-02 20:25:50.646+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:25:50.646+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:25:50.666+0900 W/APP_CORE(20185): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5c00002
06-02 20:25:50.666+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-02 20:25:50.676+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
06-02 20:25:50.676+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:25:50.686+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:25:50.696+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 20:25:50.947+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-02 20:25:50.947+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-02 20:25:50.947+0900 I/APP_CORE(20185): appcore-efl.c: __do_app(514) > [APP 20185] Event: RESUME State: CREATED
06-02 20:25:50.947+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-02 20:25:50.947+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-02 20:25:50.947+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-02 20:25:50.947+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-02 20:25:50.957+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(20185) status(3)
06-02 20:25:50.957+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:25:50.957+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:25:50.957+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(20185)
06-02 20:25:50.957+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 20185, appid: org.example.client, status: fg
06-02 20:25:50.967+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-02 20:25:50.967+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-02 20:25:50.967+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-02 20:25:50.977+0900 I/APP_CORE(20185): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-02 20:25:50.977+0900 I/APP_CORE(20185): appcore-efl.c: __do_app(625) > [APP 20185] Initial Launching, call the resume_cb
06-02 20:25:50.977+0900 I/CAPI_APPFW_APPLICATION(20185): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:25:51.307+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(20185) status(0)
06-02 20:25:54.991+0900 I/MY_LOG  (20185): Button pressed
06-02 20:25:55.081+0900 E/VCONF   (20185): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-02 20:25:55.081+0900 E/VCONF   (20185): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-02 20:25:55.081+0900 E/VCONF   (20185): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-02 20:25:55.081+0900 E/VCONF   (20185): vconf.c: vconf_get_bool(2729) > vconf_get_bool(20185) : db/ise/keysound error
06-02 20:25:55.081+0900 E/VCONF   (20185): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-02 20:25:55.081+0900 E/VCONF   (20185): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-02 20:25:55.141+0900 I/MY_LOG  (20185): Button unpressed
06-02 20:25:55.962+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-02 20:25:56.142+0900 I/MY_LOG  (20185): Button pressed
06-02 20:25:56.222+0900 I/MY_LOG  (20185): Button unpressed
06-02 20:25:56.262+0900 D/basicui (20185): successed to load edc file
06-02 20:26:00.556+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-02 20:26:00.556+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 8:26
06-02 20:26:00.556+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 8:26"
06-02 20:26:00.556+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 8:26"
06-02 20:26:00.556+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-02 20:26:00.556+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145694179 Time: <font_size=31> </font_size> <font_size=31> 오후 8:26</font_size></font>"
06-02 20:26:10.766+0900 W/CRASH_MANAGER(20212): worker.c: worker_job(1199) > 0620185636c691496402770
06-02 20:26:12.448+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:26:12.468+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-02 20:26:12.468+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:26:12.468+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:26:12.468+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-02 20:26:12.468+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-02 20:26:12.488+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-02 20:26:12.518+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-02 20:26:12.518+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:26:12.518+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:26:12.518+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-02 20:26:12.538+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
06-02 20:26:12.538+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:26:12.548+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:26:12.548+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-02 20:26:12.568+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
06-02 20:26:12.588+0900 E/weather-common( 1310): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
06-02 20:26:12.598+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-02 20:26:12.598+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 20:26:12.598+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-02 20:26:12.598+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 20:26:12.598+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 20:26:12.608+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_create(409) > New handle created[0xb81fb0e8]
06-02 20:26:12.608+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_get_type(463) > Connected Network = 2
06-02 20:26:12.608+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_destroy(427) > Destroy handle: 0xb81fb0e8
06-02 20:26:12.628+0900 E/weather-common( 1310): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
06-02 20:26:12.638+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
06-02 20:26:12.638+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-02 20:26:12.638+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-02 20:26:12.638+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: fg
06-02 20:26:33.799+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:26:48.133+0900 E/PKGMGR_SERVER(20291): pkgmgr-server.c: main(2414) > package manager server start
06-02 20:26:48.183+0900 E/PKGMGR  (20289): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
06-02 20:26:48.213+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 14
06-02 20:26:48.213+0900 E/AUL_AMD (  612): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 20185
06-02 20:26:48.223+0900 W/AUL_AMD (  612): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-02 20:26:48.233+0900 E/PKGMGR_SERVER(20291): pkgmgr-server.c: sighandler(417) > child NORMAL exit [20294]
06-02 20:26:50.495+0900 W/AUL     (20343): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-02 20:26:50.495+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
06-02 20:26:50.495+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-02 20:26:50.505+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-02 20:26:50.505+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-02 20:26:50.505+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 20343
06-02 20:26:50.505+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-02 20:26:50.515+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
06-02 20:26:50.515+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-02 20:26:50.515+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
06-02 20:26:50.525+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-02 20:26:50.525+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
06-02 20:26:50.535+0900 I/abc     (19718): abc
06-02 20:26:50.535+0900 I/CAPI_APPFW_APPLICATION(19718): app_main.c: ui_app_main(789) > app_efl_main
06-02 20:26:50.535+0900 I/CAPI_APPFW_APPLICATION(19718): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-02 20:26:50.565+0900 E/TBM     (19718): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-02 20:26:50.625+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 19718, appid: org.example.client
06-02 20:26:50.625+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-02 20:26:50.635+0900 W/AUL     (20343): launch.c: app_request_to_launchpad(425) > request cmd(0) result(19718)
06-02 20:26:50.825+0900 I/APP_CORE(19718): appcore-efl.c: __do_app(514) > [APP 19718] Event: RESET State: CREATED
06-02 20:26:50.825+0900 I/CAPI_APPFW_APPLICATION(19718): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-02 20:26:50.835+0900 E/PKGMGR_SERVER(20291): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-02 20:26:50.835+0900 E/PKGMGR_SERVER(20291): pkgmgr-server.c: main(2471) > package manager server terminated.
06-02 20:26:50.835+0900 E/EFL     (19718): edje<19718> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 20:26:50.835+0900 E/EFL     (19718): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:26:50.855+0900 E/EFL     (19718): edje<19718> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 20:26:50.855+0900 E/EFL     (19718): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:26:50.855+0900 E/EFL     (19718): edje<19718> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 20:26:50.855+0900 E/EFL     (19718): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:26:50.865+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:26:50.865+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:26:50.885+0900 W/APP_CORE(19718): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
06-02 20:26:50.885+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-02 20:26:50.895+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 20:26:50.905+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
06-02 20:26:50.905+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:26:50.915+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:26:51.005+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-02 20:26:51.005+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-02 20:26:51.005+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-02 20:26:51.005+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-02 20:26:51.005+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-02 20:26:51.005+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-02 20:26:51.005+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(19718) status(3)
06-02 20:26:51.015+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:26:51.015+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:26:51.015+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(19718)
06-02 20:26:51.015+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 19718, appid: org.example.client, status: fg
06-02 20:26:51.015+0900 I/APP_CORE(19718): appcore-efl.c: __do_app(514) > [APP 19718] Event: RESUME State: CREATED
06-02 20:26:51.025+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-02 20:26:51.025+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-02 20:26:51.025+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-02 20:26:51.025+0900 I/APP_CORE(19718): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-02 20:26:51.025+0900 I/APP_CORE(19718): appcore-efl.c: __do_app(625) > [APP 19718] Initial Launching, call the resume_cb
06-02 20:26:51.025+0900 I/CAPI_APPFW_APPLICATION(19718): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:26:51.366+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(19718) status(0)
06-02 20:26:51.666+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
06-02 20:26:51.666+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 19718.
06-02 20:26:51.666+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2566
06-02 20:26:52.457+0900 I/UXT     (20358): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-02 20:26:56.020+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-02 20:27:00.565+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-02 20:27:00.565+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 8:27
06-02 20:27:00.565+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 8:27"
06-02 20:27:00.565+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 8:27"
06-02 20:27:00.565+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-02 20:27:00.565+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145665954 Time: <font_size=31> </font_size> <font_size=31> 오후 8:27</font_size></font>"
06-02 20:27:12.566+0900 E/EFL     (19718): ecore_x<19718> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=951429736
06-02 20:27:12.576+0900 I/MY_LOG  (19718): Button pressed
06-02 20:27:12.646+0900 E/EFL     (19718): ecore_x<19718> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=951429813
06-02 20:27:12.656+0900 E/VCONF   (19718): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-02 20:27:12.656+0900 E/VCONF   (19718): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-02 20:27:12.656+0900 E/VCONF   (19718): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-02 20:27:12.656+0900 E/VCONF   (19718): vconf.c: vconf_get_bool(2729) > vconf_get_bool(19718) : db/ise/keysound error
06-02 20:27:12.656+0900 E/VCONF   (19718): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-02 20:27:12.656+0900 E/VCONF   (19718): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-02 20:27:12.707+0900 I/MY_LOG  (19718): Button unpressed
06-02 20:27:13.477+0900 E/EFL     (19718): ecore_x<19718> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=951430647
06-02 20:27:13.487+0900 I/MY_LOG  (19718): Button pressed
06-02 20:27:13.557+0900 E/EFL     (19718): ecore_x<19718> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=951430724
06-02 20:27:13.567+0900 I/MY_LOG  (19718): Button unpressed
06-02 20:27:13.597+0900 D/basicui (19718): successed to load edc file
06-02 20:27:13.627+0900 E/EFL     (19718): elementary<19718> elm_layout.c:991 _elm_layout_elm_container_content_set() could not swallow 0x8007bbdf into part 'swallow_content'
06-02 20:27:15.009+0900 E/EFL     (19718): ecore_x<19718> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=951432175
06-02 20:27:15.109+0900 E/EFL     (19718): ecore_x<19718> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=951432274
06-02 20:27:15.169+0900 E/EFL     (19718): edje<19718> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p9';
06-02 20:27:15.169+0900 E/EFL     (19718): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:27:15.900+0900 E/EFL     (19718): ecore_x<19718> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=951433058
06-02 20:27:15.950+0900 E/EFL     (19718): ecore_x<19718> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=951433113
06-02 20:27:15.950+0900 E/EFL     (19718): eo<19718> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_widget_item.eo.c:56: unable to resolve regular api func 'elm_wdg_item_part_text_get' 0xb6d9e9e9 in class 'Elm_Hoversel'.
06-02 20:27:16.090+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 19718 pgid = 19718
06-02 20:27:16.090+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(19718)
06-02 20:27:16.090+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:27:16.130+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-02 20:27:16.130+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-02 20:27:16.130+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
06-02 20:27:16.140+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[19718] terminate event is forwarded
06-02 20:27:16.140+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
06-02 20:27:16.140+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 19718, ]
06-02 20:27:16.140+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
06-02 20:27:16.140+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
06-02 20:27:16.140+0900 I/Tizen::App( 1233): (512) > Not registered pid(19718)
06-02 20:27:16.140+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
06-02 20:27:16.140+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:27:16.140+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 19718
06-02 20:27:16.140+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 19718
06-02 20:27:16.140+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 19718
06-02 20:27:16.150+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2570
06-02 20:27:16.160+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-02 20:27:16.160+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:27:16.160+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:27:16.160+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-02 20:27:16.160+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-02 20:27:16.170+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-02 20:27:16.180+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:27:16.180+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.example.client, 19718.
06-02 20:27:16.190+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-02 20:27:16.190+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:27:16.190+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-02 20:27:16.200+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:27:16.210+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-02 20:27:16.230+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
06-02 20:27:16.240+0900 W/CRASH_MANAGER(20365): worker.c: worker_job(1199) > 0619718636c691496402835
06-02 20:27:16.250+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
06-02 20:27:16.250+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:27:16.260+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-02 20:27:16.260+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 20:27:16.270+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:27:16.270+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-02 20:27:16.270+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 20:27:16.270+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 20:27:16.290+0900 E/weather-common( 1310): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
06-02 20:27:16.300+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_create(409) > New handle created[0xb81a1130]
06-02 20:27:16.310+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_get_type(463) > Connected Network = 2
06-02 20:27:16.310+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_destroy(427) > Destroy handle: 0xb81a1130
06-02 20:27:16.320+0900 E/weather-common( 1310): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
06-02 20:27:16.320+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
06-02 20:27:16.320+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-02 20:27:16.320+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-02 20:27:16.320+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: fg
06-02 20:27:22.216+0900 E/PKGMGR_SERVER(20429): pkgmgr-server.c: main(2414) > package manager server start
06-02 20:27:22.266+0900 E/PKGMGR  (20427): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
06-02 20:27:22.306+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 14
06-02 20:27:22.306+0900 W/AUL_AMD (  612): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-02 20:27:22.316+0900 E/PKGMGR_SERVER(20429): pkgmgr-server.c: sighandler(417) > child NORMAL exit [20432]
06-02 20:27:24.688+0900 W/AUL     (20507): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-02 20:27:24.688+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
06-02 20:27:24.698+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-02 20:27:24.708+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-02 20:27:24.708+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-02 20:27:24.708+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 20507
06-02 20:27:24.708+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-02 20:27:24.718+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
06-02 20:27:24.718+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-02 20:27:24.718+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-4)
06-02 20:27:24.838+0900 E/PKGMGR_SERVER(20429): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-02 20:27:24.838+0900 E/PKGMGR_SERVER(20429): pkgmgr-server.c: main(2471) > package manager server terminated.
06-02 20:27:24.858+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 20509, appid: org.example.client
06-02 20:27:24.858+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-02 20:27:24.868+0900 W/AUL     (20507): launch.c: app_request_to_launchpad(425) > request cmd(0) result(20509)
06-02 20:27:25.869+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:27:25.869+0900 W/AUL_AMD (  612): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-02 20:27:28.922+0900 I/abc     (20509): abc
06-02 20:27:28.942+0900 I/CAPI_APPFW_APPLICATION(20509): app_main.c: ui_app_main(789) > app_efl_main
06-02 20:27:29.873+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(20509)
06-02 20:27:29.873+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 20509, appid: org.example.client, status: bg
06-02 20:27:30.103+0900 I/CAPI_APPFW_APPLICATION(20509): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-02 20:27:32.326+0900 E/TBM     (20509): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-02 20:27:33.487+0900 I/APP_CORE(20509): appcore-efl.c: __do_app(514) > [APP 20509] Event: RESET State: CREATED
06-02 20:27:33.487+0900 I/CAPI_APPFW_APPLICATION(20509): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-02 20:27:33.527+0900 W/APP_CORE(20509): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
06-02 20:27:33.527+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-02 20:27:33.527+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:27:33.527+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:27:33.557+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 20:27:33.567+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
06-02 20:27:33.567+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:27:33.567+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:27:33.777+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-02 20:27:33.777+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-02 20:27:33.777+0900 I/APP_CORE(20509): appcore-efl.c: __do_app(514) > [APP 20509] Event: RESUME State: CREATED
06-02 20:27:33.777+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-02 20:27:33.787+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-02 20:27:33.787+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-02 20:27:33.787+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-02 20:27:33.797+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(20509) status(3)
06-02 20:27:33.797+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:27:33.797+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:27:33.797+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(20509)
06-02 20:27:33.797+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 20509, appid: org.example.client, status: fg
06-02 20:27:33.807+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-02 20:27:33.807+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-02 20:27:33.807+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-02 20:27:33.817+0900 I/APP_CORE(20509): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-02 20:27:33.817+0900 I/APP_CORE(20509): appcore-efl.c: __do_app(625) > [APP 20509] Initial Launching, call the resume_cb
06-02 20:27:33.817+0900 I/CAPI_APPFW_APPLICATION(20509): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:27:34.147+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(20509) status(0)
06-02 20:27:38.792+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-02 20:27:50.133+0900 I/MY_LOG  (20509): Button pressed
06-02 20:27:50.213+0900 E/VCONF   (20509): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-02 20:27:50.213+0900 E/VCONF   (20509): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-02 20:27:50.213+0900 E/VCONF   (20509): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-02 20:27:50.213+0900 E/VCONF   (20509): vconf.c: vconf_get_bool(2729) > vconf_get_bool(20509) : db/ise/keysound error
06-02 20:27:50.213+0900 E/VCONF   (20509): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-02 20:27:50.213+0900 E/VCONF   (20509): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-02 20:27:50.263+0900 I/MY_LOG  (20509): Button unpressed
06-02 20:27:50.804+0900 I/MY_LOG  (20509): Button pressed
06-02 20:27:50.884+0900 I/MY_LOG  (20509): Button unpressed
06-02 20:27:50.904+0900 D/basicui (20509): successed to load edc file
06-02 20:28:00.573+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-02 20:28:00.573+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 8:28
06-02 20:28:00.573+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 8:28"
06-02 20:28:00.573+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 8:28"
06-02 20:28:00.573+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-02 20:28:00.573+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145655180 Time: <font_size=31> </font_size> <font_size=31> 오후 8:28</font_size></font>"
06-02 20:28:28.050+0900 W/CRASH_MANAGER(20537): worker.c: worker_job(1199) > 0620509636c69149640290
