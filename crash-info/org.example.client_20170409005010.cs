S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 6408
Date: 2017-04-09 00:50:10+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 6408, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00001908
r2   = 0x00000006, r3   = 0xb41384c0
r4   = 0x00000002, r5   = 0xb4138000
r6   = 0xb683209c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f60708
r10  = 0xb8ee2ff8, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbeed6eec
lr   = 0xb6728f18, pc   = 0xb6727b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:    148756 KB
Buffers:     43516 KB
Cached:     335360 KB
VmPeak:     136348 KB
VmSize:     135044 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29448 KB
VmRSS:       29428 KB
VmData:      47032 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35796 KB
VmPTE:         102 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6408 TID = 6408
6408 6409 6764 6765 6773 

Maps Information
af0c1000 af8c0000 rw-p [stack:6773]
b0fe9000 b0ffa000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b100a000 b100f000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1411000 b1419000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b142b000 b1c2a000 rw-p [stack:6765]
b1c2a000 b1c2b000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c3b000 b1c4f000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c63000 b1c64000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c74000 b1c77000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c88000 b1c89000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c99000 b1c9b000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1cab000 b1cad000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1cbd000 b1ccd000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1cdd000 b1ce9000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cfb000 b24fa000 rw-p [stack:6764]
b282b000 b2832000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2845000 b284b000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b285b000 b287b000 r-xp /opt/usr/apps/org.example.client/bin/client
b29c4000 b2aa7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ade000 b2b06000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b18000 b3317000 rw-p [stack:6409]
b3317000 b3319000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3329000 b3333000 r-xp /lib/libnss_files-2.20-2014.11.so
b3344000 b334d000 r-xp /lib/libnss_nis-2.20-2014.11.so
b335e000 b336f000 r-xp /lib/libnsl-2.20-2014.11.so
b3382000 b3388000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3399000 b339a000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33c2000 b33c9000 r-xp /usr/lib/libminizip.so.1.0.0
b33d9000 b33de000 r-xp /usr/lib/libstorage.so.0.1
b33ee000 b344d000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3463000 b3477000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3487000 b34cb000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34db000 b34e3000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34f3000 b3523000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3536000 b35ef000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3603000 b3656000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3667000 b3682000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3692000 b3753000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3766000 b3776000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3786000 b3793000 r-xp /usr/lib/libmdm-common.so.1.0.98
b37a4000 b37ab000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b37bb000 b37fc000 r-xp /usr/lib/libmdm.so.1.2.12
b380c000 b3814000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3823000 b3833000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3854000 b38b4000 r-xp /usr/lib/libasound.so.2.0.0
b38c6000 b38c9000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38d9000 b38dc000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38ec000 b38f1000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3901000 b3902000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3912000 b391d000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3931000 b3938000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3948000 b394e000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b395e000 b3963000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3973000 b398e000 r-xp /usr/lib/libmmfsound.so.0.1.0
b399e000 b39a5000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b39b5000 b39b8000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39c9000 b39f7000 r-xp /usr/lib/libidn.so.11.5.44
b3a07000 b3a1d000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a2e000 b3a38000 r-xp /usr/lib/libcares.so.2.1.0
b3a48000 b3a52000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a62000 b3a64000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a74000 b3a75000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a85000 b3a89000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a9a000 b3ac2000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ad3000 b3afc000 r-xp /usr/lib/libturbojpeg.so
b3b1c000 b3b22000 r-xp /usr/lib/libgif.so.4.1.6
b3b32000 b3b78000 r-xp /usr/lib/libcurl.so.4.3.0
b3b89000 b3baa000 r-xp /usr/lib/libexif.so.12.3.3
b3bc5000 b3bda000 r-xp /usr/lib/libtts.so
b3beb000 b3bf3000 r-xp /usr/lib/libfeedback.so.0.1.4
b3c03000 b3cc9000 r-xp /usr/lib/libdali-core.so.0.0.0
b3ce9000 b3de1000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3e00000 b3ece000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ee5000 b3ee7000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ef7000 b3efd000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3f0d000 b3f30000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f41000 b3f43000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f53000 b3f55000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f66000 b3f6b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f82000 b3f84000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f94000 b3f9b000 r-xp /usr/lib/libsensord-share.so
b3fab000 b3fc3000 r-xp /usr/lib/libsensor.so.1.1.0
b3fd4000 b3fd7000 r-xp /usr/lib/libXv.so.1.0.0
b3fe7000 b3fec000 r-xp /usr/lib/libutilX.so.1.1.0
b3ffc000 b4001000 r-xp /usr/lib/libappcore-common.so.1.1
b4011000 b4018000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b402b000 b402f000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4040000 b411e000 r-xp /usr/lib/libCOREGL.so.4.0
b413e000 b4141000 r-xp /usr/lib/libuuid.so.1.3.0
b4151000 b4168000 r-xp /usr/lib/libblkid.so.1.1.0
b4179000 b417b000 r-xp /usr/lib/libXau.so.6.0.0
b418b000 b41d2000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41e4000 b41ea000 r-xp /usr/lib/libjson-c.so.2.0.1
b41fb000 b41ff000 r-xp /usr/lib/libogg.so.0.7.1
b420f000 b4231000 r-xp /usr/lib/libvorbis.so.0.4.3
b4241000 b4325000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4341000 b4344000 r-xp /usr/lib/libEGL.so.1.4
b4355000 b435b000 r-xp /usr/lib/libxcb-render.so.0.0.0
b436b000 b436d000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b437d000 b438a000 r-xp /usr/lib/libGLESv2.so.2.0
b439b000 b43fd000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4412000 b442a000 r-xp /usr/lib/libmount.so.1.1.0
b443c000 b4450000 r-xp /usr/lib/libxcb.so.1.1.0
b4460000 b4467000 r-xp /lib/libcrypt-2.20-2014.11.so
b449f000 b44a1000 r-xp /usr/lib/libiri.so
b44b1000 b44bc000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44cd000 b4503000 r-xp /usr/lib/libpulse.so.0.16.2
b4514000 b4557000 r-xp /usr/lib/libsndfile.so.1.0.25
b456c000 b4581000 r-xp /lib/libexpat.so.1.5.2
b4593000 b4651000 r-xp /usr/lib/libcairo.so.2.11200.14
b4665000 b466d000 r-xp /usr/lib/libdrm.so.2.4.0
b467d000 b4680000 r-xp /usr/lib/libdri2.so.0.0.0
b4690000 b46de000 r-xp /usr/lib/libssl.so.1.0.0
b46f3000 b46ff000 r-xp /usr/lib/libeeze.so.1.13.0
b4710000 b4719000 r-xp /usr/lib/libethumb.so.1.13.0
b4729000 b472c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b473c000 b48f3000 r-xp /usr/lib/libcrypto.so.1.0.0
b56de000 b56e7000 r-xp /usr/lib/libXi.so.6.1.0
b56f7000 b56f9000 r-xp /usr/lib/libXgesture.so.7.0.0
b5709000 b570d000 r-xp /usr/lib/libXtst.so.6.1.0
b571d000 b5723000 r-xp /usr/lib/libXrender.so.1.3.0
b5733000 b5739000 r-xp /usr/lib/libXrandr.so.2.2.0
b5749000 b574b000 r-xp /usr/lib/libXinerama.so.1.0.0
b575c000 b575f000 r-xp /usr/lib/libXfixes.so.3.1.0
b576f000 b577a000 r-xp /usr/lib/libXext.so.6.4.0
b578a000 b578c000 r-xp /usr/lib/libXdamage.so.1.1.0
b579c000 b579e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57ae000 b5890000 r-xp /usr/lib/libX11.so.6.3.0
b58a4000 b58ab000 r-xp /usr/lib/libXcursor.so.1.0.2
b58bb000 b58d3000 r-xp /usr/lib/libudev.so.1.6.0
b58d5000 b58d8000 r-xp /lib/libattr.so.1.1.0
b58e8000 b5908000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5909000 b590e000 r-xp /usr/lib/libffi.so.6.0.2
b591f000 b5937000 r-xp /lib/libz.so.1.2.8
b5947000 b5949000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5959000 b5a2e000 r-xp /usr/lib/libxml2.so.2.9.2
b5a43000 b5ade000 r-xp /usr/lib/libstdc++.so.6.0.20
b5afa000 b5afd000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b0d000 b5b26000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b37000 b5b48000 r-xp /lib/libresolv-2.20-2014.11.so
b5b5c000 b5bd6000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5beb000 b5bed000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bfd000 b5c04000 r-xp /usr/lib/libembryo.so.1.13.0
b5c14000 b5c1e000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c2f000 b5c47000 r-xp /usr/lib/libpng12.so.0.50.0
b5c58000 b5c7b000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c9c000 b5cb0000 r-xp /usr/lib/libector.so.1.13.0
b5cc1000 b5cd9000 r-xp /usr/lib/liblua-5.1.so
b5cea000 b5d41000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d55000 b5d7d000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d8e000 b5da1000 r-xp /usr/lib/libfribidi.so.0.3.1
b5db2000 b5dec000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dfd000 b5e0b000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e1b000 b5e23000 r-xp /usr/lib/libtbm.so.1.0.0
b5e33000 b5e40000 r-xp /usr/lib/libeio.so.1.13.0
b5e50000 b5e52000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e62000 b5e67000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e77000 b5e8e000 r-xp /usr/lib/libefreet.so.1.13.0
b5ea0000 b5ec0000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ed0000 b5ef0000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ef2000 b5ef8000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f08000 b5f19000 r-xp /usr/lib/libemotion.so.1.13.0
b5f2a000 b5f31000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f41000 b5f50000 r-xp /usr/lib/libeo.so.1.13.0
b5f61000 b5f73000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f84000 b5f89000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f99000 b5fb2000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fc2000 b5fdf000 r-xp /usr/lib/libeet.so.1.13.0
b5ff8000 b6040000 r-xp /usr/lib/libeina.so.1.13.0
b6051000 b6061000 r-xp /usr/lib/libefl.so.1.13.0
b6072000 b6157000 r-xp /usr/lib/libicuuc.so.51.1
b6174000 b62b4000 r-xp /usr/lib/libicui18n.so.51.1
b62cb000 b6303000 r-xp /usr/lib/libecore_x.so.1.13.0
b6315000 b6318000 r-xp /lib/libcap.so.2.21
b6328000 b6351000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6362000 b6369000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b637b000 b63b2000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63c3000 b64ae000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64c1000 b653a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b654c000 b6551000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6561000 b656b000 r-xp /usr/lib/libvconf.so.0.2.45
b657b000 b657d000 r-xp /usr/lib/libvasum.so.0.3.1
b658d000 b658f000 r-xp /usr/lib/libttrace.so.1.1
b659f000 b65a2000 r-xp /usr/lib/libiniparser.so.0
b65b2000 b65d8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65e8000 b65ed000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65fe000 b6615000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6626000 b6691000 r-xp /lib/libm-2.20-2014.11.so
b66a2000 b66a8000 r-xp /lib/librt-2.20-2014.11.so
b66b9000 b66c6000 r-xp /usr/lib/libunwind.so.8.0.1
b66fc000 b6820000 r-xp /lib/libc-2.20-2014.11.so
b6835000 b684e000 r-xp /lib/libgcc_s-4.9.so.1
b685e000 b6940000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6951000 b697b000 r-xp /usr/lib/libdbus-1.so.3.8.12
b698c000 b69c8000 r-xp /usr/lib/libsystemd.so.0.4.0
b69ca000 b6a4d000 r-xp /usr/lib/libedje.so.1.13.0
b6a60000 b6a7e000 r-xp /usr/lib/libecore.so.1.13.0
b6a9e000 b6c25000 r-xp /usr/lib/libevas.so.1.13.0
b6c5a000 b6c6e000 r-xp /lib/libpthread-2.20-2014.11.so
b6c82000 b6eb6000 r-xp /usr/lib/libelementary.so.1.13.0
b6ee5000 b6ee9000 r-xp /usr/lib/libsmack.so.1.0.0
b6ef9000 b6f00000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f10000 b6f12000 r-xp /usr/lib/libdlog.so.0.0.0
b6f22000 b6f25000 r-xp /usr/lib/libbundle.so.0.1.22
b6f35000 b6f37000 r-xp /lib/libdl-2.20-2014.11.so
b6f48000 b6f60000 r-xp /usr/lib/libaul.so.0.1.0
b6f74000 b6f79000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f8a000 b6f97000 r-xp /usr/lib/liblptcp.so
b6fa9000 b6fad000 r-xp /usr/lib/libsys-assert.so
b6fbe000 b6fde000 r-xp /lib/ld-2.20-2014.11.so
b6fef000 b6ff4000 r-xp /usr/bin/launchpad-loader
b8b0e000 b8f0d000 rw-p [heap]
beeb7000 beed8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6408)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6727b84) [/lib/libc.so.6] + 0x2bb84
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
7): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(5974)
04-09 00:48:17.098+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 5974, appid: org.example.client, status: fg
04-09 00:48:17.128+0900 W/LOCKSCREEN(  850): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2A00007] is [invisible]
04-09 00:48:17.128+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
04-09 00:48:17.128+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
04-09 00:48:17.128+0900 E/LOCKSCREEN(  850): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
04-09 00:48:17.128+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: PAUSE State: RUNNING
04-09 00:48:17.128+0900 I/CAPI_APPFW_APPLICATION(  850): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-09 00:48:17.128+0900 E/LOCKSCREEN(  850): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-09 00:48:17.128+0900 E/LOCKSCREEN(  850): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
04-09 00:48:17.128+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
04-09 00:48:17.128+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
04-09 00:48:17.128+0900 W/LOCKSCREEN(  850): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
04-09 00:48:17.128+0900 E/LOCKSCREEN(  850): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
04-09 00:48:17.138+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-09 00:48:17.138+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:48:17.138+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:48:17.138+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: MEM_FLUSH State: PAUSED
04-09 00:48:17.148+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:48:17.228+0900 W/LOCKSCREEN(  850): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
04-09 00:48:17.228+0900 E/LOCKSCREEN(  850): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
04-09 00:48:17.228+0900 E/LOCKSCREEN(  850): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-09 00:48:17.228+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
04-09 00:48:17.228+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
04-09 00:48:17.238+0900 E/LOCKSCREEN(  850): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
04-09 00:48:17.519+0900 E/weather-agent( 6512): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
04-09 00:48:17.519+0900 I/CAPI_APPFW_APPLICATION( 6512): service_app_main.c: service_app_exit(446) > service_app_exit
04-09 00:48:17.529+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
04-09 00:48:17.529+0900 E/weather-agent( 6512): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
04-09 00:48:17.529+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
04-09 00:48:17.549+0900 E/PKGMGR_SERVER( 6554): pkgmgr-server.c: main(2414) > package manager server start
04-09 00:48:17.589+0900 E/PKGMGR  ( 6552): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-09 00:48:17.629+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
04-09 00:48:17.629+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5974
04-09 00:48:17.629+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
04-09 00:48:17.629+0900 W/AUL     ( 6557): launch.c: app_request_to_launchpad(396) > request cmd(5) to(3248)
04-09 00:48:17.629+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 5
04-09 00:48:17.629+0900 E/AUL_AMD (  607): amd_request.c: __app_process_by_pid(272) > pid(3248) is dead. cmd(5) is canceled
04-09 00:48:17.629+0900 W/AUL     ( 6557): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-09 00:48:17.629+0900 E/PKGMGR_SERVER( 6557): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-09 00:48:17.629+0900 E/PKGMGR_SERVER( 6557): [0;m
04-09 00:48:17.629+0900 W/AUL     ( 6557): launch.c: app_request_to_launchpad(396) > request cmd(5) to(3576)
04-09 00:48:17.629+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 5
04-09 00:48:17.629+0900 E/AUL_AMD (  607): amd_request.c: __app_process_by_pid(272) > pid(3576) is dead. cmd(5) is canceled
04-09 00:48:17.629+0900 W/AUL     ( 6557): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-09 00:48:17.629+0900 E/PKGMGR_SERVER( 6557): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-09 00:48:17.629+0900 E/PKGMGR_SERVER( 6557): [0;m
04-09 00:48:17.629+0900 W/AUL     ( 6557): launch.c: app_request_to_launchpad(396) > request cmd(5) to(3853)
04-09 00:48:17.629+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 5
04-09 00:48:17.629+0900 E/AUL_AMD (  607): amd_request.c: __app_process_by_pid(272) > pid(3853) is dead. cmd(5) is canceled
04-09 00:48:17.629+0900 W/AUL     ( 6557): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-09 00:48:17.629+0900 E/PKGMGR_SERVER( 6557): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-09 00:48:17.629+0900 E/PKGMGR_SERVER( 6557): [0;m
04-09 00:48:17.629+0900 W/AUL     ( 6557): launch.c: app_request_to_launchpad(396) > request cmd(5) to(6134)
04-09 00:48:17.629+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 5
04-09 00:48:17.629+0900 E/AUL_AMD (  607): amd_request.c: __app_process_by_pid(272) > pid(6134) is dead. cmd(5) is canceled
04-09 00:48:17.629+0900 W/AUL     ( 6557): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-09 00:48:17.629+0900 E/PKGMGR_SERVER( 6557): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-09 00:48:17.629+0900 E/PKGMGR_SERVER( 6557): [0;m
04-09 00:48:17.629+0900 W/AUL     ( 6557): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5974)
04-09 00:48:17.629+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 5
04-09 00:48:17.639+0900 I/APP_CORE( 5974): appcore-efl.c: __do_app(514) > [APP 5974] Event: TERMINATE State: RUNNING
04-09 00:48:17.639+0900 W/AUL_AMD (  607): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(5974), cmd(4)
04-09 00:48:17.639+0900 W/AUL     ( 6557): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
04-09 00:48:17.639+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
04-09 00:48:17.639+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5974
04-09 00:48:17.639+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
04-09 00:48:17.639+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
04-09 00:48:17.639+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
04-09 00:48:17.639+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
04-09 00:48:17.649+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 5974): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 10
04-09 00:48:17.649+0900 E/APP_CORE( 5974): appcore-efl.c: _capture_and_make_file(1619) > win[6400002] widget[720] height[1280]
04-09 00:48:17.649+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
04-09 00:48:17.649+0900 W/AUL_AMD (  607): amd_request.c: __send_app_termination_signal(609) > send dead signal done
04-09 00:48:17.649+0900 E/APP_CORE( 5974): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.client]
04-09 00:48:17.649+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 6512
04-09 00:48:17.649+0900 I/CAPI_APPFW_APPLICATION( 5974): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-09 00:48:17.649+0900 I/CAPI_APPFW_APPLICATION( 5974): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-09 00:48:17.649+0900 I/Tizen::App( 1246): (243) > App[com.samsung.weather-m-agent] pid[6512] terminate event is forwarded
04-09 00:48:17.649+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-09 00:48:17.649+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 6512, ]
04-09 00:48:17.649+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-09 00:48:17.649+0900 I/Tizen::App( 1246): (506) > TerminatedApp(com.samsung.weather-m-agent)
04-09 00:48:17.649+0900 I/Tizen::App( 1246): (512) > Not registered pid(6512)
04-09 00:48:17.649+0900 I/Tizen::System( 1246): (246) > Terminated app [com.samsung.weather-m-agent]
04-09 00:48:17.649+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:48:17.659+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6512
04-09 00:48:17.659+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:48:17.659+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(3)
04-09 00:48:17.659+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-09 00:48:17.659+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:48:17.659+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-09 00:48:17.659+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 6512.
04-09 00:48:17.659+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(868)
04-09 00:48:17.659+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-09 00:48:17.689+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-09 00:48:17.719+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:48:17.719+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-09 00:48:17.719+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:48:17.719+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-09 00:48:17.719+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:48:17.739+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
04-09 00:48:17.739+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-09 00:48:17.749+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-09 00:48:17.749+0900 E/PKGMGR_SERVER( 6554): pkgmgr-server.c: sighandler(417) > child NORMAL exit [6557]
04-09 00:48:17.759+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [org.exampl] 
04-09 00:48:17.759+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:48:17.769+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:48:17.779+0900 E/weather-widget( 1410): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-09 00:48:17.799+0900 E/weather-common( 1410): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-09 00:48:17.849+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_create(409) > New handle created[0xb8570610]
04-09 00:48:17.849+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_get_type(463) > Connected Network = 2
04-09 00:48:17.849+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_destroy(427) > Destroy handle: 0xb8570610
04-09 00:48:17.849+0900 E/weather-common( 1410): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-09 00:48:17.859+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-09 00:48:17.859+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-09 00:48:17.859+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-09 00:48:17.859+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: fg
04-09 00:48:17.969+0900 E/VCONF   ( 5974): vconf-kdb.c: _vconf_kdb_del_notify(468) > Error: inotify_add_watch() [/opt/var/kdb/db/ise+keysound]: Permission denied
04-09 00:48:17.969+0900 E/VCONF   ( 5974): vconf.c: vconf_ignore_key_changed(3218) > vconf_ignore_key_changed() failed: key(db/ise/keysound)
04-09 00:48:18.009+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 5974 pgid = 5974
04-09 00:48:18.009+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(5974)
04-09 00:48:18.059+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-09 00:48:18.059+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-09 00:48:18.059+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-09 00:48:18.059+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 5974
04-09 00:48:18.059+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 5974
04-09 00:48:18.059+0900 I/Tizen::App( 1246): (243) > App[org.example.client] pid[5974] terminate event is forwarded
04-09 00:48:18.059+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-09 00:48:18.059+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [org.example.client, 5974, ]
04-09 00:48:18.059+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-09 00:48:18.059+0900 I/Tizen::App( 1246): (506) > TerminatedApp(org.example.client)
04-09 00:48:18.059+0900 I/Tizen::App( 1246): (512) > Not registered pid(5974)
04-09 00:48:18.059+0900 I/Tizen::System( 1246): (246) > Terminated app [org.example.client]
04-09 00:48:18.059+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:48:18.059+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.548
04-09 00:48:18.069+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:48:18.069+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for org.example.client, 5974.
04-09 00:48:19.811+0900 E/PKGMGR_SERVER( 6554): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-09 00:48:19.811+0900 E/PKGMGR_SERVER( 6554): pkgmgr-server.c: main(2471) > package manager server terminated.
04-09 00:48:21.723+0900 E/PKGMGR  ( 6646): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-09 00:48:21.803+0900 E/PKGMGR_SERVER( 6648): pkgmgr-server.c: main(2414) > package manager server start
04-09 00:48:21.853+0900 E/PKGMGR_SERVER( 6648): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-09 00:48:21.863+0900 E/PKGMGR_SERVER( 6648): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-09 00:48:21.863+0900 E/PKGMGR  ( 6646): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[66460002]
04-09 00:48:22.003+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-09 00:48:22.003+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-09 00:48:22.013+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-09 00:48:22.023+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-09 00:48:22.023+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [30]
04-09 00:48:22.023+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-09 00:48:22.143+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: MEM_FLUSH State: PAUSED
04-09 00:48:22.183+0900 W/CERT_SVC_VCORE( 6651): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-09 00:48:22.273+0900 E/rpm-installer( 6651): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-09 00:48:22.273+0900 E/rpm-installer( 6651): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-09 00:48:22.333+0900 E/PKGMGR_PARSER( 6651): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-09 00:48:22.353+0900 I/PRIVACY-MANAGER-CLIENT( 6651): SocketClient.cpp: SocketClient(37) > Client created
04-09 00:48:22.353+0900 I/PRIVACY-MANAGER-CLIENT( 6651): SocketClient.cpp: connect(62) > Client connected
04-09 00:48:22.353+0900 I/PRIVACY-MANAGER-SERVER(  938): SocketService.cpp: mainloop(230) > Got incoming connection
04-09 00:48:22.353+0900 I/PRIVACY-MANAGER-CLIENT( 6651): SocketClient.cpp: disconnect(72) > Client disconnected
04-09 00:48:22.353+0900 E/PKGMGR_CERT( 6651): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-09 00:48:22.363+0900 E/PKGMGR_CERT( 6651): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-09 00:48:22.363+0900 E/PKGMGR_CERT( 6651): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-09 00:48:22.393+0900 E/rpm-installer( 6651): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-09 00:48:22.403+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-09 00:48:22.403+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
04-09 00:48:22.403+0900 E/ESD     (  919): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-09 00:48:22.403+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-09 00:48:22.413+0900 W/ISF_PANEL_EFL(  789): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-09 00:48:22.413+0900 W/ISF_PANEL_EFL(  789): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-09 00:48:22.533+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-09 00:48:22.644+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-09 00:48:22.644+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-09 00:48:23.815+0900 E/PKGMGR_SERVER( 6648): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-09 00:48:24.095+0900 E/PKGMGR_SERVER( 6648): pkgmgr-server.c: sighandler(417) > child NORMAL exit [6651]
04-09 00:48:24.986+0900 E/PKGMGR  ( 6699): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-09 00:48:25.016+0900 E/PKGMGR_SERVER( 6648): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-09 00:48:25.026+0900 E/PKGMGR_INFO( 6648): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-09 00:48:25.036+0900 E/rpm-installer( 6648): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-09 00:48:25.036+0900 E/PKGMGR_SERVER( 6648): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-09 00:48:25.046+0900 E/PKGMGR  ( 6699): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[66990002]
04-09 00:48:25.166+0900 E/PKGMGR_INSTALLER( 6701): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-09 00:48:25.166+0900 E/rpm-installer( 6701): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-09 00:48:25.176+0900 E/rpm-installer( 6701): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-09 00:48:25.176+0900 E/rpm-installer( 6701): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-09 00:48:25.176+0900 E/rpm-installer( 6701): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-09 00:48:25.176+0900 E/rpm-installer( 6701): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-09 00:48:25.176+0900 E/rpm-installer( 6701): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-09 00:48:25.226+0900 W/CERT_SVC_VCORE( 6701): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-09 00:48:25.276+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-09 00:48:25.276+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
04-09 00:48:25.286+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-09 00:48:25.286+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [30]
04-09 00:48:25.286+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-09 00:48:25.526+0900 E/rpm-installer( 6701): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-09 00:48:25.526+0900 E/rpm-installer( 6701): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-09 00:48:25.526+0900 E/rpm-installer( 6701): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-09 00:48:25.526+0900 E/rpm-installer( 6701): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-09 00:48:25.526+0900 E/rpm-installer( 6701): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-09 00:48:25.526+0900 E/rpm-installer( 6701): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-09 00:48:25.536+0900 E/PKGMGR_PARSER( 6701): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-09 00:48:25.536+0900 E/PKGMGR_PARSER( 6701): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-09 00:48:25.576+0900 I/PRIVACY-MANAGER-CLIENT( 6701): SocketClient.cpp: SocketClient(37) > Client created
04-09 00:48:25.777+0900 E/PKGMGR_PARSER( 6701): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-09 00:48:25.797+0900 E/PKGMGR_CERT( 6701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-09 00:48:25.797+0900 E/PKGMGR_CERT( 6701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 109
04-09 00:48:25.797+0900 E/PKGMGR_CERT( 6701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 109
04-09 00:48:25.797+0900 E/PKGMGR_CERT( 6701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-09 00:48:25.797+0900 E/PKGMGR_CERT( 6701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 4
04-09 00:48:25.797+0900 E/PKGMGR_CERT( 6701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 4
04-09 00:48:25.797+0900 E/PKGMGR_CERT( 6701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-09 00:48:25.807+0900 E/PKGMGR_SERVER( 6648): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-09 00:48:25.807+0900 E/PKGMGR_CERT( 6701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-09 00:48:25.817+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-09 00:48:25.817+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [60]
04-09 00:48:25.817+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
04-09 00:48:25.827+0900 E/rpm-installer( 6701): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-09 00:48:25.847+0900 E/rpm-installer( 6701): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-09 00:48:25.857+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-09 00:48:25.857+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [100]
04-09 00:48:25.857+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
04-09 00:48:27.708+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-09 00:48:27.708+0900 I/Tizen::App( 1246): (78) > Installation is Completed. [Package = org.example.client]
04-09 00:48:27.708+0900 I/Tizen::App( 1246): (671) > Enter. package(org.example.client), installationResult(0)
04-09 00:48:27.708+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-09 00:48:27.708+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-09 00:48:27.708+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-09 00:48:27.718+0900 I/Tizen::App( 1246): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-09 00:48:27.729+0900 E/PKGMGR_SERVER( 6648): pkgmgr-server.c: sighandler(417) > child NORMAL exit [6701]
04-09 00:48:27.729+0900 I/Tizen::App( 1246): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-09 00:48:27.749+0900 W/ISF_PANEL_EFL(  789): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-09 00:48:27.759+0900 I/Tizen::App( 1246): (416) > appName = [client]
04-09 00:48:27.759+0900 I/Tizen::App( 1246): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-09 00:48:27.759+0900 E/PKGMGR_INFO( 1246): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-09 00:48:27.759+0900 I/Tizen::App( 1246): (683) > Application count(1) in this package
04-09 00:48:27.769+0900 I/Tizen::App( 1246): (840) > Enter.
04-09 00:48:27.769+0900 I/Tizen::App( 1246): (703) > Exit.
04-09 00:48:27.769+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [1]
04-09 00:48:27.769+0900 I/Tizen::App( 1246): (416) > appName = [client]
04-09 00:48:27.769+0900 I/Tizen::App( 1246): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-09 00:48:27.769+0900 I/Tizen::App( 1246): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-09 00:48:27.779+0900 I/Tizen::App( 1246): (131) > Enter
04-09 00:48:27.779+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-09 00:48:27.779+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-09 00:48:27.779+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-09 00:48:27.779+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-09 00:48:27.779+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-09 00:48:27.779+0900 I/Tizen::App( 1246): (137) > org.example.client does not have launch condition
04-09 00:48:27.779+0900 I/Tizen::App( 1246): (883) > Exit.
04-09 00:48:27.789+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-09 00:48:27.789+0900 E/HOME_APPS(  868): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-09 00:48:27.789+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-09 00:48:27.789+0900 W/HOME_APPS(  868): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-09 00:48:27.799+0900 E/util-view(  868): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-09 00:48:27.809+0900 E/PKGMGR_SERVER( 6648): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-09 00:48:27.809+0900 E/PKGMGR_SERVER( 6648): pkgmgr-server.c: main(2471) > package manager server terminated.
04-09 00:48:27.829+0900 W/HOME_APPS(  868): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-09 00:48:30.912+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:48:30.912+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:48:30.912+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:48:30.912+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:48:30.922+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:48:30.922+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:48:30.922+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-09 00:48:30.922+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:48:30.922+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:48:30.922+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:48:30.922+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:48:30.922+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:48:31.893+0900 W/AUL     ( 6757): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-09 00:48:31.893+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
04-09 00:48:31.903+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-09 00:48:31.913+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-09 00:48:31.913+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-09 00:48:31.913+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 6757
04-09 00:48:31.913+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-09 00:48:31.913+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-09 00:48:31.913+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-09 00:48:31.923+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-09 00:48:31.923+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-09 00:48:31.923+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-09 00:48:31.933+0900 I/abc     ( 6408): abc
04-09 00:48:31.933+0900 I/CAPI_APPFW_APPLICATION( 6408): app_main.c: ui_app_main(789) > app_efl_main
04-09 00:48:31.933+0900 I/CAPI_APPFW_APPLICATION( 6408): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-09 00:48:31.963+0900 E/TBM     ( 6408): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-09 00:48:32.023+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6408, appid: org.example.client
04-09 00:48:32.023+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-09 00:48:32.033+0900 W/AUL     ( 6757): launch.c: app_request_to_launchpad(425) > request cmd(0) result(6408)
04-09 00:48:32.233+0900 D/basicui ( 6408): successed to load edc file
04-09 00:48:32.273+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:48:32.273+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:48:32.293+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-09 00:48:32.293+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:48:32.303+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:48:32.313+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:48:32.333+0900 I/MY_LOG  ( 6408): change
04-09 00:48:32.373+0900 I/APP_CORE( 6408): appcore-efl.c: __do_app(514) > [APP 6408] Event: RESET State: CREATED
04-09 00:48:32.373+0900 I/CAPI_APPFW_APPLICATION( 6408): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-09 00:48:32.383+0900 E/EFL     ( 6408): edje<6408> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:48:32.383+0900 E/EFL     ( 6408): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:48:32.393+0900 E/EFL     ( 6408): edje<6408> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:48:32.393+0900 E/EFL     ( 6408): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:48:32.393+0900 E/EFL     ( 6408): edje<6408> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:48:32.393+0900 E/EFL     ( 6408): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:48:32.403+0900 W/APP_CORE( 6408): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6c00002
04-09 00:48:32.403+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-09 00:48:32.523+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-09 00:48:32.523+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-09 00:48:32.533+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-09 00:48:32.533+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-09 00:48:32.533+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-09 00:48:32.533+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-09 00:48:32.533+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6408) status(3)
04-09 00:48:32.533+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-09 00:48:32.533+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-09 00:48:32.533+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(6408)
04-09 00:48:32.533+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6408, appid: org.example.client, status: fg
04-09 00:48:32.533+0900 I/APP_CORE( 6408): appcore-efl.c: __do_app(514) > [APP 6408] Event: RESUME State: CREATED
04-09 00:48:32.543+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-09 00:48:32.543+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-09 00:48:32.543+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: bg
04-09 00:48:32.553+0900 I/APP_CORE( 6408): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-09 00:48:32.553+0900 I/APP_CORE( 6408): appcore-efl.c: __do_app(625) > [APP 6408] Initial Launching, call the resume_cb
04-09 00:48:32.553+0900 I/CAPI_APPFW_APPLICATION( 6408): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:48:32.904+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6408) status(0)
04-09 00:48:33.084+0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-09 00:48:33.084+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 6408.
04-09 00:48:33.094+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.557
04-09 00:48:33.854+0900 I/UXT     ( 6770): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-09 00:48:37.538+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: MEM_FLUSH State: PAUSED
04-09 00:48:41.102+0900 E/EFL     ( 6408): ecore_x<6408> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7658293
04-09 00:48:41.232+0900 E/EFL     ( 6408): ecore_x<6408> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7658426
04-09 00:48:41.292+0900 D/basicui ( 6408): successed to load edc file
04-09 00:48:41.312+0900 I/MY_LOG  ( 6408): change
04-09 00:48:41.322+0900 I/MY_LOG  ( 6408): change
04-09 00:48:41.342+0900 E/VCONF   ( 6408): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-09 00:48:41.342+0900 E/VCONF   ( 6408): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-09 00:48:41.342+0900 E/VCONF   ( 6408): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-09 00:48:41.342+0900 E/VCONF   ( 6408): vconf.c: vconf_get_bool(2729) > vconf_get_bool(6408) : db/ise/keysound error
04-09 00:48:41.342+0900 E/VCONF   ( 6408): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-09 00:48:41.342+0900 E/VCONF   ( 6408): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-09 00:48:41.382+0900 I/MY_LOG  ( 6408): change
04-09 00:48:42.463+0900 E/EFL     ( 6408): ecore_x<6408> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7659652
04-09 00:48:42.463+0900 I/MY_LOG  ( 6408): Button pressed
04-09 00:48:42.563+0900 E/EFL     ( 6408): ecore_x<6408> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7659751
04-09 00:48:42.563+0900 I/MY_LOG  ( 6408): Button unpressed
04-09 00:49:00.971+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(195) > ""
04-09 00:49:00.971+0900 E/UXT     (  682): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:49
04-09 00:49:00.971+0900 I/INDICATOR(  682): clock.c: getTimeFormatted(176) > "time format : 오전 12:49"
04-09 00:49:00.971+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:49"
04-09 00:49:00.971+0900 W/INDICATOR(  682): clock.c: indicator_clock_changed_cb(272) > 
04-09 00:49:00.971+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145566552 Time: <font_size=31> </font_size> <font_size=31> 오전 12:49</font_size></font>"
04-09 00:50:01.000+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(195) > ""
04-09 00:50:01.000+0900 E/UXT     (  682): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:50
04-09 00:50:01.000+0900 I/INDICATOR(  682): clock.c: getTimeFormatted(176) > "time format : 오전 12:50"
04-09 00:50:01.000+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:50"
04-09 00:50:01.010+0900 W/INDICATOR(  682): clock.c: indicator_clock_changed_cb(272) > 
04-09 00:50:01.010+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145552188 Time: <font_size=31> </font_size> <font_size=31> 오전 12:50</font_size></font>"
04-09 00:50:10.639+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:10.649+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(3)
04-09 00:50:10.649+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-09 00:50:10.649+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-09 00:50:10.649+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(868)
04-09 00:50:10.649+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-09 00:50:10.659+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6408 pgid = 6408
04-09 00:50:10.659+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(6408)
04-09 00:50:10.709+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-09 00:50:10.709+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-09 00:50:10.709+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-09 00:50:10.709+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 6408
04-09 00:50:10.709+0900 I/Tizen::App( 1246): (243) > App[org.example.client] pid[6408] terminate event is forwarded
04-09 00:50:10.709+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-09 00:50:10.709+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [org.example.client, 6408, ]
04-09 00:50:10.709+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-09 00:50:10.709+0900 I/Tizen::App( 1246): (506) > TerminatedApp(org.example.client)
04-09 00:50:10.709+0900 I/Tizen::App( 1246): (512) > Not registered pid(6408)
04-09 00:50:10.709+0900 I/Tizen::System( 1246): (246) > Terminated app [org.example.client]
04-09 00:50:10.709+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:50:10.709+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6408
04-09 00:50:10.709+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 6408
04-09 00:50:10.719+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.561
04-09 00:50:10.719+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-09 00:50:10.719+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-09 00:50:10.719+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:50:10.719+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-09 00:50:10.729+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:10.729+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:50:10.729+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for org.example.client, 6408.
04-09 00:50:10.749+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-09 00:50:10.759+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [org.exampl] 
04-09 00:50:10.759+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:50:10.789+0900 E/weather-widget( 1410): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-09 00:50:10.799+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-09 00:50:10.799+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-09 00:50:10.809+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-09 00:50:10.809+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-09 00:50:10.809+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:50:10.819+0900 E/weather-common( 1410): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-09 00:50:10.849+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:50:10.849+0900 W/CRASH_MANAGER( 6784): worker.c: worker_job(1199) > 0606408636c69149166661
