S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 15295
Date: 2017-06-13 13:59:31+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 4
      (SIGILL)
      si_code: 1
      illegal opcode
      si_addr: 0xb6edb65a

Register Information
r0   = 0xb8889348, r1   = 0xb8886360
r2   = 0xb8886360, r3   = 0xb8889348
r4   = 0xb6e1da3c, r5   = 0xbee623fc
r6   = 0x00000001, r7   = 0xbee622c0
r8   = 0xbee623f0, r9   = 0xb863aaf0
r10  = 0xbee62410, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbee62264
lr   = 0xb6edb5d7, pc   = 0xb6edb65a
cpsr = 0x40070030

Memory Information
MemTotal:   987012 KB
MemFree:     63368 KB
Buffers:     61220 KB
Cached:     225644 KB
VmPeak:      99356 KB
VmSize:      99352 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17836 KB
VmRSS:       17836 KB
VmData:      38412 KB
VmStk:         136 KB
VmExe:         192 KB
VmLib:       30368 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 15295 TID = 15295
15295 15301 15310 15311 15312 

Maps Information
b1270000 b1278000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b128a000 b1a89000 rw-p [stack:15312]
b1a89000 b1a96000 r-xp /usr/lib/libmdm-common.so.1.0.98
b1aa7000 b1ae8000 r-xp /usr/lib/libmdm.so.1.2.12
b1af8000 b1b00000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b1b0f000 b1b1f000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b1b40000 b1ba0000 r-xp /usr/lib/libasound.so.2.0.0
b1bb2000 b1bb5000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b1bc5000 b1bc8000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b1bd8000 b1bdd000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b1bed000 b1bee000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b1bfe000 b1c09000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b1c1d000 b1c22000 r-xp /usr/lib/libmmfsession.so.0.0.1
b1c32000 b1c4d000 r-xp /usr/lib/libmmfsound.so.0.1.0
b1c5d000 b1c64000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b1c74000 b1c7e000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b1c8e000 b1c90000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b1ca0000 b1ca1000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b1cb1000 b1cb9000 r-xp /usr/lib/libfeedback.so.0.1.4
b1ce1000 b1ce2000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1cf2000 b1d06000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1eb1000 b1eb7000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b1ec8000 b26c7000 rw-p [stack:15311]
b26c7000 b2822000 r-xp /usr/lib/egl/libMali.so
b2837000 b28c0000 r-xp /usr/lib/evas/modules/engines/gl_generic/v-1.13/module.so
b28d8000 b28e2000 r-xp /usr/lib/evas/modules/engines/gl_x11/v-1.13/module.so
b28f3000 b28ff000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2911000 b3110000 rw-p [stack:15310]
b3441000 b344b000 r-xp /lib/libnss_files-2.20-2014.11.so
b345c000 b3465000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3476000 b3487000 r-xp /lib/libnsl-2.20-2014.11.so
b349a000 b34a0000 r-xp /lib/libnss_compat-2.20-2014.11.so
b34b1000 b34b5000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b34c6000 b35a9000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b35e0000 b3608000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b361a000 b3e19000 rw-p [stack:15301]
b3e19000 b3e1b000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3e2b000 b3f09000 r-xp /usr/lib/libCOREGL.so.4.0
b3f28000 b3f2b000 r-xp /lib/libattr.so.1.1.0
b3f3c000 b3f43000 r-xp /lib/libcrypt-2.20-2014.11.so
b3f7b000 b3f7e000 r-xp /lib/libcap.so.2.21
b3f8e000 b3f90000 r-xp /usr/lib/libiri.so
b3fa0000 b3fc0000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3fc2000 b3fc5000 r-xp /usr/lib/libuuid.so.1.3.0
b3fd5000 b3fec000 r-xp /usr/lib/libblkid.so.1.1.0
b3ffd000 b4026000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4037000 b407e000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b408f000 b4095000 r-xp /usr/lib/libjson-c.so.2.0.1
b40a7000 b40ab000 r-xp /usr/lib/libogg.so.0.7.1
b40bb000 b40dd000 r-xp /usr/lib/libvorbis.so.0.4.3
b40ed000 b41d1000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b41ed000 b41f8000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4208000 b420b000 r-xp /usr/lib/libEGL.so.1.4
b421c000 b4222000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4232000 b4234000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4244000 b4251000 r-xp /usr/lib/libGLESv2.so.2.0
b4262000 b427a000 r-xp /usr/lib/libmount.so.1.1.0
b428c000 b428e000 r-xp /usr/lib/libXau.so.6.0.0
b429e000 b42d4000 r-xp /usr/lib/libpulse.so.0.16.2
b42e5000 b4328000 r-xp /usr/lib/libsndfile.so.1.0.25
b433d000 b43b7000 r-xp /usr/lib/libgcrypt.so.20.0.3
b43cc000 b43d3000 r-xp /usr/lib/libsensord-share.so
b43e4000 b4446000 r-xp /usr/lib/libpixman-1.so.0.28.2
b445b000 b445e000 r-xp /usr/lib/libXv.so.1.0.0
b446e000 b4473000 r-xp /usr/lib/libutilX.so.1.1.0
b4483000 b4488000 r-xp /usr/lib/libffi.so.6.0.2
b4498000 b44a9000 r-xp /lib/libresolv-2.20-2014.11.so
b44be000 b44c0000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b44d0000 b44e5000 r-xp /lib/libexpat.so.1.5.2
b44f7000 b45b5000 r-xp /usr/lib/libcairo.so.2.11200.14
b45c8000 b45d0000 r-xp /usr/lib/libdrm.so.2.4.0
b45e1000 b45e4000 r-xp /usr/lib/libdri2.so.0.0.0
b45f4000 b4642000 r-xp /usr/lib/libssl.so.1.0.0
b4657000 b4663000 r-xp /usr/lib/libeeze.so.1.13.0
b4673000 b467c000 r-xp /usr/lib/libethumb.so.1.13.0
b468d000 b4690000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46a0000 b4857000 r-xp /usr/lib/libcrypto.so.1.0.0
b5641000 b564a000 r-xp /usr/lib/libXi.so.6.1.0
b565b000 b565d000 r-xp /usr/lib/libXgesture.so.7.0.0
b566d000 b5671000 r-xp /usr/lib/libXtst.so.6.1.0
b5681000 b5687000 r-xp /usr/lib/libXrender.so.1.3.0
b5697000 b569d000 r-xp /usr/lib/libXrandr.so.2.2.0
b56ad000 b56af000 r-xp /usr/lib/libXinerama.so.1.0.0
b56bf000 b56c2000 r-xp /usr/lib/libXfixes.so.3.1.0
b56d3000 b56de000 r-xp /usr/lib/libXext.so.6.4.0
b56ee000 b56f0000 r-xp /usr/lib/libXdamage.so.1.1.0
b5700000 b5702000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5712000 b5719000 r-xp /usr/lib/libXcursor.so.1.0.2
b5729000 b5741000 r-xp /usr/lib/libudev.so.1.6.0
b5744000 b5758000 r-xp /usr/lib/libxcb.so.1.1.0
b5768000 b576a000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b577a000 b5781000 r-xp /usr/lib/libembryo.so.1.13.0
b5791000 b579b000 r-xp /usr/lib/libecore_audio.so.1.13.0
b57ac000 b57c4000 r-xp /lib/libz.so.1.2.8
b57d5000 b5811000 r-xp /usr/lib/libsystemd.so.0.4.0
b5813000 b582b000 r-xp /usr/lib/libsensor.so.1.1.0
b583c000 b5843000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b5853000 b585a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b586c000 b586e000 r-xp /usr/lib/libappsvc.so.0.1.0
b587e000 b5881000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5891000 b58aa000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b58bb000 b58f2000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b5903000 b59ee000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b5a01000 b5a7a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b5a8c000 b5a96000 r-xp /usr/lib/libvconf.so.0.2.45
b5aa6000 b5aa8000 r-xp /usr/lib/libvasum.so.0.3.1
b5ab8000 b5abc000 r-xp /usr/lib/libsmack.so.1.0.0
b5acc000 b5ad1000 r-xp /usr/lib/libxdgmime.so.1.1.0
b5ae2000 b5b0c000 r-xp /usr/lib/libdbus-1.so.3.8.12
b5b1d000 b5b34000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b5b45000 b5b48000 r-xp /usr/lib/libbundle.so.0.1.22
b5b58000 b5b70000 r-xp /usr/lib/libpng12.so.0.50.0
b5b81000 b5ba4000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bc5000 b5bd9000 r-xp /usr/lib/libector.so.1.13.0
b5bea000 b5c02000 r-xp /usr/lib/liblua-5.1.so
b5c13000 b5c6a000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c7e000 b5ca6000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cb7000 b5cca000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cdb000 b5d15000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d26000 b5d34000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d44000 b5d4c000 r-xp /usr/lib/libtbm.so.1.0.0
b5d5c000 b5d69000 r-xp /usr/lib/libeio.so.1.13.0
b5d79000 b5d7b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d8b000 b5d90000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5da0000 b5db7000 r-xp /usr/lib/libefreet.so.1.13.0
b5dc9000 b5de9000 r-xp /usr/lib/libeldbus.so.1.13.0
b5df9000 b5e19000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e1b000 b5e21000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e31000 b5e42000 r-xp /usr/lib/libemotion.so.1.13.0
b5e53000 b5e5a000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e6a000 b5e7c000 r-xp /usr/lib/libecore_input.so.1.13.0
b5e8d000 b5e92000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ea2000 b5ebb000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ecb000 b5ee8000 r-xp /usr/lib/libeet.so.1.13.0
b5f01000 b5f11000 r-xp /usr/lib/libefl.so.1.13.0
b5f22000 b6007000 r-xp /usr/lib/libicuuc.so.51.1
b6024000 b6164000 r-xp /usr/lib/libicui18n.so.51.1
b617b000 b61b3000 r-xp /usr/lib/libecore_x.so.1.13.0
b61c5000 b61c7000 r-xp /usr/lib/libttrace.so.1.1
b61d7000 b62b9000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b62ca000 b63ac000 r-xp /usr/lib/libX11.so.6.3.0
b63bf000 b63ce000 r-xp /usr/lib/libeo.so.1.13.0
b63df000 b6462000 r-xp /usr/lib/libedje.so.1.13.0
b6475000 b6493000 r-xp /usr/lib/libecore.so.1.13.0
b64b3000 b6588000 r-xp /usr/lib/libxml2.so.2.9.2
b659d000 b65a0000 r-xp /usr/lib/libiniparser.so.0
b65b0000 b65f8000 r-xp /usr/lib/libeina.so.1.13.0
b6609000 b660e000 r-xp /usr/lib/libappcore-common.so.1.1
b661e000 b6623000 r-xp /usr/lib/libappcore-efl.so.1.1
b6633000 b6638000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6649000 b666f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b667f000 b6697000 r-xp /usr/lib/libaul.so.0.1.0
b66a9000 b6714000 r-xp /lib/libm-2.20-2014.11.so
b6725000 b672b000 r-xp /lib/librt-2.20-2014.11.so
b673c000 b673e000 r-xp /lib/libdl-2.20-2014.11.so
b674f000 b675c000 r-xp /usr/lib/libunwind.so.8.0.1
b6792000 b67ab000 r-xp /lib/libgcc_s-4.9.so.1
b67bb000 b68df000 r-xp /lib/libc-2.20-2014.11.so
b68f4000 b698f000 r-xp /usr/lib/libstdc++.so.6.0.20
b69ab000 b6b32000 r-xp /usr/lib/libevas.so.1.13.0
b6b67000 b6d9b000 r-xp /usr/lib/libelementary.so.1.13.0
b6dca000 b6dd1000 r-xp /usr/lib/libefl-extension.so.0.1.0
b6de2000 b6de4000 r-xp /usr/lib/libdlog.so.0.0.0
b6df4000 b6df9000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6e09000 b6e0d000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6e1e000 b6e20000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b6e31000 b6e45000 r-xp /lib/libpthread-2.20-2014.11.so
b6e71000 b6e7e000 r-xp /usr/lib/liblptcp.so
b6e90000 b6e94000 r-xp /usr/lib/libsys-assert.so
b6ea5000 b6ec5000 r-xp /lib/ld-2.20-2014.11.so
b6ed6000 b6f06000 r-xp /opt/usr/apps/org.example.client/bin/client
b862d000 b88d8000 rw-p [heap]
bee42000 bee63000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15295)
Call Stack Count: 12
 0: $d.51 + 0x0 (0xb6edb65a) [/opt/usr/apps/org.example.client/bin/client] + 0x565a
 1:  + 0x0 (0xb6edb5d7) [/opt/usr/apps/org.example.client/bin/client] + 0x55d7
 2: _ZN8MyWindow8onCreateEv + 0x118 (0xb6edb3a9) [/opt/usr/apps/org.example.client/bin/client] + 0x53a9
 3: _ZN6Window10app_createEPv + 0x72 (0xb6ef45db) [/opt/usr/apps/org.example.client/bin/client] + 0x1e5db
 4: _ZN6Window17static_app_createEPv + 0x24 (0xb6ef4751) [/opt/usr/apps/org.example.client/bin/client] + 0x1e751
 5: (0xb6e0b4f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 6: appcore_efl_main + 0x152 (0xb6621203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 7: ui_app_main + 0xc0 (0xb6e0b909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
 8: _ZN6Window10makeWindowEiPPc + 0x11e (0xb6ef4adb) [/opt/usr/apps/org.example.client/bin/client] + 0x1eadb
 9: main + 0x40 (0xb6edb129) [/opt/usr/apps/org.example.client/bin/client] + 0x5129
10: __libc_start_main + 0x114 (0xb67d14bc) [/lib/libc.so.6] + 0x164bc
11: (0xb6edaf60) [/opt/usr/apps/org.example.client/bin/client] + 0x4f60
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
o, ret: -1
06-13 13:59:19.367+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 15188
06-13 13:59:19.367+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 13:59:19.377+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 13:59:19.377+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:59:19.377+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:59:19.377+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 13:59:19.377+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:59:19.397+0900 I/abc     (14613): abc
06-13 13:59:19.397+0900 I/CAPI_APPFW_APPLICATION(14613): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:59:19.397+0900 I/CAPI_APPFW_APPLICATION(14613): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:59:19.427+0900 E/TBM     (14613): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:59:19.477+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 14613, appid: org.example.client
06-13 13:59:19.477+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:59:19.487+0900 W/AUL     (15188): launch.c: app_request_to_launchpad(425) > request cmd(0) result(14613)
06-13 13:59:19.878+0900 W/CRASH_MANAGER(15203): worker.c: worker_job(1199) > 0414613636c691497329959
06-13 13:59:20.478+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:59:20.478+0900 W/AUL_AMD (  607): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-13 13:59:20.508+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14613 pgid = 14613
06-13 13:59:20.508+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(14613)
06-13 13:59:20.508+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 14613.
06-13 13:59:20.518+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1547
06-13 13:59:20.568+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:59:20.568+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:59:20.568+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:59:20.568+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 14613.
06-13 13:59:20.568+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 14613
06-13 13:59:20.568+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14613
06-13 13:59:20.568+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 14613
06-13 13:59:20.588+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1548
06-13 13:59:21.399+0900 I/UXT     (15215): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 13:59:24.902+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16951116
06-13 13:59:24.902+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 13:59:24.902+0900 E/EFL     (14656): ecore_x<14656> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16951116
06-13 13:59:24.902+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 13:59:25.083+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16951291
06-13 13:59:25.083+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 13:59:25.083+0900 E/EFL     (14656): ecore_x<14656> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16951291
06-13 13:59:25.083+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 13:59:25.083+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 13:59:25.083+0900 E/STARTER (  721): )
06-13 13:59:25.083+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 13:59:25.083+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 13:59:25.083+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 13:59:25.083+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 13:59:25.283+0900 W/STARTER (  721): hw_key.c: _homekey_timer_cb(479) > [_homekey_timer_cb:479] _homekey_timer_cb, homekey count[1], lock state[0]
06-13 13:59:25.293+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 13:59:25.293+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 13:59:25.293+0900 E/STARTER (  721): )
06-13 13:59:25.293+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:59:25.293+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 1167
06-13 13:59:25.293+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.homescreen)
06-13 13:59:25.303+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 13:59:25.303+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 13:59:25.303+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 13:59:25.303+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 13:59:25.303+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 13:59:25.313+0900 W/AUL     (  607): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1167, appid: com.samsung.homescreen
06-13 13:59:25.313+0900 W/AUL_AMD (  607): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 0, pid: 1167
06-13 13:59:25.313+0900 W/AUL_AMD (  607): amd_request.c: __send_home_launch_signal(577) > send a home launch signal
06-13 13:59:25.313+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESET State: PAUSED
06-13 13:59:25.313+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 13:59:25.313+0900 W/AUL_AMD (  607): amd_launch.c: __reply_handler(1083) > listen fd(32) , send fd(31), pid(1167), cmd(0)
06-13 13:59:25.313+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(1167)
06-13 13:59:25.313+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 13:59:25.313+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 13:59:25.313+0900 E/STARTER (  721): dbus-util.c: starter_dbus_home_raise_signal_send(219) > [starter_dbus_home_raise_signal_send:219] Sending HOME RAISE signal, result:0
06-13 13:59:25.323+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 13:59:25.323+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-13 13:59:25.323+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 13:59:25.323+0900 W/CAPI_APPFW_APP_CONTROL( 1167): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-13 13:59:25.333+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(564) > Legacy lifecycle: 0
06-13 13:59:25.333+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(566) > [APP 1167] App already running, raise the window
06-13 13:59:25.343+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 13:59:25.343+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:59:25.343+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 13:59:25.343+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 13:59:25.343+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 13:59:25.363+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-13 13:59:25.403+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:59:25.403+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:59:25.423+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 13:59:25.423+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 13:59:25.423+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 13:59:25.423+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 13:59:25.423+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 13:59:25.433+0900 I/APP_CORE(14656): appcore-efl.c: __do_app(514) > [APP 14656] Event: PAUSE State: RUNNING
06-13 13:59:25.433+0900 I/CAPI_APPFW_APPLICATION(14656): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 13:59:25.433+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(14656) status(4)
06-13 13:59:25.433+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.myfile-lite(14656)
06-13 13:59:25.433+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 14656, appid: com.samsung.myfile-lite, status: bg
06-13 13:59:25.443+0900 I/TIZEN_N_SOUND_MANAGER(  910): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=8, ret=0x0
06-13 13:59:25.443+0900 E/TIZEN_N_SOUND_MANAGER(  910): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-13 13:59:25.443+0900 I/TIZEN_N_SOUND_MANAGER(  910): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-13 13:59:25.443+0900 E/TIZEN_N_SOUND_MANAGER(  910): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-13 13:59:25.443+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 13:59:25.463+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 13:59:25.473+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 13:59:25.473+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 13:59:25.473+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:59:25.473+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:59:25.473+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:59:25.483+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 13:59:25.483+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:59:25.483+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 13:59:25.483+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 13:59:25.483+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 13:59:25.483+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 13:59:25.563+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 13:59:25.563+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 13:59:25.563+0900 I/TIZEN_N_EFL_UTIL_WINDOW(14656): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 134
06-13 13:59:25.563+0900 E/APP_CORE(14656): appcore-efl.c: _capture_and_make_file(1619) > win[3200003] widget[720] height[1280]
06-13 13:59:25.563+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
06-13 13:59:25.893+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16952107
06-13 13:59:25.893+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16952107
06-13 13:59:25.893+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 13:59:25.893+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 13:59:25.893+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 13:59:26.204+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 13:59:26.204+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 13:59:26.204+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 13:59:26.204+0900 E/STARTER (  721): )
06-13 13:59:26.204+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 13:59:26.204+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 13:59:26.204+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 13:59:26.214+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
06-13 13:59:26.214+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 13:59:26.224+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 13:59:26.224+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 13:59:26.224+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 13:59:26.224+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 13:59:26.244+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:59:26.244+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:59:26.244+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 13:59:26.244+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:59:26.254+0900 E/TBM     (  262): tbm_bufmgr.c: tbm_bo_export(1407) > [tbm_bo_export] : '_tbm_bo_is_valid(bo)' failed.
06-13 13:59:26.264+0900 I/GXT_SIB (  342): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 13:59:26.264+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bdc6e9 in class 'Edje_Object'.
06-13 13:59:26.264+0900 E/UXT     (  342): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
06-13 13:59:26.264+0900 E/CAPI_APPFW_APPLICATION(14899): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:59:26.264+0900 E/CAPI_APPFW_APPLICATION(14899): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:59:26.264+0900 E/CAPI_APPFW_APPLICATION(14899): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:59:26.264+0900 E/CAPI_APPFW_APPLICATION(14899): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:59:26.264+0900 E/CAPI_APPFW_APPLICATION(14899): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:59:26.264+0900 I/CAPI_APPFW_APPLICATION(14899): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:59:26.274+0900 I/CAPI_APPFW_APPLICATION(14899): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:59:26.344+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 14899, appid: com.samsung.task-mgr
06-13 13:59:26.344+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:59:26.344+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(14899)
06-13 13:59:26.354+0900 E/RESOURCED(  667): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-13 13:59:26.394+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.404+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.424+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.444+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.454+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.474+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.494+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.494+0900 W/TASK_MGR_LITE(14899): task-mgr-lite.c: create_win(197) > changeable ui enabled success
06-13 13:59:26.494+0900 I/GXT_SIB (14899): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 13:59:26.544+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.554+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:59:26.554+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:59:26.564+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 13:59:26.564+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 13:59:26.564+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 13:59:26.564+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 13:59:26.574+0900 E/RUA     (14899): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 25, ncols : 5
06-13 13:59:26.574+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.574+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:59:26.584+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.584+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 13:59:26.584+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 13:59:26.584+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:59:26.584+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 14656
06-13 13:59:26.584+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 13:59:26.594+0900 E/TASK_MGR_LITE(14899): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 13:59:26.594+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.604+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.654+0900 I/APP_CORE(14899): appcore-efl.c: __do_app(514) > [APP 14899] Event: RESET State: CREATED
06-13 13:59:26.654+0900 I/CAPI_APPFW_APPLICATION(14899): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 13:59:26.654+0900 E/EFL     (14899): edje<14899> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:59:26.654+0900 E/EFL     (14899): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:59:26.654+0900 E/EFL     (14899): edje<14899> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:59:26.654+0900 E/EFL     (14899): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:59:26.664+0900 W/APP_CORE(14899): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800003
06-13 13:59:26.664+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
06-13 13:59:26.764+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16952974
06-13 13:59:26.764+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16952974
06-13 13:59:26.764+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 13:59:26.764+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 13:59:26.764+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 13:59:26.764+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 13:59:26.764+0900 E/STARTER (  721): )
06-13 13:59:26.774+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 13:59:26.774+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 13:59:26.774+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 13:59:26.774+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 13:59:26.834+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(14899) status(0)
06-13 13:59:26.834+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(14899) status(0)
06-13 13:59:26.834+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: PAUSE State: RUNNING
06-13 13:59:26.834+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 13:59:26.834+0900 E/cluster-home( 1167): homescreen.cpp: OnPause(260) >  app pause
06-13 13:59:26.834+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(4)
06-13 13:59:26.834+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(1167)
06-13 13:59:26.834+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: bg
06-13 13:59:26.844+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(14899) status(3)
06-13 13:59:26.844+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:59:26.844+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 13:59:26.844+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 13:59:26.844+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(14899)
06-13 13:59:26.844+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 14899, appid: com.samsung.task-mgr, status: fg
06-13 13:59:26.854+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 13:59:26.854+0900 I/APP_CORE(14899): appcore-efl.c: __do_app(514) > [APP 14899] Event: RESUME State: CREATED
06-13 13:59:26.854+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 13:59:26.854+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 13:59:26.854+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 13:59:26.864+0900 I/APP_CORE(14899): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-13 13:59:26.864+0900 I/APP_CORE(14899): appcore-efl.c: __do_app(625) > [APP 14899] Initial Launching, call the resume_cb
06-13 13:59:26.864+0900 I/CAPI_APPFW_APPLICATION(14899): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 13:59:27.395+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 13:59:27.395+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 14899.
06-13 13:59:27.405+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1552
06-13 13:59:27.675+0900 E/EFL     (14899): ecore_x<14899> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16953881
06-13 13:59:27.765+0900 E/EFL     (14899): ecore_x<14899> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16953969
06-13 13:59:28.246+0900 I/UXT     (15248): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 13:59:28.266+0900 E/EFL     (14899): ecore_x<14899> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16954477
06-13 13:59:28.266+0900 E/TASK_MGR_LITE(14899): recent_app_viewer.c: on_item_mouse_move(863) > mouse hasn't been pressed!
06-13 13:59:28.286+0900 E/TBM     (15248): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:59:28.286+0900 I/MALI    (15248): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=15248   open drm_fd=30 
06-13 13:59:28.386+0900 E/EFL     (14899): ecore_x<14899> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16954599
06-13 13:59:28.396+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:59:28.396+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 14656
06-13 13:59:28.396+0900 W/AUL     (14899): launch.c: app_request_to_launchpad(396) > request cmd(4) to(14656)
06-13 13:59:28.396+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 4
06-13 13:59:28.396+0900 I/APP_CORE(14656): appcore-efl.c: __do_app(514) > [APP 14656] Event: TERMINATE State: PAUSED
06-13 13:59:28.396+0900 W/AUL_AMD (  607): amd_launch.c: __reply_handler(1083) > listen fd(32) , send fd(31), pid(14656), cmd(4)
06-13 13:59:28.396+0900 W/AUL     (14899): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
06-13 13:59:28.396+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:59:28.396+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:59:28.396+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:59:28.396+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:59:28.406+0900 I/TIZEN_N_EFL_UTIL_WINDOW(14656): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 11
06-13 13:59:28.406+0900 E/APP_CORE(14656): appcore-efl.c: _capture_and_make_file(1619) > win[3200003] widget[720] height[1280]
06-13 13:59:28.406+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
06-13 13:59:28.406+0900 E/APP_CORE(14656): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [com.samsung.myfile-lite]
06-13 13:59:28.416+0900 I/CAPI_APPFW_APPLICATION(14656): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 13:59:28.416+0900 I/CAPI_CONTENT_MEDIA_CONTENT(14656): media_content.c: media_content_disconnect(940) > [32m[14656]ref count changed to: 0
06-13 13:59:28.426+0900 E/EFL     (15248): edje<15248> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:59:28.426+0900 E/EFL     (15248): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:59:28.426+0900 E/EFL     (15248): edje<15248> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:59:28.426+0900 E/EFL     (15248): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:59:28.426+0900 E/EFL     (15248): edje<15248> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:59:28.426+0900 E/EFL     (15248): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:59:28.426+0900 E/CLOUD_CONTENT_SYNC_CLIENT(14656): cs_client.c: cloud_content_sync_folder_unset_changed_cb(3749) > [0;31m* Critical * Invalid handle[0;m
06-13 13:59:28.426+0900 E/CLOUD_CONTENT_SYNC_CLIENT(14656): cs_client.c: cloud_content_sync_content_unset_changed_cb(3662) > [0;31m* Critical * Invalid handle[0;m
06-13 13:59:28.426+0900 W/MYFILES (14656): mf-cloud-service.c: mf_cloud_content_destroy_handle(61) > handle is NULL
06-13 13:59:28.426+0900 E/MYFILES (14656): mf-cloud-operation.c: mf_cloud_operation_src_list_free(147) > [31mmore is [0][0m
06-13 13:59:28.426+0900 E/EFL     (14656): <14656> e_dbus.c:640 e_dbus_shutdown() Init count not greater than 0 in shutdown.
06-13 13:59:28.536+0900 I/MALI    (14656): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=14656   close drm_fd=30 
06-13 13:59:28.786+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14656 pgid = 14656
06-13 13:59:28.786+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(14656)
06-13 13:59:28.816+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:59:28.816+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:59:28.816+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:59:28.816+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 14656
06-13 13:59:28.816+0900 I/Tizen::App( 1175): (243) > App[com.samsung.myfile-lite] pid[14656] terminate event is forwarded
06-13 13:59:28.816+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 13:59:28.816+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.myfile-lite, 14656, ]
06-13 13:59:28.816+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 13:59:28.816+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.myfile-lite)
06-13 13:59:28.816+0900 I/Tizen::App( 1175): (512) > Not registered pid(14656)
06-13 13:59:28.816+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.myfile-lite]
06-13 13:59:28.816+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 13:59:28.816+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14656
06-13 13:59:28.816+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1555
06-13 13:59:28.826+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 13:59:28.826+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.myfile-lite, 14656.
06-13 13:59:28.856+0900 E/EFL     (14899): ecore_x<14899> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16955060
06-13 13:59:28.926+0900 E/EFL     (14899): ecore_x<14899> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16955137
06-13 13:59:28.936+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:59:28.936+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 13:59:28.936+0900 W/AUL     (14899): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 13:59:28.946+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 13:59:28.946+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 14899
06-13 13:59:28.956+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 13:59:28.956+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:59:28.956+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:59:28.956+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 13:59:28.956+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:59:28.976+0900 I/abc     (15215): abc
06-13 13:59:28.976+0900 I/CAPI_APPFW_APPLICATION(15215): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:59:28.976+0900 I/CAPI_APPFW_APPLICATION(15215): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:59:29.006+0900 E/TBM     (15215): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:59:29.057+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 15215, appid: org.example.client
06-13 13:59:29.057+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:59:29.077+0900 W/AUL     (14899): launch.c: app_request_to_launchpad(425) > request cmd(0) result(15215)
06-13 13:59:29.377+0900 W/CRASH_MANAGER(15203): worker.c: worker_job(1199) > 0415215636c691497329969
06-13 13:59:30.108+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 15215 pgid = 15215
06-13 13:59:30.108+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(15215)
06-13 13:59:30.108+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 15215.
06-13 13:59:30.118+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1556
06-13 13:59:30.158+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:59:30.158+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:59:30.158+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:59:30.168+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 15215.
06-13 13:59:30.168+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 15215
06-13 13:59:30.168+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 15215
06-13 13:59:30.168+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 15215
06-13 13:59:30.168+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1557
06-13 13:59:30.608+0900 E/TASK_MGR_LITE(14899): recent_app_viewer.c: on_item_mouse_move(863) > mouse hasn't been pressed!
06-13 13:59:30.608+0900 E/EFL     (14899): ecore_x<14899> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16956828
06-13 13:59:30.718+0900 E/EFL     (14899): ecore_x<14899> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16956938
06-13 13:59:30.728+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:59:30.728+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 13:59:30.728+0900 W/AUL     (14899): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 13:59:30.728+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 13:59:30.738+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 14899
06-13 13:59:30.748+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 13:59:30.748+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:59:30.748+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:59:30.748+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(534) > Candidate is not prepared, enter legacy logic
06-13 13:59:30.748+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:59:30.748+0900 E/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(273) > launching failed
06-13 13:59:30.748+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3063) > Launch with legacy way : no launchpad
06-13 13:59:30.748+0900 W/AUL_AMD (  607): amd_launch.c: start_process(638) > child process: 15295
06-13 13:59:30.798+0900 W/AUL_AMD (  607): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 15295
06-13 13:59:30.798+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 15295, appid: org.example.client
06-13 13:59:30.798+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:59:30.808+0900 W/AUL     (14899): launch.c: app_request_to_launchpad(425) > request cmd(0) result(15295)
06-13 13:59:30.818+0900 I/Tizen::App( 1175): (499) > LaunchedApp(org.example.client)
06-13 13:59:30.818+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for org.example.client, 15295.
06-13 13:59:30.888+0900 I/abc     (15295): abc
06-13 13:59:30.898+0900 I/CAPI_APPFW_APPLICATION(15295): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:59:31.079+0900 I/UXT     (15290): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 13:59:31.209+0900 I/CAPI_APPFW_APPLICATION(15295): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:59:31.249+0900 E/TBM     (15295): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:59:31.249+0900 I/MALI    (15295): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=15295   open drm_fd=35 
06-13 13:59:31.659+0900 W/AUL_AMD (  607): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-13 13:59:31.659+0900 I/Tizen::App( 1175): (243) > App[org.example.client] pid[15295] terminate event is forwarded
06-13 13:59:31.659+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 13:59:31.659+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [org.example.client, 15295, ]
06-13 13:59:31.659+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 13:59:31.659+0900 I/Tizen::App( 1175): (506) > TerminatedApp(org.example.client)
06-13 13:59:31.659+0900 I/Tizen::App( 1175): (512) > Not registered pid(15295)
06-13 13:59:31.659+0900 I/Tizen::System( 1175): (246) > Terminated app [org.example.client]
06-13 13:59:31.659+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 13:59:31.659+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 15295
06-13 13:59:31.659+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 15295
06-13 13:59:31.659+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 15295
06-13 13:59:31.669+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 13:59:31.669+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for org.example.client, 15295.
06-13 13:59:31.779+0900 E/EFL     (  607): ecore_x<607> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16957991
06-13 13:59:31.829+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: MEM_FLUSH State: PAUSED
06-13 13:59:33.391+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 13:59:33.391+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 13:59:35.483+0900 E/EFL     (14899): ecore_x<14899> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16961690
06-13 13:59:35.543+0900 E/EFL     (14899): ecore_x<14899> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16961756
06-13 13:59:35.723+0900 E/AUL_AMD (  607): amd_launch.c: _amd_proc_find_proc_info(1914) > proc info not found
06-13 13:59:35.913+0900 E/EFL     (14899): ecore_x<14899> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16962127
06-13 13:59:35.953+0900 W/CRASH_MANAGER(15203): worker.c: worker_job(1199) > 0415295636c69149732997
