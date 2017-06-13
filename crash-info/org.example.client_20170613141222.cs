S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 19559
Date: 2017-06-13 14:12:22+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 19559, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00004c67
r2   = 0x00000006, r3   = 0xb40924c0
r4   = 0x00000002, r5   = 0xb4092000
r6   = 0xb678c09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb7a262a8
r10  = 0xbeeb9498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbeeb90dc
lr   = 0xb6682f18, pc   = 0xb6681b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     53620 KB
Buffers:     65384 KB
Cached:     240040 KB
VmPeak:      98668 KB
VmSize:      98664 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19636 KB
VmRSS:       19636 KB
VmData:      30212 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35772 KB
VmPTE:          74 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 19559 TID = 19559
19559 19563 19571 19572 

Maps Information
b135b000 b1363000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1375000 b1b74000 rw-p [stack:19572]
b1b74000 b1b75000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b85000 b1b99000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bad000 b1bae000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bbe000 b1bc1000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bd2000 b1bd3000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1be3000 b1be5000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bf5000 b1bf7000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c07000 b1c17000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c27000 b1c33000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c45000 b2444000 rw-p [stack:19571]
b2775000 b277c000 r-xp /usr/lib/libefl-extension.so.0.1.0
b278f000 b2795000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27a5000 b27d5000 r-xp /opt/usr/apps/org.example.client/bin/client
b291e000 b2a01000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a38000 b2a60000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a72000 b3271000 rw-p [stack:19563]
b3271000 b3273000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3283000 b328d000 r-xp /lib/libnss_files-2.20-2014.11.so
b329e000 b32a7000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32b8000 b32c9000 r-xp /lib/libnsl-2.20-2014.11.so
b32dc000 b32e2000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32f3000 b32f4000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b331c000 b3323000 r-xp /usr/lib/libminizip.so.1.0.0
b3333000 b3338000 r-xp /usr/lib/libstorage.so.0.1
b3348000 b33a7000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33bd000 b33d1000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33e1000 b3425000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3435000 b343d000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b344d000 b347d000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3490000 b3549000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b355d000 b35b0000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35c1000 b35dc000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35ec000 b36ad000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36c0000 b36d0000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36e0000 b36ed000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36fe000 b3705000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3715000 b3756000 r-xp /usr/lib/libmdm.so.1.2.12
b3766000 b376e000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b377d000 b378d000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37ae000 b380e000 r-xp /usr/lib/libasound.so.2.0.0
b3820000 b3823000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3833000 b3836000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3846000 b384b000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b385b000 b385c000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b386c000 b3877000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b388b000 b3892000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38a2000 b38a8000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38b8000 b38bd000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38cd000 b38e8000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38f8000 b38ff000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b390f000 b3912000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3923000 b3951000 r-xp /usr/lib/libidn.so.11.5.44
b3961000 b3977000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3988000 b3992000 r-xp /usr/lib/libcares.so.2.1.0
b39a2000 b39ac000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39bc000 b39be000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39ce000 b39cf000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39df000 b39e3000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39f4000 b3a1c000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a2d000 b3a56000 r-xp /usr/lib/libturbojpeg.so
b3a76000 b3a7c000 r-xp /usr/lib/libgif.so.4.1.6
b3a8c000 b3ad2000 r-xp /usr/lib/libcurl.so.4.3.0
b3ae3000 b3b04000 r-xp /usr/lib/libexif.so.12.3.3
b3b1f000 b3b34000 r-xp /usr/lib/libtts.so
b3b45000 b3b4d000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b5d000 b3c23000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c43000 b3d3b000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d5a000 b3e28000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e3f000 b3e41000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e51000 b3e57000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e67000 b3e8a000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e9b000 b3e9d000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ead000 b3eaf000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ec0000 b3ec5000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3edc000 b3ede000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3eee000 b3ef5000 r-xp /usr/lib/libsensord-share.so
b3f05000 b3f1d000 r-xp /usr/lib/libsensor.so.1.1.0
b3f2e000 b3f31000 r-xp /usr/lib/libXv.so.1.0.0
b3f41000 b3f46000 r-xp /usr/lib/libutilX.so.1.1.0
b3f56000 b3f5b000 r-xp /usr/lib/libappcore-common.so.1.1
b3f6b000 b3f72000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f85000 b3f89000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f9a000 b4078000 r-xp /usr/lib/libCOREGL.so.4.0
b4098000 b409b000 r-xp /usr/lib/libuuid.so.1.3.0
b40ab000 b40c2000 r-xp /usr/lib/libblkid.so.1.1.0
b40d3000 b40d5000 r-xp /usr/lib/libXau.so.6.0.0
b40e5000 b412c000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b413e000 b4144000 r-xp /usr/lib/libjson-c.so.2.0.1
b4155000 b4159000 r-xp /usr/lib/libogg.so.0.7.1
b4169000 b418b000 r-xp /usr/lib/libvorbis.so.0.4.3
b419b000 b427f000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b429b000 b429e000 r-xp /usr/lib/libEGL.so.1.4
b42af000 b42b5000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42c5000 b42c7000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42d7000 b42e4000 r-xp /usr/lib/libGLESv2.so.2.0
b42f5000 b4357000 r-xp /usr/lib/libpixman-1.so.0.28.2
b436c000 b4384000 r-xp /usr/lib/libmount.so.1.1.0
b4396000 b43aa000 r-xp /usr/lib/libxcb.so.1.1.0
b43ba000 b43c1000 r-xp /lib/libcrypt-2.20-2014.11.so
b43f9000 b43fb000 r-xp /usr/lib/libiri.so
b440b000 b4416000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4427000 b445d000 r-xp /usr/lib/libpulse.so.0.16.2
b446e000 b44b1000 r-xp /usr/lib/libsndfile.so.1.0.25
b44c6000 b44db000 r-xp /lib/libexpat.so.1.5.2
b44ed000 b45ab000 r-xp /usr/lib/libcairo.so.2.11200.14
b45bf000 b45c7000 r-xp /usr/lib/libdrm.so.2.4.0
b45d7000 b45da000 r-xp /usr/lib/libdri2.so.0.0.0
b45ea000 b4638000 r-xp /usr/lib/libssl.so.1.0.0
b464d000 b4659000 r-xp /usr/lib/libeeze.so.1.13.0
b466a000 b4673000 r-xp /usr/lib/libethumb.so.1.13.0
b4683000 b4686000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4696000 b484d000 r-xp /usr/lib/libcrypto.so.1.0.0
b5638000 b5641000 r-xp /usr/lib/libXi.so.6.1.0
b5651000 b5653000 r-xp /usr/lib/libXgesture.so.7.0.0
b5663000 b5667000 r-xp /usr/lib/libXtst.so.6.1.0
b5677000 b567d000 r-xp /usr/lib/libXrender.so.1.3.0
b568d000 b5693000 r-xp /usr/lib/libXrandr.so.2.2.0
b56a3000 b56a5000 r-xp /usr/lib/libXinerama.so.1.0.0
b56b6000 b56b9000 r-xp /usr/lib/libXfixes.so.3.1.0
b56c9000 b56d4000 r-xp /usr/lib/libXext.so.6.4.0
b56e4000 b56e6000 r-xp /usr/lib/libXdamage.so.1.1.0
b56f6000 b56f8000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5708000 b57ea000 r-xp /usr/lib/libX11.so.6.3.0
b57fe000 b5805000 r-xp /usr/lib/libXcursor.so.1.0.2
b5815000 b582d000 r-xp /usr/lib/libudev.so.1.6.0
b582f000 b5832000 r-xp /lib/libattr.so.1.1.0
b5842000 b5862000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5863000 b5868000 r-xp /usr/lib/libffi.so.6.0.2
b5879000 b5891000 r-xp /lib/libz.so.1.2.8
b58a1000 b58a3000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58b3000 b5988000 r-xp /usr/lib/libxml2.so.2.9.2
b599d000 b5a38000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a54000 b5a57000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a67000 b5a80000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a91000 b5aa2000 r-xp /lib/libresolv-2.20-2014.11.so
b5ab6000 b5b30000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b45000 b5b47000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b57000 b5b5e000 r-xp /usr/lib/libembryo.so.1.13.0
b5b6e000 b5b78000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b89000 b5ba1000 r-xp /usr/lib/libpng12.so.0.50.0
b5bb2000 b5bd5000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bf6000 b5c0a000 r-xp /usr/lib/libector.so.1.13.0
b5c1b000 b5c33000 r-xp /usr/lib/liblua-5.1.so
b5c44000 b5c9b000 r-xp /usr/lib/libfreetype.so.6.11.3
b5caf000 b5cd7000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5ce8000 b5cfb000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d0c000 b5d46000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d57000 b5d65000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d75000 b5d7d000 r-xp /usr/lib/libtbm.so.1.0.0
b5d8d000 b5d9a000 r-xp /usr/lib/libeio.so.1.13.0
b5daa000 b5dac000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dbc000 b5dc1000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dd1000 b5de8000 r-xp /usr/lib/libefreet.so.1.13.0
b5dfa000 b5e1a000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e2a000 b5e4a000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e4c000 b5e52000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e62000 b5e73000 r-xp /usr/lib/libemotion.so.1.13.0
b5e84000 b5e8b000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e9b000 b5eaa000 r-xp /usr/lib/libeo.so.1.13.0
b5ebb000 b5ecd000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ede000 b5ee3000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ef3000 b5f0c000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f1c000 b5f39000 r-xp /usr/lib/libeet.so.1.13.0
b5f52000 b5f9a000 r-xp /usr/lib/libeina.so.1.13.0
b5fab000 b5fbb000 r-xp /usr/lib/libefl.so.1.13.0
b5fcc000 b60b1000 r-xp /usr/lib/libicuuc.so.51.1
b60ce000 b620e000 r-xp /usr/lib/libicui18n.so.51.1
b6225000 b625d000 r-xp /usr/lib/libecore_x.so.1.13.0
b626f000 b6272000 r-xp /lib/libcap.so.2.21
b6282000 b62ab000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62bc000 b62c3000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62d5000 b630c000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b631d000 b6408000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b641b000 b6494000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64a6000 b64ab000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64bb000 b64c5000 r-xp /usr/lib/libvconf.so.0.2.45
b64d5000 b64d7000 r-xp /usr/lib/libvasum.so.0.3.1
b64e7000 b64e9000 r-xp /usr/lib/libttrace.so.1.1
b64f9000 b64fc000 r-xp /usr/lib/libiniparser.so.0
b650c000 b6532000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6542000 b6547000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6558000 b656f000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6580000 b65eb000 r-xp /lib/libm-2.20-2014.11.so
b65fc000 b6602000 r-xp /lib/librt-2.20-2014.11.so
b6613000 b6620000 r-xp /usr/lib/libunwind.so.8.0.1
b6656000 b677a000 r-xp /lib/libc-2.20-2014.11.so
b678f000 b67a8000 r-xp /lib/libgcc_s-4.9.so.1
b67b8000 b689a000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68ab000 b68d5000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68e6000 b6922000 r-xp /usr/lib/libsystemd.so.0.4.0
b6924000 b69a7000 r-xp /usr/lib/libedje.so.1.13.0
b69ba000 b69d8000 r-xp /usr/lib/libecore.so.1.13.0
b69f8000 b6b7f000 r-xp /usr/lib/libevas.so.1.13.0
b6bb4000 b6bc8000 r-xp /lib/libpthread-2.20-2014.11.so
b6bdc000 b6e10000 r-xp /usr/lib/libelementary.so.1.13.0
b6e3f000 b6e43000 r-xp /usr/lib/libsmack.so.1.0.0
b6e53000 b6e5a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e6a000 b6e6c000 r-xp /usr/lib/libdlog.so.0.0.0
b6e7c000 b6e7f000 r-xp /usr/lib/libbundle.so.0.1.22
b6e8f000 b6e91000 r-xp /lib/libdl-2.20-2014.11.so
b6ea2000 b6eba000 r-xp /usr/lib/libaul.so.0.1.0
b6ece000 b6ed3000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ee4000 b6ef1000 r-xp /usr/lib/liblptcp.so
b6f03000 b6f07000 r-xp /usr/lib/libsys-assert.so
b6f18000 b6f38000 r-xp /lib/ld-2.20-2014.11.so
b6f49000 b6f4e000 r-xp /usr/bin/launchpad-loader
b79e5000 b7c2a000 rw-p [heap]
bee99000 beeba000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19559)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6681b84) [/lib/libc.so.6] + 0x2bb84
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
mage_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:12:16.045+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 19228, appid: com.samsung.task-mgr
06-13 14:12:16.045+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:12:16.045+0900 E/RESOURCED(  667): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-13 14:12:16.065+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(19228)
06-13 14:12:16.075+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:12:16.075+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:12:16.135+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:12:16.135+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:12:16.145+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 14:12:16.145+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:12:16.145+0900 E/RUA     (19228): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 24, ncols : 5
06-13 14:12:16.155+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:12:16.155+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 14:12:16.165+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 14:12:16.215+0900 I/APP_CORE(19228): appcore-efl.c: __do_app(514) > [APP 19228] Event: RESET State: CREATED
06-13 14:12:16.215+0900 I/CAPI_APPFW_APPLICATION(19228): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 14:12:16.215+0900 E/EFL     (19228): edje<19228> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:12:16.215+0900 E/EFL     (19228): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:12:16.215+0900 E/EFL     (19228): edje<19228> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:12:16.215+0900 E/EFL     (19228): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:12:16.215+0900 W/APP_CORE(19228): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3200003
06-13 14:12:16.215+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
06-13 14:12:16.325+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: PAUSE State: RUNNING
06-13 14:12:16.325+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:12:16.325+0900 E/cluster-home( 1167): homescreen.cpp: OnPause(260) >  app pause
06-13 14:12:16.335+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(4)
06-13 14:12:16.335+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(1167)
06-13 14:12:16.335+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: bg
06-13 14:12:16.335+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(19228) status(3)
06-13 14:12:16.335+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:12:16.335+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:12:16.335+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(19228)
06-13 14:12:16.335+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 19228, appid: com.samsung.task-mgr, status: fg
06-13 14:12:16.345+0900 I/APP_CORE(19228): appcore-efl.c: __do_app(514) > [APP 19228] Event: RESUME State: CREATED
06-13 14:12:16.345+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:12:16.345+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:12:16.345+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: bg
06-13 14:12:16.345+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 14:12:16.345+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:12:16.345+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:12:16.345+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 14:12:16.355+0900 I/APP_CORE(19228): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-13 14:12:16.355+0900 I/APP_CORE(19228): appcore-efl.c: __do_app(625) > [APP 19228] Initial Launching, call the resume_cb
06-13 14:12:16.355+0900 I/CAPI_APPFW_APPLICATION(19228): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:12:16.675+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 14:12:16.675+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17722880
06-13 14:12:16.675+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17722880
06-13 14:12:16.675+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 14:12:16.675+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:12:16.675+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:12:16.675+0900 E/STARTER (  721): )
06-13 14:12:16.675+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:12:16.685+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:12:16.685+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:12:16.685+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:12:16.695+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(19228) status(0)
06-13 14:12:17.096+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1925
06-13 14:12:17.106+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 14:12:17.106+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 19228.
06-13 14:12:17.176+0900 E/EFL     (19228): ecore_x<19228> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17723314
06-13 14:12:17.176+0900 I/TASK_MGR_LITE(19228): task-mgr-lite.c: on_hw_back(132) > Back key and Key down, so call elm_exit()
06-13 14:12:17.176+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:12:17.176+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:12:17.176+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(19228)
06-13 14:12:17.176+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 19228, appid: com.samsung.task-mgr, status: bg
06-13 14:12:17.186+0900 I/CAPI_APPFW_APPLICATION(19228): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:12:17.186+0900 W/TASK_MGR_LITE(19228): task-mgr-lite.c: _pause_app(406) > 
06-13 14:12:17.186+0900 I/CAPI_APPFW_APPLICATION(19228): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:12:17.186+0900 E/TASK_MGR_LITE(19228): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 14:12:17.196+0900 E/TASK_MGR_LITE(19228): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
06-13 14:12:17.206+0900 E/APP_CORE(19228): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 14:12:17.206+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:12:17.216+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:12:17.216+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:12:17.216+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:12:17.216+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:12:17.216+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:12:17.216+0900 E/EFL     (19228): ecore_x<19228> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17723384
06-13 14:12:17.226+0900 I/MALI    (19228): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=19228   close drm_fd=30 
06-13 14:12:17.256+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 14:12:17.286+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:12:17.286+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:12:17.286+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:12:17.286+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:12:17.336+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:12:17.336+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:12:17.336+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:12:17.346+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:12:17.346+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:12:17.346+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: fg
06-13 14:12:17.366+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:17.366+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:17.496+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 19228 pgid = 19228
06-13 14:12:17.496+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(19228)
06-13 14:12:17.536+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:12:17.536+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:12:17.536+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:12:17.536+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 19228
06-13 14:12:17.536+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[19228] terminate event is forwarded
06-13 14:12:17.536+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:12:17.536+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 19228, ]
06-13 14:12:17.536+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:12:17.536+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 14:12:17.536+0900 I/Tizen::App( 1175): (512) > Not registered pid(19228)
06-13 14:12:17.536+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 14:12:17.536+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:12:17.536+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 19228
06-13 14:12:17.536+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 19228
06-13 14:12:17.566+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:12:17.566+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 19228.
06-13 14:12:18.197+0900 I/UXT     (19545): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:12:18.207+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17724409
06-13 14:12:18.207+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17724409
06-13 14:12:18.207+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 14:12:18.207+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 14:12:18.207+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 14:12:18.247+0900 E/TBM     (19545): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:12:18.247+0900 I/MALI    (19545): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=19545   open drm_fd=30 
06-13 14:12:18.357+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:18.367+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:18.377+0900 E/EFL     (19545): edje<19545> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:12:18.377+0900 E/EFL     (19545): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:12:18.377+0900 E/EFL     (19545): edje<19545> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:12:18.377+0900 E/EFL     (19545): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:12:18.377+0900 E/EFL     (19545): edje<19545> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:12:18.377+0900 E/EFL     (19545): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:12:18.377+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:18.387+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:18.397+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:18.397+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:18.417+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:18.417+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:18.437+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:18.437+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:18.457+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:18.457+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:18.467+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:18.477+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:18.487+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:18.497+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:18.507+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:12:18.507+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:12:18.507+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:12:18.507+0900 E/STARTER (  721): )
06-13 14:12:18.507+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:18.507+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:18.507+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:12:18.507+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:12:18.507+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:12:18.517+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
06-13 14:12:18.517+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:12:18.527+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:18.527+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:18.537+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 14:12:18.537+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:12:18.537+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 14:12:18.537+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:12:18.547+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:18.547+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:12:18.547+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:18.547+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:18.547+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:12:18.557+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(527) > Launch on common type process-pool
06-13 14:12:18.557+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:12:18.557+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:18.567+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:18.567+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:18.567+0900 E/CAPI_APPFW_APPLICATION(19496): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:12:18.567+0900 E/CAPI_APPFW_APPLICATION(19496): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:12:18.567+0900 E/CAPI_APPFW_APPLICATION(19496): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:12:18.567+0900 E/CAPI_APPFW_APPLICATION(19496): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:12:18.567+0900 E/CAPI_APPFW_APPLICATION(19496): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:12:18.577+0900 I/CAPI_APPFW_APPLICATION(19496): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:12:18.577+0900 I/CAPI_APPFW_APPLICATION(19496): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:12:18.627+0900 E/APP_CORE(19496): appcore-efl.c: appcore_set_preinit_window_name(1726) > no preinit window
06-13 14:12:18.627+0900 E/TASK_MGR_LITE(19496): task-mgr-lite.c: create_win(170) > Failed to get preinitialized window, so use elm_win_add()
06-13 14:12:18.657+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 19496, appid: com.samsung.task-mgr
06-13 14:12:18.657+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:12:18.657+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(19496)
06-13 14:12:18.657+0900 E/TBM     (19496): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:12:18.657+0900 I/MALI    (19496): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=19496   open drm_fd=34 
06-13 14:12:18.657+0900 E/RESOURCED(  667): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-13 14:12:18.777+0900 W/TASK_MGR_LITE(19496): task-mgr-lite.c: create_win(197) > changeable ui enabled success
06-13 14:12:18.777+0900 E/TASK_MGR_LITE(19496): task-mgr-lite.c: create_win(206) > Failed get preinitialized background! So use elm_bg_add(win)
06-13 14:12:18.777+0900 I/GXT_SIB (19496): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:12:18.818+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:12:18.818+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:12:18.818+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:12:18.828+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:12:18.828+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:12:18.838+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 14:12:18.848+0900 E/RUA     (19496): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 24, ncols : 5
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 14:12:18.848+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:12:18.848+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 14:12:18.848+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 14:12:18.898+0900 I/APP_CORE(19496): appcore-efl.c: __do_app(514) > [APP 19496] Event: RESET State: CREATED
06-13 14:12:18.898+0900 I/CAPI_APPFW_APPLICATION(19496): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 14:12:18.898+0900 W/APP_CORE(19496): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5600003
06-13 14:12:18.908+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
06-13 14:12:18.998+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: PAUSE State: RUNNING
06-13 14:12:18.998+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:12:18.998+0900 E/cluster-home( 1167): homescreen.cpp: OnPause(260) >  app pause
06-13 14:12:18.998+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(4)
06-13 14:12:18.998+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(1167)
06-13 14:12:18.998+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: bg
06-13 14:12:19.008+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(19496) status(3)
06-13 14:12:19.008+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:12:19.008+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:12:19.008+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(19496)
06-13 14:12:19.008+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 19496, appid: com.samsung.task-mgr, status: fg
06-13 14:12:19.008+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17725220
06-13 14:12:19.008+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 14:12:19.008+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17725220
06-13 14:12:19.008+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 14:12:19.008+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:12:19.008+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:12:19.008+0900 E/STARTER (  721): )
06-13 14:12:19.018+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:12:19.018+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:12:19.018+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:12:19.018+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: bg
06-13 14:12:19.018+0900 I/APP_CORE(19496): appcore-efl.c: __do_app(514) > [APP 19496] Event: RESUME State: CREATED
06-13 14:12:19.018+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:12:19.018+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:12:19.018+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:12:19.028+0900 I/APP_CORE(19496): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-13 14:12:19.028+0900 I/APP_CORE(19496): appcore-efl.c: __do_app(625) > [APP 19496] Initial Launching, call the resume_cb
06-13 14:12:19.028+0900 I/CAPI_APPFW_APPLICATION(19496): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:12:19.378+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(19496) status(0)
06-13 14:12:19.698+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1930
06-13 14:12:19.708+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 14:12:19.708+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 19496.
06-13 14:12:19.869+0900 E/EFL     (19496): ecore_x<19496> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17725987
06-13 14:12:19.869+0900 E/EFL     (19496): ecore_x<19496> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17726079
06-13 14:12:19.869+0900 I/TASK_MGR_LITE(19496): task-mgr-lite.c: on_hw_back(132) > Back key and Key down, so call elm_exit()
06-13 14:12:19.869+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:12:19.869+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:12:19.869+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(19496)
06-13 14:12:19.869+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 19496, appid: com.samsung.task-mgr, status: bg
06-13 14:12:19.869+0900 I/CAPI_APPFW_APPLICATION(19496): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:12:19.869+0900 W/TASK_MGR_LITE(19496): task-mgr-lite.c: _pause_app(406) > 
06-13 14:12:19.869+0900 I/CAPI_APPFW_APPLICATION(19496): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:12:19.869+0900 E/TASK_MGR_LITE(19496): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 14:12:19.879+0900 E/TASK_MGR_LITE(19496): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
06-13 14:12:19.889+0900 E/APP_CORE(19496): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 14:12:19.889+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:12:19.889+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:12:19.889+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:12:19.889+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:12:19.889+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:12:19.889+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:12:19.909+0900 I/MALI    (19496): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=19496   close drm_fd=34 
06-13 14:12:19.939+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 14:12:19.969+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:12:19.969+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:12:19.969+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:12:19.979+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:12:19.989+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:12:19.999+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:12:19.999+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:12:19.999+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: fg
06-13 14:12:20.019+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:20.029+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:20.029+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:12:20.029+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:12:20.219+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 19496 pgid = 19496
06-13 14:12:20.219+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(19496)
06-13 14:12:20.269+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:12:20.269+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:12:20.269+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:12:20.279+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 19496
06-13 14:12:20.279+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[19496] terminate event is forwarded
06-13 14:12:20.279+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:12:20.279+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 19496, ]
06-13 14:12:20.279+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:12:20.279+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 14:12:20.279+0900 I/Tizen::App( 1175): (512) > Not registered pid(19496)
06-13 14:12:20.279+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 14:12:20.279+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:12:20.289+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 19496
06-13 14:12:20.289+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 19496
06-13 14:12:20.309+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:12:20.309+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 19496.
06-13 14:12:20.499+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17726709
06-13 14:12:20.719+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 14:12:20.719+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 14:12:20.729+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:12:20.729+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:12:20.729+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: bg
06-13 14:12:20.839+0900 I/UXT     (19559): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:12:20.940+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17727150
06-13 14:12:21.000+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:21.010+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:21.020+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:21.030+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:21.040+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:21.040+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:21.060+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:21.060+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:21.080+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:21.080+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:21.100+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:21.100+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:21.120+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:21.120+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:21.130+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:21.140+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:21.150+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:21.150+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:21.170+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:21.180+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:21.190+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:21.190+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:21.190+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:21.190+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:21.210+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:21.210+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:21.490+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17727698
06-13 14:12:21.600+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17727809
06-13 14:12:21.760+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17727974
06-13 14:12:21.830+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17728040
06-13 14:12:21.871+0900 W/cluster-view( 1167): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
06-13 14:12:22.181+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:12:22.181+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17728393
06-13 14:12:22.261+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17728470
06-13 14:12:22.261+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
06-13 14:12:22.261+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
06-13 14:12:22.261+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 1167
06-13 14:12:22.271+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 7
06-13 14:12:22.271+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:12:22.281+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:12:22.281+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:12:22.281+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:12:22.291+0900 I/abc     (19559): abc
06-13 14:12:22.291+0900 I/CAPI_APPFW_APPLICATION(19559): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:12:22.291+0900 I/CAPI_APPFW_APPLICATION(19559): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:12:22.321+0900 E/TBM     (19559): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:12:22.381+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 19559, appid: org.example.client
06-13 14:12:22.381+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:12:22.391+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(425) > request cmd(1) result(19559)
06-13 14:12:22.501+0900 W/CRASH_MANAGER(19486): worker.c: worker_job(1199) > 0619559636c69149733074
