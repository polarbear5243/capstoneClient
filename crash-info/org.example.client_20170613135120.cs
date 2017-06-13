S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 14617
Date: 2017-06-13 13:51:20+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 14617, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00003919
r2   = 0x00000006, r3   = 0xb3fc74c0
r4   = 0x00000002, r5   = 0xb3fc7000
r6   = 0xb699509c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb7cedaf0
r10  = 0xbee7d410, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbee7cf7c
lr   = 0xb688bf18, pc   = 0xb688ab84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     61956 KB
Buffers:     60252 KB
Cached:     228272 KB
VmPeak:      91288 KB
VmSize:      91284 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17896 KB
VmRSS:       17896 KB
VmData:      30340 KB
VmStk:         136 KB
VmExe:         196 KB
VmLib:       30368 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 14617 TID = 14617
14617 14622 14631 14632 

Maps Information
b1b14000 b1b1c000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b2d000 b1b3a000 r-xp /usr/lib/libmdm-common.so.1.0.98
b1b4b000 b1b8c000 r-xp /usr/lib/libmdm.so.1.2.12
b1b9c000 b1ba4000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b1bb3000 b1bc3000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b1be4000 b1c44000 r-xp /usr/lib/libasound.so.2.0.0
b1c56000 b1c59000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b1c69000 b1c6c000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b1c7c000 b1c81000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b1c91000 b1c92000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b1ca2000 b1cad000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b1cc1000 b1cc6000 r-xp /usr/lib/libmmfsession.so.0.0.1
b1cd6000 b1cf1000 r-xp /usr/lib/libmmfsound.so.0.1.0
b1d01000 b1d08000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b1d18000 b1d22000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b1d32000 b1d34000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b1d44000 b1d45000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b1d55000 b1d5d000 r-xp /usr/lib/libfeedback.so.0.1.4
b1d85000 b1d86000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1d96000 b1daa000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1f55000 b1f5b000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b1f6c000 b276b000 rw-p [stack:14632]
b276b000 b28c6000 r-xp /usr/lib/egl/libMali.so
b28db000 b2964000 r-xp /usr/lib/evas/modules/engines/gl_generic/v-1.13/module.so
b297c000 b2986000 r-xp /usr/lib/evas/modules/engines/gl_x11/v-1.13/module.so
b2997000 b29a3000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b29b5000 b31b4000 rw-p [stack:14631]
b34e5000 b34ef000 r-xp /lib/libnss_files-2.20-2014.11.so
b3500000 b3509000 r-xp /lib/libnss_nis-2.20-2014.11.so
b351a000 b352b000 r-xp /lib/libnsl-2.20-2014.11.so
b353e000 b3544000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3555000 b3559000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b356a000 b364d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3684000 b36ac000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b36be000 b3ebd000 rw-p [stack:14622]
b3ebd000 b3ebf000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3ecf000 b3fad000 r-xp /usr/lib/libCOREGL.so.4.0
b3fcc000 b3fcf000 r-xp /lib/libattr.so.1.1.0
b3fe0000 b3fe7000 r-xp /lib/libcrypt-2.20-2014.11.so
b401f000 b4022000 r-xp /lib/libcap.so.2.21
b4032000 b4034000 r-xp /usr/lib/libiri.so
b4044000 b4064000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4066000 b4069000 r-xp /usr/lib/libuuid.so.1.3.0
b4079000 b4090000 r-xp /usr/lib/libblkid.so.1.1.0
b40a1000 b40ca000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b40db000 b4122000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4133000 b4139000 r-xp /usr/lib/libjson-c.so.2.0.1
b414b000 b414f000 r-xp /usr/lib/libogg.so.0.7.1
b415f000 b4181000 r-xp /usr/lib/libvorbis.so.0.4.3
b4191000 b4275000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4291000 b429c000 r-xp /usr/lib/libgpg-error.so.0.15.0
b42ac000 b42af000 r-xp /usr/lib/libEGL.so.1.4
b42c0000 b42c6000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42d6000 b42d8000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42e8000 b42f5000 r-xp /usr/lib/libGLESv2.so.2.0
b4306000 b431e000 r-xp /usr/lib/libmount.so.1.1.0
b4330000 b4332000 r-xp /usr/lib/libXau.so.6.0.0
b4342000 b4378000 r-xp /usr/lib/libpulse.so.0.16.2
b4389000 b43cc000 r-xp /usr/lib/libsndfile.so.1.0.25
b43e1000 b445b000 r-xp /usr/lib/libgcrypt.so.20.0.3
b4470000 b4477000 r-xp /usr/lib/libsensord-share.so
b4488000 b44ea000 r-xp /usr/lib/libpixman-1.so.0.28.2
b44ff000 b4502000 r-xp /usr/lib/libXv.so.1.0.0
b4512000 b4517000 r-xp /usr/lib/libutilX.so.1.1.0
b4527000 b452c000 r-xp /usr/lib/libffi.so.6.0.2
b453c000 b454d000 r-xp /lib/libresolv-2.20-2014.11.so
b4562000 b4564000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b4574000 b4589000 r-xp /lib/libexpat.so.1.5.2
b459b000 b4659000 r-xp /usr/lib/libcairo.so.2.11200.14
b466c000 b4674000 r-xp /usr/lib/libdrm.so.2.4.0
b4685000 b4688000 r-xp /usr/lib/libdri2.so.0.0.0
b4698000 b46e6000 r-xp /usr/lib/libssl.so.1.0.0
b46fb000 b4707000 r-xp /usr/lib/libeeze.so.1.13.0
b4717000 b4720000 r-xp /usr/lib/libethumb.so.1.13.0
b4731000 b4734000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4744000 b48fb000 r-xp /usr/lib/libcrypto.so.1.0.0
b56e5000 b56ee000 r-xp /usr/lib/libXi.so.6.1.0
b56ff000 b5701000 r-xp /usr/lib/libXgesture.so.7.0.0
b5711000 b5715000 r-xp /usr/lib/libXtst.so.6.1.0
b5725000 b572b000 r-xp /usr/lib/libXrender.so.1.3.0
b573b000 b5741000 r-xp /usr/lib/libXrandr.so.2.2.0
b5751000 b5753000 r-xp /usr/lib/libXinerama.so.1.0.0
b5763000 b5766000 r-xp /usr/lib/libXfixes.so.3.1.0
b5777000 b5782000 r-xp /usr/lib/libXext.so.6.4.0
b5792000 b5794000 r-xp /usr/lib/libXdamage.so.1.1.0
b57a4000 b57a6000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57b6000 b57bd000 r-xp /usr/lib/libXcursor.so.1.0.2
b57cd000 b57e5000 r-xp /usr/lib/libudev.so.1.6.0
b57e8000 b57fc000 r-xp /usr/lib/libxcb.so.1.1.0
b580c000 b580e000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b581e000 b5825000 r-xp /usr/lib/libembryo.so.1.13.0
b5835000 b583f000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5850000 b5868000 r-xp /lib/libz.so.1.2.8
b5879000 b58b5000 r-xp /usr/lib/libsystemd.so.0.4.0
b58b7000 b58cf000 r-xp /usr/lib/libsensor.so.1.1.0
b58e0000 b58e7000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b58f7000 b58fe000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b5910000 b5912000 r-xp /usr/lib/libappsvc.so.0.1.0
b5922000 b5925000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5935000 b594e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b595f000 b5996000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b59a7000 b5a92000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b5aa5000 b5b1e000 r-xp /usr/lib/libsqlite3.so.0.8.6
b5b30000 b5b3a000 r-xp /usr/lib/libvconf.so.0.2.45
b5b4a000 b5b4c000 r-xp /usr/lib/libvasum.so.0.3.1
b5b5c000 b5b60000 r-xp /usr/lib/libsmack.so.1.0.0
b5b70000 b5b75000 r-xp /usr/lib/libxdgmime.so.1.1.0
b5b86000 b5bb0000 r-xp /usr/lib/libdbus-1.so.3.8.12
b5bc1000 b5bd8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b5be9000 b5bec000 r-xp /usr/lib/libbundle.so.0.1.22
b5bfc000 b5c14000 r-xp /usr/lib/libpng12.so.0.50.0
b5c25000 b5c48000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c69000 b5c7d000 r-xp /usr/lib/libector.so.1.13.0
b5c8e000 b5ca6000 r-xp /usr/lib/liblua-5.1.so
b5cb7000 b5d0e000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d22000 b5d4a000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d5b000 b5d6e000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d7f000 b5db9000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dca000 b5dd8000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5de8000 b5df0000 r-xp /usr/lib/libtbm.so.1.0.0
b5e00000 b5e0d000 r-xp /usr/lib/libeio.so.1.13.0
b5e1d000 b5e1f000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e2f000 b5e34000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e44000 b5e5b000 r-xp /usr/lib/libefreet.so.1.13.0
b5e6d000 b5e8d000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e9d000 b5ebd000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ebf000 b5ec5000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ed5000 b5ee6000 r-xp /usr/lib/libemotion.so.1.13.0
b5ef7000 b5efe000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f0e000 b5f20000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f31000 b5f36000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f46000 b5f5f000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f6f000 b5f8c000 r-xp /usr/lib/libeet.so.1.13.0
b5fa5000 b5fb5000 r-xp /usr/lib/libefl.so.1.13.0
b5fc6000 b60ab000 r-xp /usr/lib/libicuuc.so.51.1
b60c8000 b6208000 r-xp /usr/lib/libicui18n.so.51.1
b621f000 b6257000 r-xp /usr/lib/libecore_x.so.1.13.0
b6269000 b626b000 r-xp /usr/lib/libttrace.so.1.1
b627b000 b635d000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b636e000 b6450000 r-xp /usr/lib/libX11.so.6.3.0
b6463000 b6472000 r-xp /usr/lib/libeo.so.1.13.0
b6483000 b6506000 r-xp /usr/lib/libedje.so.1.13.0
b6519000 b6537000 r-xp /usr/lib/libecore.so.1.13.0
b6557000 b662c000 r-xp /usr/lib/libxml2.so.2.9.2
b6641000 b6644000 r-xp /usr/lib/libiniparser.so.0
b6654000 b669c000 r-xp /usr/lib/libeina.so.1.13.0
b66ad000 b66b2000 r-xp /usr/lib/libappcore-common.so.1.1
b66c2000 b66c7000 r-xp /usr/lib/libappcore-efl.so.1.1
b66d7000 b66dc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b66ed000 b6713000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6723000 b673b000 r-xp /usr/lib/libaul.so.0.1.0
b674d000 b67b8000 r-xp /lib/libm-2.20-2014.11.so
b67c9000 b67cf000 r-xp /lib/librt-2.20-2014.11.so
b67e0000 b67e2000 r-xp /lib/libdl-2.20-2014.11.so
b67f3000 b6800000 r-xp /usr/lib/libunwind.so.8.0.1
b6836000 b684f000 r-xp /lib/libgcc_s-4.9.so.1
b685f000 b6983000 r-xp /lib/libc-2.20-2014.11.so
b6998000 b6a33000 r-xp /usr/lib/libstdc++.so.6.0.20
b6a4f000 b6bd6000 r-xp /usr/lib/libevas.so.1.13.0
b6c0b000 b6e3f000 r-xp /usr/lib/libelementary.so.1.13.0
b6e6e000 b6e75000 r-xp /usr/lib/libefl-extension.so.0.1.0
b6e86000 b6e88000 r-xp /usr/lib/libdlog.so.0.0.0
b6e98000 b6e9d000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6ead000 b6eb1000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6ec2000 b6ec4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b6ed5000 b6ee9000 r-xp /lib/libpthread-2.20-2014.11.so
b6f15000 b6f22000 r-xp /usr/lib/liblptcp.so
b6f34000 b6f38000 r-xp /usr/lib/libsys-assert.so
b6f49000 b6f69000 r-xp /lib/ld-2.20-2014.11.so
b6f7a000 b6fab000 r-xp /opt/usr/apps/org.example.client/bin/client
b7ce0000 b7fab000 rw-p [heap]
bee5d000 bee7e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14617)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb688ab84) [/lib/libc.so.6] + 0x2bb84
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
: By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:51:14.334+0900 E/EFL     (14559): edje<14559> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:51:14.334+0900 E/EFL     (14559): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:51:14.334+0900 E/EFL     (14559): edje<14559> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:51:14.334+0900 E/EFL     (14559): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:51:15.395+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
06-13 13:51:16.536+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
06-13 13:51:16.836+0900 E/MEDIA_SERVER(  895): media-server-main.c: _ms_signal_handler(186) > [14406] Scanner is stopped by media-server
06-13 13:51:16.836+0900 E/MEDIA_SERVER(  895): media-server-scanner.c: ms_reset_scanner_status(292) > scanner_mutex is already locked
06-13 13:51:17.607+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: MEM_FLUSH State: PAUSED
06-13 13:51:17.917+0900 E/EFL     (14448): ecore_x<14448> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16464120
06-13 13:51:18.017+0900 E/EFL     (14448): ecore_x<14448> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16464219
06-13 13:51:18.017+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:51:18.027+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 13:51:18.027+0900 W/AUL     (14448): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 13:51:18.027+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 13:51:18.027+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 14448
06-13 13:51:18.048+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 13:51:18.048+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:51:18.048+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:51:18.048+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 13:51:18.048+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:51:18.068+0900 I/abc     (14515): abc
06-13 13:51:18.068+0900 I/CAPI_APPFW_APPLICATION(14515): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:51:18.068+0900 I/CAPI_APPFW_APPLICATION(14515): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:51:18.108+0900 E/TBM     (14515): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:51:18.148+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 14515, appid: org.example.client
06-13 13:51:18.148+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:51:18.168+0900 W/AUL     (14448): launch.c: app_request_to_launchpad(425) > request cmd(0) result(14515)
06-13 13:51:18.318+0900 W/CRASH_MANAGER(14476): worker.c: worker_job(1199) > 0614515636c691497329478
06-13 13:51:19.179+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14515 pgid = 14515
06-13 13:51:19.179+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(14515)
06-13 13:51:19.179+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 14515.
06-13 13:51:19.189+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1505
06-13 13:51:19.229+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:51:19.229+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:51:19.229+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:51:19.229+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 14515
06-13 13:51:19.229+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 14515.
06-13 13:51:19.229+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14515
06-13 13:51:19.229+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 14515
06-13 13:51:19.239+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1506
06-13 13:51:19.309+0900 E/TASK_MGR_LITE(14448): recent_app_viewer.c: on_item_mouse_move(863) > mouse hasn't been pressed!
06-13 13:51:19.309+0900 E/EFL     (14448): ecore_x<14448> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16465527
06-13 13:51:19.459+0900 E/EFL     (14448): ecore_x<14448> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16465671
06-13 13:51:19.459+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:51:19.469+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 13:51:19.469+0900 W/AUL     (14448): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 13:51:19.469+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 13:51:19.469+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 14448
06-13 13:51:19.479+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 13:51:19.479+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:51:19.479+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:51:19.479+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(534) > Candidate is not prepared, enter legacy logic
06-13 13:51:19.479+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:51:19.479+0900 E/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(273) > launching failed
06-13 13:51:19.479+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3063) > Launch with legacy way : no launchpad
06-13 13:51:19.489+0900 W/AUL_AMD (  607): amd_launch.c: start_process(638) > child process: 14617
06-13 13:51:19.539+0900 W/AUL_AMD (  607): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 14617
06-13 13:51:19.539+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 14617, appid: org.example.client
06-13 13:51:19.539+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:51:19.539+0900 W/AUL     (14448): launch.c: app_request_to_launchpad(425) > request cmd(0) result(14617)
06-13 13:51:19.569+0900 I/Tizen::App( 1175): (499) > LaunchedApp(org.example.client)
06-13 13:51:19.569+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for org.example.client, 14617.
06-13 13:51:19.629+0900 I/abc     (14617): abc
06-13 13:51:19.639+0900 I/CAPI_APPFW_APPLICATION(14617): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:51:19.969+0900 I/CAPI_APPFW_APPLICATION(14617): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:51:20.009+0900 E/TBM     (14617): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:51:20.009+0900 I/MALI    (14617): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=14617   open drm_fd=35 
06-13 13:51:20.069+0900 I/UXT     (14613): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 13:51:20.310+0900 W/AUL_AMD (  607): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-13 13:51:20.310+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14617
06-13 13:51:20.310+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 14617
06-13 13:51:20.310+0900 I/Tizen::App( 1175): (243) > App[org.example.client] pid[14617] terminate event is forwarded
06-13 13:51:20.310+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 13:51:20.310+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [org.example.client, 14617, ]
06-13 13:51:20.310+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 13:51:20.310+0900 I/Tizen::App( 1175): (506) > TerminatedApp(org.example.client)
06-13 13:51:20.310+0900 I/Tizen::App( 1175): (512) > Not registered pid(14617)
06-13 13:51:20.310+0900 I/Tizen::System( 1175): (246) > Terminated app [org.example.client]
06-13 13:51:20.310+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 13:51:20.310+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 14617
06-13 13:51:20.330+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 13:51:20.330+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for org.example.client, 14617.
06-13 13:51:22.172+0900 E/EFL     (14448): ecore_x<14448> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16468368
06-13 13:51:22.172+0900 E/EFL     (14448): ecore_x<14448> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16468387
06-13 13:51:22.172+0900 I/TASK_MGR_LITE(14448): task-mgr-lite.c: on_hw_back(132) > Back key and Key down, so call elm_exit()
06-13 13:51:22.172+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:51:22.172+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:51:22.172+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(14448)
06-13 13:51:22.172+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 14448, appid: com.samsung.task-mgr, status: bg
06-13 13:51:22.182+0900 I/CAPI_APPFW_APPLICATION(14448): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 13:51:22.182+0900 W/TASK_MGR_LITE(14448): task-mgr-lite.c: _pause_app(406) > 
06-13 13:51:22.182+0900 I/CAPI_APPFW_APPLICATION(14448): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 13:51:22.182+0900 E/TASK_MGR_LITE(14448): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 13:51:22.192+0900 E/TASK_MGR_LITE(14448): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
06-13 13:51:22.192+0900 E/APP_CORE(14448): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 13:51:22.202+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:51:22.202+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 13:51:22.212+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:51:22.212+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 13:51:22.212+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 13:51:22.212+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 13:51:22.232+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 13:51:22.232+0900 I/MALI    (14448): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=14448   close drm_fd=30 
06-13 13:51:22.272+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 13:51:22.272+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 13:51:22.272+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 13:51:22.272+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:51:22.282+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 13:51:22.282+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 13:51:22.302+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 13:51:22.322+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 13:51:22.342+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 13:51:22.342+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 13:51:22.342+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:22.342+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:22.342+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:22.362+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 13:51:22.372+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:22.372+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 13:51:22.372+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 13:51:22.372+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 13:51:22.372+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 13:51:22.372+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16468497
06-13 13:51:22.372+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 13:51:22.382+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16468580
06-13 13:51:22.382+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 13:51:22.452+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 13:51:22.462+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 13:51:22.542+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14448 pgid = 14448
06-13 13:51:22.542+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(14448)
06-13 13:51:22.572+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:51:22.572+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:51:22.572+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:51:22.582+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 14448
06-13 13:51:22.582+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14448
06-13 13:51:22.582+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 14448
06-13 13:51:22.582+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[14448] terminate event is forwarded
06-13 13:51:22.582+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 13:51:22.582+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 14448, ]
06-13 13:51:22.582+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 13:51:22.582+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 13:51:22.582+0900 I/Tizen::App( 1175): (512) > Not registered pid(14448)
06-13 13:51:22.582+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 13:51:22.582+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 13:51:22.582+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1510
06-13 13:51:22.602+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 13:51:22.602+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 14448.
06-13 13:51:23.052+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16469157
06-13 13:51:23.052+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Menu]Key [Down]Event!! 
06-13 13:51:23.052+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16469265
06-13 13:51:23.052+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Menu]Key [Up]Event!! 
06-13 13:51:23.062+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=normal:weight=light:width=condensed style= shadow_color=#000000 font_size=32 align=center valign=center color=#f9f9f9f9 color_class=tizen text_class=tizen ellipsis=1 wrap=mixed linegap=0'
06-13 13:51:23.082+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=normal:weight=light:width=condensed style= shadow_color=#000000 font_size=32 align=center valign=center color=#f9f9f9ff color_class=tizen text_class=tizen ellipsis=1 wrap=mixed linegap=0'
06-13 13:51:23.092+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=normal:weight=light:width=condensed style= shadow_color=#000000 font_size=32 align=center valign=center color=#f9f9f9ff color_class=tizen text_class=tizen ellipsis=1 wrap=mixed linegap=0'
06-13 13:51:23.102+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=normal:weight=light:width=condensed style= shadow_color=#000000 font_size=32 align=center valign=center color=#f9f9f9ff color_class=tizen text_class=tizen ellipsis=1 wrap=mixed linegap=0'
06-13 13:51:23.112+0900 E/VCONF   ( 1167): vconf.c: _vconf_check_install_key_list(1135) > key : memory/cluster-home/edit-state
06-13 13:51:23.112+0900 E/VCONF   ( 1167): vconf.c: _vconf_check_retry_err(1368) > memory/cluster-home/edit-state : check retry err (-21/2).
06-13 13:51:23.112+0900 E/VCONF   ( 1167): vconf.c: _vconf_set_key_filesys(1573) > _vconf_set_key_filesys(41-memory/cluster-home/edit-state) step(-21) failed(2 / No such file or directory)
06-13 13:51:23.112+0900 E/VCONF   ( 1167): vconf.c: _vconf_set_key(1621) > _vconf_set_key(memory/cluster-home/edit-state) step(-21) failed(2 / No such file or directory)
06-13 13:51:23.112+0900 E/VCONF   ( 1167): vconf.c: vconf_set_int(1717) > vconf_set_int(1167) : memory/cluster-home/edit-state(1) error
06-13 13:51:23.122+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_text_signal_cb(342) > received text signal
06-13 13:51:23.132+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_text_signal_cb(342) > received text signal
06-13 13:51:23.403+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=normal:weight=light:width=condensed style= shadow_color=#000000 font_size=34 align=center valign=center color=#f9f9f9ff color_class=tizen text_class=tizen ellipsis=1 wrap=mixed linegap=0'
06-13 13:51:23.413+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=normal:weight=light:width=condensed style= shadow_color=#000000 font_size=34 align=center valign=center color=#f9f9f964 color_class=tizen text_class=tizen ellipsis=1 wrap=mixed linegap=0'
06-13 13:51:23.413+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=normal:weight=light:width=condensed style= shadow_color=#000000 font_size=34 align=center valign=center color=#f9f9f9ff color_class=tizen text_class=tizen ellipsis=1 wrap=mixed linegap=0'
06-13 13:51:23.423+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=normal:weight=light:width=condensed style= shadow_color=#000000 font_size=34 align=center valign=center color=#f9f9f964 color_class=tizen text_class=tizen ellipsis=1 wrap=mixed linegap=0'
06-13 13:51:23.423+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=normal:weight=light:width=condensed style= shadow_color=#000000 font_size=34 align=center valign=center color=#f9f9f9ff color_class=tizen text_class=tizen ellipsis=1 wrap=mixed linegap=0'
06-13 13:51:23.423+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=normal:weight=light:width=condensed style= shadow_color=#000000 font_size=34 align=center valign=center color=#f9f9f964 color_class=tizen text_class=tizen ellipsis=1 wrap=mixed linegap=0'
06-13 13:51:23.433+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=normal:weight=light:width=condensed style= shadow_color=#000000 font_size=34 align=center valign=center color=#f9f9f9ff color_class=tizen text_class=tizen ellipsis=1 wrap=mixed linegap=0'
06-13 13:51:23.433+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=normal:weight=light:width=condensed style= shadow_color=#000000 font_size=34 align=center valign=center color=#f9f9f964 color_class=tizen text_class=tizen ellipsis=1 wrap=mixed linegap=0'
06-13 13:51:23.443+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=normal:weight=light:width=condensed style= shadow_color=#000000 font_size=34 align=center valign=center color=#f9f9f9ff color_class=tizen text_class=tizen ellipsis=1 wrap=mixed linegap=0'
06-13 13:51:23.443+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=normal:weight=light:width=condensed style= shadow_color=#000000 font_size=34 align=center valign=center color=#f9f9f964 color_class=tizen text_class=tizen ellipsis=1 wrap=mixed linegap=0'
06-13 13:51:23.623+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16469836
06-13 13:51:23.623+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16469836
06-13 13:51:23.623+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 13:51:23.623+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 13:51:23.623+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 13:51:23.933+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 13:51:23.933+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 13:51:23.933+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 13:51:23.933+0900 E/STARTER (  721): )
06-13 13:51:23.933+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 13:51:23.933+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 13:51:23.933+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 13:51:23.943+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
06-13 13:51:23.943+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 13:51:23.953+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 13:51:23.953+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 13:51:23.953+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 13:51:23.953+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 13:51:23.973+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:51:23.973+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:51:23.973+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 13:51:23.973+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:51:24.003+0900 I/GXT_SIB (  342): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 13:51:24.003+0900 E/CAPI_APPFW_APPLICATION(14559): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:51:24.003+0900 E/CAPI_APPFW_APPLICATION(14559): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:51:24.003+0900 E/CAPI_APPFW_APPLICATION(14559): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:51:24.003+0900 E/CAPI_APPFW_APPLICATION(14559): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:51:24.003+0900 E/CAPI_APPFW_APPLICATION(14559): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:51:24.003+0900 I/CAPI_APPFW_APPLICATION(14559): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:51:24.003+0900 I/CAPI_APPFW_APPLICATION(14559): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:51:24.003+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bdc6e9 in class 'Edje_Object'.
06-13 13:51:24.003+0900 E/UXT     (  342): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
06-13 13:51:24.073+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 14559, appid: com.samsung.task-mgr
06-13 13:51:24.073+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:51:24.073+0900 E/RESOURCED(  667): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-13 13:51:24.083+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(14559)
06-13 13:51:24.113+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:51:24.133+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:51:24.153+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:51:24.163+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:51:24.183+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:51:24.204+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:51:24.224+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:51:24.244+0900 W/TASK_MGR_LITE(14559): task-mgr-lite.c: create_win(197) > changeable ui enabled success
06-13 13:51:24.244+0900 I/GXT_SIB (14559): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 13:51:24.244+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:51:24.304+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:51:24.334+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 13:51:24.334+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:51:24.334+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:51:24.334+0900 E/RUA     (14559): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 24, ncols : 5
06-13 13:51:24.334+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:51:24.344+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 13:51:24.344+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 13:51:24.354+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:51:24.404+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 13:51:24.404+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 13:51:24.404+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 13:51:24.444+0900 I/APP_CORE(14559): appcore-efl.c: __do_app(514) > [APP 14559] Event: RESET State: CREATED
06-13 13:51:24.444+0900 I/CAPI_APPFW_APPLICATION(14559): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 13:51:24.454+0900 E/EFL     (14559): edje<14559> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:51:24.454+0900 E/EFL     (14559): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:51:24.454+0900 E/EFL     (14559): edje<14559> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:51:24.454+0900 E/EFL     (14559): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:51:24.454+0900 W/APP_CORE(14559): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000003
06-13 13:51:24.454+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
06-13 13:51:24.574+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(14559) status(0)
06-13 13:51:24.584+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(14559) status(0)
06-13 13:51:24.584+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: PAUSE State: RUNNING
06-13 13:51:24.584+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 13:51:24.584+0900 E/cluster-home( 1167): homescreen.cpp: OnPause(260) >  app pause
06-13 13:51:24.584+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(4)
06-13 13:51:24.584+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(1167)
06-13 13:51:24.584+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: bg
06-13 13:51:24.594+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(14559) status(3)
06-13 13:51:24.594+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:51:24.594+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 13:51:24.594+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(14559)
06-13 13:51:24.594+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 14559, appid: com.samsung.task-mgr, status: fg
06-13 13:51:24.594+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:51:24.604+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 13:51:24.604+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 13:51:24.604+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 13:51:24.604+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 13:51:24.604+0900 I/APP_CORE(14559): appcore-efl.c: __do_app(514) > [APP 14559] Event: RESUME State: CREATED
06-13 13:51:24.624+0900 I/APP_CORE(14559): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-13 13:51:24.624+0900 I/APP_CORE(14559): appcore-efl.c: __do_app(625) > [APP 14559] Initial Launching, call the resume_cb
06-13 13:51:24.624+0900 I/CAPI_APPFW_APPLICATION(14559): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 13:51:24.814+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16471025
06-13 13:51:24.814+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 13:51:24.814+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16471025
06-13 13:51:24.814+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 13:51:24.814+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 13:51:24.814+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 13:51:24.814+0900 E/STARTER (  721): )
06-13 13:51:24.814+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 13:51:24.824+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 13:51:24.824+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 13:51:24.824+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 13:51:25.114+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 13:51:25.114+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 14559.
06-13 13:51:25.225+0900 E/EFL     (14559): ecore_x<14559> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16471428
06-13 13:51:25.225+0900 E/TASK_MGR_LITE(14559): recent_app_viewer.c: on_item_mouse_move(863) > mouse hasn't been pressed!
06-13 13:51:25.305+0900 E/EFL     (14559): ecore_x<14559> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16471516
06-13 13:51:25.615+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:51:25.615+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:51:25.615+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(14559)
06-13 13:51:25.615+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 14559, appid: com.samsung.task-mgr, status: bg
06-13 13:51:25.615+0900 I/CAPI_APPFW_APPLICATION(14559): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 13:51:25.615+0900 W/TASK_MGR_LITE(14559): task-mgr-lite.c: _pause_app(406) > 
06-13 13:51:25.615+0900 I/CAPI_APPFW_APPLICATION(14559): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 13:51:25.615+0900 E/TASK_MGR_LITE(14559): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 13:51:25.615+0900 E/EFL     (14559): eo<14559> lib/eo/eo_ptr_indirection.x:295 _eo_obj_pointer_get() eo_id 0x80031b8e's acvie is  NULL, entry: 0xb332ec88, 0xb7e79790, 0
06-13 13:51:25.615+0900 E/EFL     (14559): eo<14559> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0x80031b8e is not pointing to a valid object. Maybe it has already been freed.
06-13 13:51:25.615+0900 E/EFL     (14559): eo<14559> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x80031b8e) is an invalid ref.
06-13 13:51:25.635+0900 E/TASK_MGR_LITE(14559): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
06-13 13:51:25.635+0900 E/APP_CORE(14559): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 13:51:25.645+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:51:25.665+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 13:51:25.665+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:51:25.665+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 13:51:25.665+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 13:51:25.665+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 13:51:25.685+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 13:51:25.685+0900 I/MALI    (14559): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=14559   close drm_fd=30 
06-13 13:51:25.725+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 13:51:25.725+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 13:51:25.725+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 13:51:25.735+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:51:25.765+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 13:51:25.765+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 13:51:25.765+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 13:51:25.775+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 13:51:25.785+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16471991
06-13 13:51:25.795+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 13:51:25.795+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 13:51:25.795+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:25.795+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:25.795+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:25.815+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 13:51:25.815+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:25.815+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 13:51:25.815+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 13:51:25.815+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 13:51:25.815+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 13:51:25.835+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16472046
06-13 13:51:25.925+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 13:51:25.925+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 13:51:26.055+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14559 pgid = 14559
06-13 13:51:26.055+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(14559)
06-13 13:51:26.105+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:51:26.105+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:51:26.105+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:51:26.115+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[14559] terminate event is forwarded
06-13 13:51:26.115+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 13:51:26.115+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 14559, ]
06-13 13:51:26.115+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 13:51:26.115+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 13:51:26.115+0900 I/Tizen::App( 1175): (512) > Not registered pid(14559)
06-13 13:51:26.115+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 13:51:26.115+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 13:51:26.115+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 14559
06-13 13:51:26.115+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14559
06-13 13:51:26.115+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 14559
06-13 13:51:26.115+0900 W/CRASH_MANAGER(14476): worker.c: worker_job(1199) > 0614617636c69149732948
