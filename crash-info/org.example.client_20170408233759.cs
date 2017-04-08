S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 3248
Date: 2017-04-08 23:37:59+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 3248, uid 5000)

Register Information
r0   = 0x2a3a0eb8, r1   = 0x2a3a0eb8
r2   = 0x00000000, r3   = 0x2a34db30
r4   = 0x2a014b81, r5   = 0x2a33f2f0
r6   = 0x2a3a4928, r7   = 0xbefff588
r8   = 0x800d168f, r9   = 0xb6508708
r10  = 0x2a3a19e0, fp   = 0x00000000
ip   = 0x800d168f, sp   = 0xbefff578
lr   = 0x2a014ba5, pc   = 0x2a00b434
cpsr = 0x600f0030

Memory Information
MemTotal:   987012 KB
MemFree:    170216 KB
Buffers:     38480 KB
Cached:     329964 KB
VmPeak:     117264 KB
VmSize:     115520 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26860 KB
VmRSS:       25636 KB
VmData:      37276 KB
VmStk:         136 KB
VmExe:         124 KB
VmLib:       28580 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 3248 TID = 3248
3248 3260 3268 3270 

Maps Information
2a000000 2a01f000 r-xp /opt/usr/apps/org.example.client/bin/client
2a030000 2a3e5000 rw-p [heap]
afc65000 b0464000 rw-p [stack:3270]
b2186000 b2197000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
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
b27e4000 b27e9000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
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
b2a3b000 b323a000 rw-p [stack:3268]
b356b000 b3575000 r-xp /lib/libnss_files-2.20-2014.11.so
b3586000 b358f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b35a0000 b35b1000 r-xp /lib/libnsl-2.20-2014.11.so
b35c4000 b35ca000 r-xp /lib/libnss_compat-2.20-2014.11.so
b35db000 b35df000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35f0000 b36d3000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b370a000 b3732000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b3744000 b3f43000 rw-p [stack:3260]
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

Callstack Information (PID:3248)
Call Stack Count: 21
 0: _ZN22FoodModifyDeleteButton5clickEv + 0xd (0x2a00b434) [/opt/usr/apps/org.example.client/bin/client] + 0xb434
 1: _ZN6Button14callback_clickEPvP10_Eo_OpaqueS0_ + 0x24 (0x2a014ba5) [/opt/usr/apps/org.example.client/bin/client] + 0x14ba5
 2: (0xb6b3b7ed) [/usr/lib/libevas.so.1] + 0x667ed
 3: (0xb64f4219) [/usr/lib/libeo.so.1] + 0xb219
 4: eo_event_callback_call + 0x68 (0xb64f2fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 5: evas_object_smart_callback_call + 0x38 (0xb6b3cedd) [/usr/lib/libevas.so.1] + 0x67edd
 6: (0xb6560167) [/usr/lib/libedje.so.1] + 0x57167
 7: (0xb6564d87) [/usr/lib/libedje.so.1] + 0x5bd87
 8: (0xb6560b21) [/usr/lib/libedje.so.1] + 0x57b21
 9: (0xb6560ef1) [/usr/lib/libedje.so.1] + 0x57ef1
10: (0xb6561045) [/usr/lib/libedje.so.1] + 0x58045
11: (0xb65aed11) [/usr/lib/libecore.so.1] + 0xfd11
12: (0xb65aac4b) [/usr/lib/libecore.so.1] + 0xbc4b
13: (0xb65b0a5d) [/usr/lib/libecore.so.1] + 0x11a5d
14: ecore_main_loop_begin + 0x3e (0xb65b0c83) [/usr/lib/libecore.so.1] + 0x11c83
15: appcore_efl_main + 0x20c (0xb674b2bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
16: ui_app_main + 0xc0 (0xb6f35909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
17: _ZN6Window10makeWindowEiPPc + 0x11e (0x2a0137eb) [/opt/usr/apps/org.example.client/bin/client] + 0x137eb
18: main + 0x40 (0x2a0045b9) [/opt/usr/apps/org.example.client/bin/client] + 0x45b9
19: __libc_start_main + 0x114 (0xb68fb4bc) [/lib/libc.so.6] + 0x164bc
20: (0x2a0043f0) [/opt/usr/apps/org.example.client/bin/client] + 0x43f0
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
e_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-08 23:36:51.027+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-08 23:36:51.037+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-08 23:36:51.037+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-08 23:36:51.037+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-08 23:36:51.047+0900 I/Internet( 1488): webview.cpp: __policy_navigation_decide_cb(5363) > 
04-08 23:36:51.047+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [com.samsun] 
04-08 23:36:51.047+0900 I/Tizen::System( 1246): (273) > Current App[com.samsun] is already actived.
04-08 23:36:51.057+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1488) status(4)
04-08 23:36:51.057+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.browser(1488)
04-08 23:36:51.057+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1488, appid: com.samsung.browser, status: bg
04-08 23:36:51.057+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-08 23:36:51.077+0900 E/weather-widget( 1410): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-08 23:36:51.077+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-08 23:36:51.077+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-08 23:36:51.087+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-08 23:36:51.087+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-08 23:36:51.087+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-08 23:36:51.097+0900 E/weather-common( 1410): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-08 23:36:51.117+0900 E/CAPI_APPFW_APP_CONTROL( 1488): app_control.c: app_control_error(154) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
04-08 23:36:51.117+0900 E/Internet( 1488): common-view.cpp: _handle_unknown_scheme(2499) > Fail to app_control_send_launch_request
04-08 23:36:51.127+0900 I/Internet( 1488): webview.cpp: __policy_response_decide_cb(5554) > 
04-08 23:36:51.167+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_create(409) > New handle created[0xb8570b18]
04-08 23:36:51.167+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_get_type(463) > Connected Network = 2
04-08 23:36:51.177+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_destroy(427) > Destroy handle: 0xb8570b18
04-08 23:36:51.177+0900 E/weather-common( 1410): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-08 23:36:51.177+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-08 23:36:51.177+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-08 23:36:51.177+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-08 23:36:51.177+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: fg
04-08 23:36:51.207+0900 I/APP_CORE( 1488): appcore-efl.c: __do_app(514) > [APP 1488] Event: PAUSE State: RUNNING
04-08 23:36:51.207+0900 I/CAPI_APPFW_APPLICATION( 1488): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-08 23:36:51.207+0900 I/Internet( 1488): main.cpp: __br_app_pause(672) > 
04-08 23:36:51.207+0900 I/CAPI_NETWORK_CONNECTION( 1488): connection.c: connection_get_type(463) > Connected Network = 2
04-08 23:36:51.247+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.338
04-08 23:36:51.267+0900 W/UI_GADGET( 1488): manager.c: ugman_pause(1092) > [34mugman_pause failed: no root[0m
04-08 23:36:51.307+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 1488): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 35
04-08 23:36:51.307+0900 E/APP_CORE( 1488): appcore-efl.c: _capture_and_make_file(1619) > win[6000003] widget[720] height[1280]
04-08 23:36:51.307+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
04-08 23:36:51.527+0900 I/Internet( 1488): webview.cpp: __frame_rendered_cb(3712) > 
04-08 23:36:51.547+0900 I/Internet( 1488): webview.cpp: __policy_response_decide_cb(5554) > 
04-08 23:36:51.587+0900 E/EFL     (  850): ecore_x<850> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=3348770
04-08 23:36:51.587+0900 W/STARTER (  733): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
04-08 23:36:51.587+0900 W/STARTER (  733): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
04-08 23:36:51.587+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=3348770
04-08 23:36:51.587+0900 E/cluster-view(  868): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
04-08 23:36:51.667+0900 I/Internet( 1488): webview.cpp: __icon_received_cb(5240) > 
04-08 23:36:51.887+0900 E/STARTER (  733): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
04-08 23:36:51.887+0900 E/STARTER (  733): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
04-08 23:36:51.887+0900 E/STARTER (  733): )
04-08 23:36:51.887+0900 I/SYSPOPUP(  864): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
04-08 23:36:51.897+0900 I/SYSPOPUP(  864): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
04-08 23:36:51.897+0900 E/VOLUME  (  864): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
04-08 23:36:51.897+0900 E/VOLUME  (  864): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
04-08 23:36:51.907+0900 W/AUL     (  733): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
04-08 23:36:51.907+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
04-08 23:36:51.917+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
04-08 23:36:51.917+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-08 23:36:51.917+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 733
04-08 23:36:51.917+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-08 23:36:51.927+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-08 23:36:51.937+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-08 23:36:51.937+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-08 23:36:51.937+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-08 23:36:51.958+0900 I/GXT_SIB (  342): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
04-08 23:36:51.968+0900 E/CAPI_APPFW_APPLICATION( 2896): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-08 23:36:51.968+0900 E/CAPI_APPFW_APPLICATION( 2896): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-08 23:36:51.968+0900 E/CAPI_APPFW_APPLICATION( 2896): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-08 23:36:51.968+0900 E/CAPI_APPFW_APPLICATION( 2896): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-08 23:36:51.968+0900 E/CAPI_APPFW_APPLICATION( 2896): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-08 23:36:51.968+0900 I/CAPI_APPFW_APPLICATION( 2896): app_main.c: ui_app_main(789) > app_efl_main
04-08 23:36:51.968+0900 I/CAPI_APPFW_APPLICATION( 2896): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-08 23:36:51.968+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6c086e9 in class 'Edje_Object'.
04-08 23:36:51.968+0900 E/UXT     (  342): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
04-08 23:36:51.978+0900 W/BROWSER_PROVIDER( 2882): browser-provider-requests-manager.c: __handle_client_request(357) > client(HISTORY:1747413609) sock:10 req(GET_DATE_IDS:-1)
04-08 23:36:51.978+0900 W/BROWSER_PROVIDER( 2882): browser-provider-requests-manager.c: __handle_client_request(357) > client(HISTORY:1747413609) sock:10 req(SET_ICON:2007070356)
04-08 23:36:51.998+0900 W/BROWSER_PROVIDER( 2882): browser-provider-requests-manager.c: __handle_client_request(357) > client(BOOKMARK:1833187923) sock:15 req(GET_DATE_IDS:-1)
04-08 23:36:52.008+0900 E/Internet( 1488): bookmark.cpp: get_id(662) > uri is NULL
04-08 23:36:52.038+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 2896, appid: com.samsung.task-mgr
04-08 23:36:52.038+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-08 23:36:52.058+0900 W/AUL     (  733): launch.c: app_request_to_launchpad(425) > request cmd(0) result(2896)
04-08 23:36:52.068+0900 E/RESOURCED(  684): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
04-08 23:36:52.078+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-08 23:36:52.088+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-08 23:36:52.108+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-08 23:36:52.128+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-08 23:36:52.138+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-08 23:36:52.158+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-08 23:36:52.178+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-08 23:36:52.188+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-08 23:36:52.208+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-08 23:36:52.218+0900 W/STARTER (  733): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
04-08 23:36:52.218+0900 E/EFL     (  850): ecore_x<850> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=3349415
04-08 23:36:52.218+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=3349415
04-08 23:36:52.218+0900 E/cluster-view(  868): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
04-08 23:36:52.228+0900 E/STARTER (  733): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
04-08 23:36:52.228+0900 E/STARTER (  733): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
04-08 23:36:52.228+0900 E/STARTER (  733): )
04-08 23:36:52.228+0900 I/SYSPOPUP(  864): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
04-08 23:36:52.228+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-08 23:36:52.228+0900 I/SYSPOPUP(  864): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
04-08 23:36:52.228+0900 E/VOLUME  (  864): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
04-08 23:36:52.228+0900 E/VOLUME  (  864): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
04-08 23:36:52.238+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-08 23:36:52.238+0900 W/TASK_MGR_LITE( 2896): task-mgr-lite.c: create_win(197) > changeable ui enabled success
04-08 23:36:52.258+0900 I/GXT_SIB ( 2896): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
04-08 23:36:52.288+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-08 23:36:52.288+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-08 23:36:52.308+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-08 23:36:52.308+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-08 23:36:52.338+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [com.samsun] 
04-08 23:36:52.338+0900 I/Tizen::System( 1246): (273) > Current App[com.samsun] is already actived.
04-08 23:36:52.358+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
04-08 23:36:52.358+0900 E/RUA     ( 2896): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 16, ncols : 5
04-08 23:36:52.358+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
04-08 23:36:52.368+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-08 23:36:52.368+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
04-08 23:36:52.368+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 1488
04-08 23:36:52.368+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
04-08 23:36:52.368+0900 E/TASK_MGR_LITE( 2896): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
04-08 23:36:52.368+0900 E/TASK_MGR_LITE( 2896): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsung-log-relay-mobile-service) in ai_tbl !!
04-08 23:36:52.368+0900 E/TASK_MGR_LITE( 2896): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
04-08 23:36:52.368+0900 E/TASK_MGR_LITE( 2896): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
04-08 23:36:52.368+0900 E/TASK_MGR_LITE( 2896): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
04-08 23:36:52.368+0900 E/TASK_MGR_LITE( 2896): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
04-08 23:36:52.368+0900 E/TASK_MGR_LITE( 2896): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
04-08 23:36:52.368+0900 E/TASK_MGR_LITE( 2896): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
04-08 23:36:52.368+0900 E/TASK_MGR_LITE( 2896): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
04-08 23:36:52.368+0900 E/TASK_MGR_LITE( 2896): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
04-08 23:36:52.368+0900 E/TASK_MGR_LITE( 2896): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
04-08 23:36:52.368+0900 E/TASK_MGR_LITE( 2896): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
04-08 23:36:52.368+0900 E/TASK_MGR_LITE( 2896): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
04-08 23:36:52.428+0900 I/APP_CORE( 2896): appcore-efl.c: __do_app(514) > [APP 2896] Event: RESET State: CREATED
04-08 23:36:52.428+0900 I/CAPI_APPFW_APPLICATION( 2896): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-08 23:36:52.438+0900 E/EFL     ( 2896): edje<2896> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:52.438+0900 E/EFL     ( 2896): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:52.438+0900 E/EFL     ( 2896): edje<2896> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:52.438+0900 E/EFL     ( 2896): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:52.438+0900 W/APP_CORE( 2896): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7400003
04-08 23:36:52.438+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-08 23:36:52.648+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(2896) status(0)
04-08 23:36:52.648+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(2896) status(0)
04-08 23:36:52.658+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-08 23:36:52.658+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-08 23:36:52.658+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-08 23:36:52.658+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-08 23:36:52.658+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-08 23:36:52.658+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-08 23:36:52.668+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(2896) status(3)
04-08 23:36:52.668+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-08 23:36:52.668+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-08 23:36:52.668+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(2896)
04-08 23:36:52.668+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 2896, appid: com.samsung.task-mgr, status: fg
04-08 23:36:52.668+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-08 23:36:52.678+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-08 23:36:52.678+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-08 23:36:52.678+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: bg
04-08 23:36:52.698+0900 I/APP_CORE( 2896): appcore-efl.c: __do_app(514) > [APP 2896] Event: RESUME State: CREATED
04-08 23:36:52.718+0900 I/APP_CORE( 2896): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-08 23:36:52.718+0900 I/APP_CORE( 2896): appcore-efl.c: __do_app(625) > [APP 2896] Initial Launching, call the resume_cb
04-08 23:36:52.718+0900 I/CAPI_APPFW_APPLICATION( 2896): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-08 23:36:53.069+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.340
04-08 23:36:53.079+0900 I/Tizen::App( 1246): (499) > LaunchedApp(com.samsung.task-mgr)
04-08 23:36:53.079+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for com.samsung.task-mgr, 2896.
04-08 23:36:53.149+0900 I/Internet( 1488): webview.cpp: __policy_navigation_decide_cb(5363) > 
04-08 23:36:53.159+0900 I/Internet( 1488): webview.cpp: __policy_navigation_decide_cb(5363) > 
04-08 23:36:53.159+0900 E/EFL     ( 2896): ecore_x<2896> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=3350350
04-08 23:36:53.169+0900 I/Internet( 1488): webview.cpp: __policy_navigation_decide_cb(5363) > 
04-08 23:36:53.169+0900 I/Internet( 1488): webview.cpp: __policy_navigation_decide_cb(5363) > 
04-08 23:36:53.249+0900 E/EFL     ( 2896): ecore_x<2896> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=3350438
04-08 23:36:53.359+0900 I/Internet( 1488): webview.cpp: __policy_response_decide_cb(5554) > 
04-08 23:36:53.399+0900 I/Internet( 1488): webview.cpp: __policy_response_decide_cb(5554) > 
04-08 23:36:53.429+0900 I/Internet( 1488): webview.cpp: __policy_response_decide_cb(5554) > 
04-08 23:36:53.449+0900 I/Internet( 1488): webview.cpp: __policy_response_decide_cb(5554) > 
04-08 23:36:53.579+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
04-08 23:36:53.579+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
04-08 23:36:53.579+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(2896)
04-08 23:36:53.579+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 2896, appid: com.samsung.task-mgr, status: bg
04-08 23:36:53.579+0900 I/CAPI_APPFW_APPLICATION( 2896): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-08 23:36:53.579+0900 W/TASK_MGR_LITE( 2896): task-mgr-lite.c: _pause_app(406) > 
04-08 23:36:53.579+0900 I/CAPI_APPFW_APPLICATION( 2896): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-08 23:36:53.579+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
04-08 23:36:53.579+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 1488
04-08 23:36:53.579+0900 W/AUL     ( 2896): launch.c: app_request_to_launchpad(396) > request cmd(4) to(1488)
04-08 23:36:53.579+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 4
04-08 23:36:53.579+0900 I/APP_CORE( 1488): appcore-efl.c: __do_app(514) > [APP 1488] Event: TERMINATE State: PAUSED
04-08 23:36:53.589+0900 W/AUL_AMD (  607): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1488), cmd(4)
04-08 23:36:53.589+0900 W/AUL     ( 2896): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
04-08 23:36:53.589+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
04-08 23:36:53.589+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
04-08 23:36:53.589+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
04-08 23:36:53.589+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
04-08 23:36:53.599+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 1488): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 11
04-08 23:36:53.599+0900 E/APP_CORE( 1488): appcore-efl.c: _capture_and_make_file(1619) > win[6000003] widget[720] height[1280]
04-08 23:36:53.599+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
04-08 23:36:53.599+0900 E/APP_CORE( 1488): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [com.samsung.browser]
04-08 23:36:53.609+0900 I/CAPI_APPFW_APPLICATION( 1488): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-08 23:36:53.609+0900 I/Internet( 1488): main.cpp: __br_app_terminate(1484) > 
04-08 23:36:53.629+0900 E/TASK_MGR_LITE( 2896): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
04-08 23:36:53.649+0900 I/CAPI_NETWORK_CONNECTION( 1488): connection.c: connection_get_type(463) > Connected Network = 2
04-08 23:36:53.649+0900 I/CAPI_NETWORK_CONNECTION( 1488): connection.c: connection_destroy(427) > Destroy handle: 0xb88b38a8
04-08 23:36:53.649+0900 I/CAPI_NETWORK_CONNECTION( 1488): connection.c: __connection_set_type_changed_callback(181) > Successfully de-registered(0)
04-08 23:36:53.649+0900 W/BROWSER_PROVIDER( 2882): browser-provider-requests-manager.c: __handle_client_request(357) > client(BOOKMARK:1833187923) sock:15 req(DEINIT:-1)
04-08 23:36:53.649+0900 E/BROWSER_PROVIDER( 2882): browser-provider-socket.c: bp_ipc_recv(56) > [ERROR] __handle_client_request closed peer sock:15
04-08 23:36:53.649+0900 E/BROWSER_PROVIDER( 2882): browser-provider-requests-manager.c: client_thread_idle(481) > disconnect client:BOOKMARK/1833187923 sock:15
04-08 23:36:53.649+0900 W/BROWSER_PROVIDER( 2882): browser-provider-requests-manager.c: __handle_client_request(357) > client(HISTORY:1747413609) sock:10 req(DEINIT:-1)
04-08 23:36:53.649+0900 E/BROWSER_PROVIDER( 2882): browser-provider-socket.c: bp_ipc_recv(56) > [ERROR] __handle_client_request closed peer sock:10
04-08 23:36:53.649+0900 E/BROWSER_PROVIDER( 2882): browser-provider-requests-manager.c: client_thread_idle(481) > disconnect client:HISTORY/1747413609 sock:10
04-08 23:36:53.659+0900 E/APP_CORE( 2896): appcore.c: appcore_flush_memory(793) > Appcore not initialized
04-08 23:36:53.669+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-08 23:36:53.669+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(3)
04-08 23:36:53.669+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-08 23:36:53.689+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-08 23:36:53.689+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(868)
04-08 23:36:53.689+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-08 23:36:53.699+0900 E/EFL     ( 1488): elementary<1488> elm_layout.c:991 _elm_layout_elm_container_content_set() could not swallow 0x800fa1d4 into part 'tizen_vg_shape2'
04-08 23:36:53.699+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-08 23:36:53.759+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-08 23:36:53.759+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-08 23:36:53.759+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-08 23:36:53.759+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-08 23:36:53.769+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-08 23:36:53.789+0900 I/MALI    ( 2896): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=2896   close drm_fd=30 
04-08 23:36:53.789+0900 E/weather-widget( 1410): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-08 23:36:53.789+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-08 23:36:53.819+0900 E/weather-common( 1410): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-08 23:36:53.829+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [com.samsun] 
04-08 23:36:53.829+0900 I/Tizen::System( 1246): (273) > Current App[com.samsun] is already actived.
04-08 23:36:53.879+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_create(409) > New handle created[0xb85a5868]
04-08 23:36:53.879+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_get_type(463) > Connected Network = 2
04-08 23:36:53.879+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_destroy(427) > Destroy handle: 0xb85a5868
04-08 23:36:53.879+0900 E/weather-common( 1410): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-08 23:36:53.889+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-08 23:36:53.889+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-08 23:36:53.889+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-08 23:36:53.889+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: fg
04-08 23:36:54.100+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 2896 pgid = 2896
04-08 23:36:54.100+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(2896)
04-08 23:36:54.170+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-08 23:36:54.170+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-08 23:36:54.170+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-08 23:36:54.180+0900 I/Tizen::App( 1246): (243) > App[com.samsung.task-mgr] pid[2896] terminate event is forwarded
04-08 23:36:54.180+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-08 23:36:54.180+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [com.samsung.task-mgr, 2896, ]
04-08 23:36:54.180+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-08 23:36:54.180+0900 I/Tizen::App( 1246): (506) > TerminatedApp(com.samsung.task-mgr)
04-08 23:36:54.180+0900 I/Tizen::App( 1246): (512) > Not registered pid(2896)
04-08 23:36:54.180+0900 I/Tizen::System( 1246): (246) > Terminated app [com.samsung.task-mgr]
04-08 23:36:54.180+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-08 23:36:54.180+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 2896
04-08 23:36:54.180+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 2896
04-08 23:36:54.180+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 2896
04-08 23:36:54.190+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.342
04-08 23:36:54.200+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-08 23:36:54.200+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for com.samsung.task-mgr, 2896.
04-08 23:36:54.430+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1488): preference_inoti.c: _preference_kdb_del_notify(372) > _preference_kdb_del_notify : Key(BookmarkSelectFolderPathTree) does not exist
04-08 23:36:54.430+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1488): preference.c: preference_unset_changed_cb(1487) > NO_KEY(0xfef00030) : fail to find given key(BookmarkSelectFolderPathTree)
04-08 23:36:54.450+0900 W/BROWSER_PROVIDER( 2882): browser-provider-requests-manager.c: __handle_client_request(357) > client(TABS:1590642353) sock:7 req(DUP_ORDER_IDS:-1)
04-08 23:36:54.450+0900 W/BROWSER_PROVIDER( 2882): browser-provider-requests-manager.c: __handle_client_request(357) > client(TABS:1590642353) sock:7 req(GET_INFO_OFFSET:1907916453)
04-08 23:36:54.460+0900 W/BROWSER_PROVIDER( 2882): browser-provider-requests-manager.c: __handle_client_request(357) > client(TABS:1590642353) sock:7 req(DEINIT:-1)
04-08 23:36:54.460+0900 E/Internet( 1488): mdm-manager.cpp: deregister_policy(271) > mdm_deregister_policy_receiver() is failed [0xc0000000]
04-08 23:36:54.460+0900 E/Internet( 1488): mdm-manager.cpp: deregister_policy(275) > mdm_release_service failed
04-08 23:36:54.460+0900 E/BROWSER_PROVIDER( 2882): browser-provider-socket.c: bp_ipc_recv(56) > [ERROR] __handle_client_request closed peer sock:7
04-08 23:36:54.460+0900 E/BROWSER_PROVIDER( 2882): browser-provider-requests-manager.c: client_thread_idle(481) > disconnect client:TABS/1590642353 sock:7
04-08 23:36:54.470+0900 E/Internet( 1488): browser.cpp: terminate_app_launch_request(2250) > m_appControl is NULL
04-08 23:36:54.500+0900 E/VCONF   ( 1488): vconf-kdb.c: _vconf_kdb_del_notify(468) > Error: inotify_add_watch() [/var/run/memory/popsync+popsync_activated]: No such file or directory
04-08 23:36:54.560+0900 I/MALI    ( 1488): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=1488   close drm_fd=25 
04-08 23:36:54.830+0900 I/UXT     ( 3102): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-08 23:36:54.880+0900 E/TBM     ( 3102): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-08 23:36:54.880+0900 I/MALI    ( 3102): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=3102   open drm_fd=30 
04-08 23:36:54.920+0900 I/CAPI_NETWORK_CONNECTION( 1488): connection.c: connection_destroy(427) > Destroy handle: 0xb8925c40
04-08 23:36:54.920+0900 I/CAPI_NETWORK_CONNECTION( 1488): connection.c: __connection_set_ip_changed_callback(266) > Successfully de-registered(0)
04-08 23:36:54.920+0900 I/CAPI_NETWORK_CONNECTION( 1488): connection.c: __connection_set_proxy_changed_callback(351) > Successfully de-registered(0)
04-08 23:36:54.930+0900 E/WEBKIT  ( 1488): static void Ewk_Geolocation_Provider::stopUpdating(WKGeolocationManagerRef, const void*)(201) > ERROR: already stopped or not started
04-08 23:36:54.960+0900 E/BROWSER_PROVIDER( 2882): browser-provider-socket.c: bp_ipc_recv(56) > [ERROR] __handle_client_request closed peer sock:17
04-08 23:36:54.960+0900 E/BROWSER_PROVIDER( 2882): browser-provider-requests-manager.c: client_thread_idle(481) > disconnect client:BOOKMARK_CSC/1835673001 sock:17
04-08 23:36:54.960+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 1488 pgid = 1488
04-08 23:36:54.960+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(1488)
04-08 23:36:55.010+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-08 23:36:55.010+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-08 23:36:55.010+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-08 23:36:55.020+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 1488
04-08 23:36:55.020+0900 I/Tizen::App( 1246): (243) > App[com.samsung.browser] pid[1488] terminate event is forwarded
04-08 23:36:55.020+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-08 23:36:55.020+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [com.samsung.browser, 1488, ]
04-08 23:36:55.020+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-08 23:36:55.020+0900 I/Tizen::App( 1246): (506) > TerminatedApp(com.samsung.browser)
04-08 23:36:55.020+0900 I/Tizen::App( 1246): (512) > Not registered pid(1488)
04-08 23:36:55.020+0900 I/Tizen::System( 1246): (246) > Terminated app [com.samsung.browser]
04-08 23:36:55.020+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-08 23:36:55.020+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 1488
04-08 23:36:55.020+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.345
04-08 23:36:55.031+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-08 23:36:55.031+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for com.samsung.browser, 1488.
04-08 23:36:55.041+0900 E/EFL     ( 3102): edje<3102> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:55.041+0900 E/EFL     ( 3102): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:55.041+0900 E/EFL     ( 3102): edje<3102> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:55.041+0900 E/EFL     ( 3102): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:55.041+0900 E/EFL     ( 3102): edje<3102> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-08 23:36:55.041+0900 E/EFL     ( 3102): By the power of Grayskull, your previous Embryo stack is now broken!
04-08 23:36:58.584+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-08 23:36:58.594+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-08 23:36:58.594+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-08 23:37:00.336+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(195) > ""
04-08 23:37:00.346+0900 E/UXT     (  682): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 11:37
04-08 23:37:00.346+0900 I/INDICATOR(  682): clock.c: getTimeFormatted(176) > "time format : 오후 11:37"
04-08 23:37:00.346+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 11:37"
04-08 23:37:00.346+0900 W/INDICATOR(  682): clock.c: indicator_clock_changed_cb(272) > 
04-08 23:37:00.346+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146665406 Time: <font_size=31> </font_size> <font_size=31> 오후 11:37</font_size></font>"
04-08 23:37:25.100+0900 E/PKGMGR_SERVER( 3189): pkgmgr-server.c: main(2414) > package manager server start
04-08 23:37:25.150+0900 E/PKGMGR  ( 3187): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-08 23:37:25.190+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
04-08 23:37:25.190+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-08 23:37:25.200+0900 E/PKGMGR_SERVER( 3189): pkgmgr-server.c: sighandler(417) > child NORMAL exit [3192]
04-08 23:37:27.552+0900 W/AUL     ( 3246): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-08 23:37:27.552+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
04-08 23:37:27.562+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-08 23:37:27.572+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-08 23:37:27.572+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-08 23:37:27.572+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 3246
04-08 23:37:27.572+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-08 23:37:27.572+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-08 23:37:27.572+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-08 23:37:27.582+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-4)
04-08 23:37:27.722+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 3248, appid: org.example.client
04-08 23:37:27.722+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-08 23:37:27.732+0900 W/AUL     ( 3246): launch.c: app_request_to_launchpad(425) > request cmd(0) result(3248)
04-08 23:37:27.732+0900 E/RESOURCED(  684): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.client
04-08 23:37:27.812+0900 E/PKGMGR_SERVER( 3189): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-08 23:37:27.812+0900 E/PKGMGR_SERVER( 3189): pkgmgr-server.c: main(2471) > package manager server terminated.
04-08 23:37:28.653+0900 E/RESOURCED(  684): datausage-common.c: turn_on_counters(1734) > Can't get iftype for remove counter
04-08 23:37:28.723+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-08 23:37:28.723+0900 W/AUL_AMD (  607): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-08 23:37:32.287+0900 I/abc     ( 3248): abc
04-08 23:37:32.307+0900 I/CAPI_APPFW_APPLICATION( 3248): app_main.c: ui_app_main(789) > app_efl_main
04-08 23:37:32.717+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(3248)
04-08 23:37:32.717+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 3248, appid: org.example.client, status: bg
04-08 23:37:33.428+0900 I/CAPI_APPFW_APPLICATION( 3248): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-08 23:37:35.570+0900 E/TBM     ( 3248): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-08 23:37:36.671+0900 D/basicui ( 3248): successed to load edc file
04-08 23:37:36.701+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-08 23:37:36.701+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-08 23:37:36.731+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-08 23:37:36.731+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-08 23:37:36.741+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-08 23:37:36.741+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-08 23:37:37.452+0900 I/MY_LOG  ( 3248): change
04-08 23:37:37.512+0900 I/APP_CORE( 3248): appcore-efl.c: __do_app(514) > [APP 3248] Event: RESET State: CREATED
04-08 23:37:37.512+0900 I/CAPI_APPFW_APPLICATION( 3248): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-08 23:37:37.542+0900 W/APP_CORE( 3248): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
04-08 23:37:37.542+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-08 23:37:37.852+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-08 23:37:37.852+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-08 23:37:37.852+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-08 23:37:37.852+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-08 23:37:37.852+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-08 23:37:37.852+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-08 23:37:37.852+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(3248) status(3)
04-08 23:37:37.852+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-08 23:37:37.852+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-08 23:37:37.862+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(3248)
04-08 23:37:37.862+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 3248, appid: org.example.client, status: fg
04-08 23:37:37.862+0900 I/APP_CORE( 3248): appcore-efl.c: __do_app(514) > [APP 3248] Event: RESUME State: CREATED
04-08 23:37:37.882+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-08 23:37:37.882+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-08 23:37:37.882+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: bg
04-08 23:37:37.892+0900 I/APP_CORE( 3248): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-08 23:37:37.892+0900 I/APP_CORE( 3248): appcore-efl.c: __do_app(625) > [APP 3248] Initial Launching, call the resume_cb
04-08 23:37:37.892+0900 I/CAPI_APPFW_APPLICATION( 3248): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-08 23:37:38.213+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(3248) status(0)
04-08 23:37:41.566+0900 D/basicui ( 3248): successed to load edc file
04-08 23:37:41.586+0900 I/MY_LOG  ( 3248): change
04-08 23:37:41.596+0900 I/MY_LOG  ( 3248): change
04-08 23:37:41.616+0900 E/VCONF   ( 3248): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-08 23:37:41.616+0900 E/VCONF   ( 3248): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-08 23:37:41.616+0900 E/VCONF   ( 3248): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-08 23:37:41.616+0900 E/VCONF   ( 3248): vconf.c: vconf_get_bool(2729) > vconf_get_bool(3248) : db/ise/keysound error
04-08 23:37:41.626+0900 E/VCONF   ( 3248): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-08 23:37:41.626+0900 E/VCONF   ( 3248): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-08 23:37:42.777+0900 I/MY_LOG  ( 3248): Button pressed
04-08 23:37:42.847+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: MEM_FLUSH State: PAUSED
04-08 23:37:42.857+0900 I/MY_LOG  ( 3248): Button unpressed
04-08 23:37:47.532+0900 W/BROWSER_PROVIDER( 2882): browser-provider-requests-manager.c: bp_thread_requests_manager(911) > Expire Idle state. No Client.
04-08 23:37:47.532+0900 W/BROWSER_PROVIDER( 2882): browser-provider-requests-manager.c: bp_thread_requests_manager(920) > terminate main thread ...
04-08 23:37:47.532+0900 W/BROWSER_PROVIDER( 2882): browser-provider-main.c: main(178) > Browser-Provider will be terminated.
04-08 23:37:59.944+0900 W/CRASH_MANAGER( 3275): worker.c: worker_job(1199) > 1103248636c69149166227
