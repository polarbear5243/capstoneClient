S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 14984
Date: 2017-04-06 05:46:08+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 14984, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00003a88
r2   = 0x00000006, r3   = 0xb41094c0
r4   = 0x00000002, r5   = 0xb4109000
r6   = 0xb680309c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f31708
r10  = 0xb7d8a958, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbec6ac2c
lr   = 0xb66f9f18, pc   = 0xb66f8b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     68316 KB
Buffers:     64692 KB
Cached:     284440 KB
VmPeak:     143092 KB
VmSize:     141812 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       37660 KB
VmRSS:       36824 KB
VmData:      53752 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35780 KB
VmPTE:         112 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 14984 TID = 14984
14984 14985 15231 15232 15240 

Maps Information
af22e000 afa2d000 rw-p [stack:15240]
b0fae000 b0fbf000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0fcf000 b0fd4000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b13d6000 b13de000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13f0000 b1bef000 rw-p [stack:15232]
b1bef000 b1bf0000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c00000 b1c14000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c28000 b1c29000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c39000 b1c3c000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c4d000 b1c4e000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c5e000 b1c60000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c70000 b1c72000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c82000 b1c92000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1ca2000 b1cae000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cc0000 b24bf000 rw-p [stack:15231]
b27f0000 b27f7000 r-xp /usr/lib/libefl-extension.so.0.1.0
b280a000 b2810000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2820000 b283c000 r-xp /opt/usr/apps/org.example.client/bin/client
b2995000 b2a78000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2aaf000 b2ad7000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ae9000 b32e8000 rw-p [stack:14985]
b32e8000 b32ea000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32fa000 b3304000 r-xp /lib/libnss_files-2.20-2014.11.so
b3315000 b331e000 r-xp /lib/libnss_nis-2.20-2014.11.so
b332f000 b3340000 r-xp /lib/libnsl-2.20-2014.11.so
b3353000 b3359000 r-xp /lib/libnss_compat-2.20-2014.11.so
b336a000 b336b000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3393000 b339a000 r-xp /usr/lib/libminizip.so.1.0.0
b33aa000 b33af000 r-xp /usr/lib/libstorage.so.0.1
b33bf000 b341e000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3434000 b3448000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3458000 b349c000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34ac000 b34b4000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34c4000 b34f4000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3507000 b35c0000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35d4000 b3627000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3638000 b3653000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3663000 b3724000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3737000 b3747000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3757000 b3764000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3775000 b377c000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b378c000 b37cd000 r-xp /usr/lib/libmdm.so.1.2.12
b37dd000 b37e5000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37f4000 b3804000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3825000 b3885000 r-xp /usr/lib/libasound.so.2.0.0
b3897000 b389a000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38aa000 b38ad000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38bd000 b38c2000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38d2000 b38d3000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38e3000 b38ee000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3902000 b3909000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3919000 b391f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b392f000 b3934000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3944000 b395f000 r-xp /usr/lib/libmmfsound.so.0.1.0
b396f000 b3976000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3986000 b3989000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b399a000 b39c8000 r-xp /usr/lib/libidn.so.11.5.44
b39d8000 b39ee000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39ff000 b3a09000 r-xp /usr/lib/libcares.so.2.1.0
b3a19000 b3a23000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a33000 b3a35000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a45000 b3a46000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a56000 b3a5a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a6b000 b3a93000 r-xp /usr/lib/libui-extension.so.0.1.0
b3aa4000 b3acd000 r-xp /usr/lib/libturbojpeg.so
b3aed000 b3af3000 r-xp /usr/lib/libgif.so.4.1.6
b3b03000 b3b49000 r-xp /usr/lib/libcurl.so.4.3.0
b3b5a000 b3b7b000 r-xp /usr/lib/libexif.so.12.3.3
b3b96000 b3bab000 r-xp /usr/lib/libtts.so
b3bbc000 b3bc4000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bd4000 b3c9a000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cba000 b3db2000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3dd1000 b3e9f000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3eb6000 b3eb8000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ec8000 b3ece000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ede000 b3f01000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f12000 b3f14000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f24000 b3f26000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f37000 b3f3c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f53000 b3f55000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f65000 b3f6c000 r-xp /usr/lib/libsensord-share.so
b3f7c000 b3f94000 r-xp /usr/lib/libsensor.so.1.1.0
b3fa5000 b3fa8000 r-xp /usr/lib/libXv.so.1.0.0
b3fb8000 b3fbd000 r-xp /usr/lib/libutilX.so.1.1.0
b3fcd000 b3fd2000 r-xp /usr/lib/libappcore-common.so.1.1
b3fe2000 b3fe9000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3ffc000 b4000000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4011000 b40ef000 r-xp /usr/lib/libCOREGL.so.4.0
b410f000 b4112000 r-xp /usr/lib/libuuid.so.1.3.0
b4122000 b4139000 r-xp /usr/lib/libblkid.so.1.1.0
b414a000 b414c000 r-xp /usr/lib/libXau.so.6.0.0
b415c000 b41a3000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41b5000 b41bb000 r-xp /usr/lib/libjson-c.so.2.0.1
b41cc000 b41d0000 r-xp /usr/lib/libogg.so.0.7.1
b41e0000 b4202000 r-xp /usr/lib/libvorbis.so.0.4.3
b4212000 b42f6000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4312000 b4315000 r-xp /usr/lib/libEGL.so.1.4
b4326000 b432c000 r-xp /usr/lib/libxcb-render.so.0.0.0
b433c000 b433e000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b434e000 b435b000 r-xp /usr/lib/libGLESv2.so.2.0
b436c000 b43ce000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43e3000 b43fb000 r-xp /usr/lib/libmount.so.1.1.0
b440d000 b4421000 r-xp /usr/lib/libxcb.so.1.1.0
b4431000 b4438000 r-xp /lib/libcrypt-2.20-2014.11.so
b4470000 b4472000 r-xp /usr/lib/libiri.so
b4482000 b448d000 r-xp /usr/lib/libgpg-error.so.0.15.0
b449e000 b44d4000 r-xp /usr/lib/libpulse.so.0.16.2
b44e5000 b4528000 r-xp /usr/lib/libsndfile.so.1.0.25
b453d000 b4552000 r-xp /lib/libexpat.so.1.5.2
b4564000 b4622000 r-xp /usr/lib/libcairo.so.2.11200.14
b4636000 b463e000 r-xp /usr/lib/libdrm.so.2.4.0
b464e000 b4651000 r-xp /usr/lib/libdri2.so.0.0.0
b4661000 b46af000 r-xp /usr/lib/libssl.so.1.0.0
b46c4000 b46d0000 r-xp /usr/lib/libeeze.so.1.13.0
b46e1000 b46ea000 r-xp /usr/lib/libethumb.so.1.13.0
b46fa000 b46fd000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b470d000 b48c4000 r-xp /usr/lib/libcrypto.so.1.0.0
b56af000 b56b8000 r-xp /usr/lib/libXi.so.6.1.0
b56c8000 b56ca000 r-xp /usr/lib/libXgesture.so.7.0.0
b56da000 b56de000 r-xp /usr/lib/libXtst.so.6.1.0
b56ee000 b56f4000 r-xp /usr/lib/libXrender.so.1.3.0
b5704000 b570a000 r-xp /usr/lib/libXrandr.so.2.2.0
b571a000 b571c000 r-xp /usr/lib/libXinerama.so.1.0.0
b572d000 b5730000 r-xp /usr/lib/libXfixes.so.3.1.0
b5740000 b574b000 r-xp /usr/lib/libXext.so.6.4.0
b575b000 b575d000 r-xp /usr/lib/libXdamage.so.1.1.0
b576d000 b576f000 r-xp /usr/lib/libXcomposite.so.1.0.0
b577f000 b5861000 r-xp /usr/lib/libX11.so.6.3.0
b5875000 b587c000 r-xp /usr/lib/libXcursor.so.1.0.2
b588c000 b58a4000 r-xp /usr/lib/libudev.so.1.6.0
b58a6000 b58a9000 r-xp /lib/libattr.so.1.1.0
b58b9000 b58d9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58da000 b58df000 r-xp /usr/lib/libffi.so.6.0.2
b58f0000 b5908000 r-xp /lib/libz.so.1.2.8
b5918000 b591a000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b592a000 b59ff000 r-xp /usr/lib/libxml2.so.2.9.2
b5a14000 b5aaf000 r-xp /usr/lib/libstdc++.so.6.0.20
b5acb000 b5ace000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ade000 b5af7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b08000 b5b19000 r-xp /lib/libresolv-2.20-2014.11.so
b5b2d000 b5ba7000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bbc000 b5bbe000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bce000 b5bd5000 r-xp /usr/lib/libembryo.so.1.13.0
b5be5000 b5bef000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c00000 b5c18000 r-xp /usr/lib/libpng12.so.0.50.0
b5c29000 b5c4c000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c6d000 b5c81000 r-xp /usr/lib/libector.so.1.13.0
b5c92000 b5caa000 r-xp /usr/lib/liblua-5.1.so
b5cbb000 b5d12000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d26000 b5d4e000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d5f000 b5d72000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d83000 b5dbd000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dce000 b5ddc000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dec000 b5df4000 r-xp /usr/lib/libtbm.so.1.0.0
b5e04000 b5e11000 r-xp /usr/lib/libeio.so.1.13.0
b5e21000 b5e23000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e33000 b5e38000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e48000 b5e5f000 r-xp /usr/lib/libefreet.so.1.13.0
b5e71000 b5e91000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ea1000 b5ec1000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ec3000 b5ec9000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ed9000 b5eea000 r-xp /usr/lib/libemotion.so.1.13.0
b5efb000 b5f02000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f12000 b5f21000 r-xp /usr/lib/libeo.so.1.13.0
b5f32000 b5f44000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f55000 b5f5a000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f6a000 b5f83000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f93000 b5fb0000 r-xp /usr/lib/libeet.so.1.13.0
b5fc9000 b6011000 r-xp /usr/lib/libeina.so.1.13.0
b6022000 b6032000 r-xp /usr/lib/libefl.so.1.13.0
b6043000 b6128000 r-xp /usr/lib/libicuuc.so.51.1
b6145000 b6285000 r-xp /usr/lib/libicui18n.so.51.1
b629c000 b62d4000 r-xp /usr/lib/libecore_x.so.1.13.0
b62e6000 b62e9000 r-xp /lib/libcap.so.2.21
b62f9000 b6322000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6333000 b633a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b634c000 b6383000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6394000 b647f000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6492000 b650b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b651d000 b6522000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6532000 b653c000 r-xp /usr/lib/libvconf.so.0.2.45
b654c000 b654e000 r-xp /usr/lib/libvasum.so.0.3.1
b655e000 b6560000 r-xp /usr/lib/libttrace.so.1.1
b6570000 b6573000 r-xp /usr/lib/libiniparser.so.0
b6583000 b65a9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65b9000 b65be000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65cf000 b65e6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65f7000 b6662000 r-xp /lib/libm-2.20-2014.11.so
b6673000 b6679000 r-xp /lib/librt-2.20-2014.11.so
b668a000 b6697000 r-xp /usr/lib/libunwind.so.8.0.1
b66cd000 b67f1000 r-xp /lib/libc-2.20-2014.11.so
b6806000 b681f000 r-xp /lib/libgcc_s-4.9.so.1
b682f000 b6911000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6922000 b694c000 r-xp /usr/lib/libdbus-1.so.3.8.12
b695d000 b6999000 r-xp /usr/lib/libsystemd.so.0.4.0
b699b000 b6a1e000 r-xp /usr/lib/libedje.so.1.13.0
b6a31000 b6a4f000 r-xp /usr/lib/libecore.so.1.13.0
b6a6f000 b6bf6000 r-xp /usr/lib/libevas.so.1.13.0
b6c2b000 b6c3f000 r-xp /lib/libpthread-2.20-2014.11.so
b6c53000 b6e87000 r-xp /usr/lib/libelementary.so.1.13.0
b6eb6000 b6eba000 r-xp /usr/lib/libsmack.so.1.0.0
b6eca000 b6ed1000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ee1000 b6ee3000 r-xp /usr/lib/libdlog.so.0.0.0
b6ef3000 b6ef6000 r-xp /usr/lib/libbundle.so.0.1.22
b6f06000 b6f08000 r-xp /lib/libdl-2.20-2014.11.so
b6f19000 b6f31000 r-xp /usr/lib/libaul.so.0.1.0
b6f45000 b6f4a000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f5b000 b6f68000 r-xp /usr/lib/liblptcp.so
b6f7a000 b6f7e000 r-xp /usr/lib/libsys-assert.so
b6f8f000 b6faf000 r-xp /lib/ld-2.20-2014.11.so
b6fc0000 b6fc5000 r-xp /usr/bin/launchpad-loader
b7a07000 b836a000 rw-p [heap]
bec4b000 bec6c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14984)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66f8b84) [/lib/libc.so.6] + 0x2bb84
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
iftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
04-06 05:45:18.282+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:18.312+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:18.452+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223037812
04-06 05:45:18.452+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223037812
04-06 05:45:18.472+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: prediction_gen_timer(159) > [0;36mprediction_gen_timer[0m
04-06 05:45:18.532+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Generate_prediction_TH(1695) > [0;36mGen prediction[0m
04-06 05:45:18.532+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: prediction_gen_thread(144) > [0;36mpredic gen set [1][0m
04-06 05:45:18.552+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(851) status(0)
04-06 05:45:18.552+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223037911
04-06 05:45:18.552+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[416]  Y[314] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:18.552+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 70[0m
04-06 05:45:18.562+0900 W/CANDIDATE(  851): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-06 05:45:18.562+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
04-06 05:45:18.562+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:18.562+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-06 05:45:18.562+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:18.562+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:18.562+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:18.562+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:18.572+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:18.572+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:18.572+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:18.572+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:18.572+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 10, line_count = 2[0m
04-06 05:45:18.582+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:18.612+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
04-06 05:45:18.652+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:18.682+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:18.742+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223038100
04-06 05:45:18.742+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223038100
04-06 05:45:18.842+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(851) status(0)
04-06 05:45:18.852+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223038210
04-06 05:45:18.852+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[211]  Y[308] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:18.872+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: prediction_gen_timer(159) > [0;36mprediction_gen_timer[0m
04-06 05:45:18.872+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:18.882+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Generate_prediction_TH(1695) > [0;36mGen prediction[0m
04-06 05:45:18.882+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: prediction_gen_thread(144) > [0;36mpredic gen set [1][0m
04-06 05:45:18.902+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
04-06 05:45:18.902+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:18.902+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:18.902+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 70[0m
04-06 05:45:19.153+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: prediction_gen_timer(159) > [0;36mprediction_gen_timer[0m
04-06 05:45:19.173+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Generate_prediction_TH(1695) > [0;36mGen prediction[0m
04-06 05:45:19.173+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: prediction_gen_thread(144) > [0;36mpredic gen set [1][0m
04-06 05:45:19.193+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 70[0m
04-06 05:45:19.193+0900 W/CANDIDATE(  851): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-06 05:45:19.193+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
04-06 05:45:19.193+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:19.193+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-06 05:45:19.193+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:19.193+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:19.203+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:19.203+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:19.203+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:19.203+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:19.203+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:19.203+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:19.203+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
04-06 05:45:19.213+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223038575
04-06 05:45:19.223+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223038575
04-06 05:45:19.343+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223038696
04-06 05:45:19.343+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[97]  Y[222] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:19.343+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:19.343+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
04-06 05:45:19.343+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:19.353+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:19.353+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(851) status(0)
04-06 05:45:19.583+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223038939
04-06 05:45:19.583+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223038939
04-06 05:45:19.593+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: prediction_gen_timer(159) > [0;36mprediction_gen_timer[0m
04-06 05:45:19.613+0900 W/EFL     (  351): e<351> e_border.c:1220 e_border_new() EEEEK! 2 borders with same client window id in them! very bad!
04-06 05:45:19.613+0900 W/EFL     (  351): optimisations failing due to bizarre client behavior. will
04-06 05:45:19.613+0900 W/EFL     (  351): work around.
04-06 05:45:19.613+0900 W/EFL     (  351): bd=0xb7ba5008, bd->references=2, bd->deleted=1, bd->client.win=2800009
04-06 05:45:19.693+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Generate_prediction_TH(1695) > [0;36mGen prediction[0m
04-06 05:45:19.693+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: prediction_gen_thread(144) > [0;36mpredic gen set [1][0m
04-06 05:45:19.723+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223039039
04-06 05:45:19.723+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[414]  Y[313] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:19.723+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 70[0m
04-06 05:45:19.733+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:19.733+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
04-06 05:45:19.733+0900 W/CANDIDATE(  851): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-06 05:45:19.733+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:19.733+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:19.743+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
04-06 05:45:19.743+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:19.743+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-06 05:45:19.743+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:19.743+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:19.743+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:19.743+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:19.743+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:19.743+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:19.743+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:19.743+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:19.743+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 10, line_count = 2[0m
04-06 05:45:19.763+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(851) status(0)
04-06 05:45:19.853+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223039216
04-06 05:45:19.853+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223039216
04-06 05:45:19.954+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(851) status(0)
04-06 05:45:19.954+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223039326
04-06 05:45:19.954+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[271]  Y[323] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:19.954+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:19.954+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
04-06 05:45:19.964+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:19.964+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:20.054+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223039426
04-06 05:45:20.054+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223039426
04-06 05:45:20.154+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223039525
04-06 05:45:20.154+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[663]  Y[317] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:20.154+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:20.154+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
04-06 05:45:20.164+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:20.164+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:20.184+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(851) status(0)
04-06 05:45:20.414+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: prediction_gen_timer(159) > [0;36mprediction_gen_timer[0m
04-06 05:45:20.414+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Generate_prediction_TH(1695) > [0;36mGen prediction[0m
04-06 05:45:20.414+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: prediction_gen_thread(144) > [0;36mpredic gen set [1][0m
04-06 05:45:20.424+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 70[0m
04-06 05:45:20.424+0900 W/CANDIDATE(  851): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-06 05:45:20.424+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 3[0m
04-06 05:45:20.424+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:20.424+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-06 05:45:20.424+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:20.424+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:20.424+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 3, line_count = 0[0m
04-06 05:45:20.824+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223040195
04-06 05:45:20.824+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223040195
04-06 05:45:20.924+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(851) status(0)
04-06 05:45:20.944+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223040305
04-06 05:45:20.944+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[53]  Y[315] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:20.944+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:20.954+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
04-06 05:45:20.954+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:20.954+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:21.095+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223040460
04-06 05:45:21.095+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223040460
04-06 05:45:21.185+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223040549
04-06 05:45:21.185+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[671]  Y[517] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:21.185+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:21.185+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:21.195+0900 I/MY_LOG  (14984): change
04-06 05:45:21.205+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:21.215+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-06 05:45:21.975+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223041337
04-06 05:45:21.985+0900 I/MY_LOG  (14984): Button pressed
04-06 05:45:22.066+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223041415
04-06 05:45:22.066+0900 I/ISE_MULTI(  851): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
04-06 05:45:22.086+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Learn_sentence(2373) > [0;36mDLM write[0m
04-06 05:45:22.306+0900 I/MY_LOG  (14984): Button unpressed
04-06 05:45:22.326+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x6400002 FAILED!
04-06 05:45:24.928+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223044293
04-06 05:45:25.379+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223044745
04-06 05:45:25.549+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223044912
04-06 05:45:25.799+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223045155
04-06 05:45:25.999+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223045365
04-06 05:45:26.240+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223045608
04-06 05:45:26.790+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223046156
04-06 05:45:26.880+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223046244
04-06 05:45:26.900+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x6400002 FAILED!
04-06 05:45:26.900+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x6400002 FAILED!
04-06 05:45:26.900+0900 I/ISE_MULTI(  851): isemain.cpp: slot_set_caps_mode(1028) > [0;36m[hidden state:true] mode=0[0m
04-06 05:45:26.910+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
04-06 05:45:26.950+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
04-06 05:45:26.950+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
04-06 05:45:26.950+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
04-06 05:45:26.950+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
04-06 05:45:26.950+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
04-06 05:45:26.960+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
04-06 05:45:27.000+0900 W/CANDIDATE(  851): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-06 05:45:27.000+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
04-06 05:45:27.000+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 3[0m
04-06 05:45:27.000+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.000+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-06 05:45:27.000+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.000+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.000+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 3, line_count = 0[0m
04-06 05:45:27.010+0900 E/ISE_MULTI(  851): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 577  rect->height : 577[0m
04-06 05:45:27.010+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
04-06 05:45:27.010+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-06 05:45:27.050+0900 I/ISE_MULTI(  851): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-06 05:45:27.131+0900 W/CANDIDATE(  851): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-06 05:45:27.141+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 1[0m
04-06 05:45:27.141+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.141+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 631, total_width = 0[0m
04-06 05:45:27.141+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 1, line_count = 0[0m
04-06 05:45:27.141+0900 I/ISE_MULTI(  851): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=3[0m
04-06 05:45:27.141+0900 W/CANDIDATE(  851): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-06 05:45:27.151+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 1[0m
04-06 05:45:27.151+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.151+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 631, total_width = 0[0m
04-06 05:45:27.151+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 1, line_count = 0[0m
04-06 05:45:27.231+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(851) status(3)
04-06 05:45:27.271+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
04-06 05:45:27.271+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
04-06 05:45:27.621+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223046983
04-06 05:45:27.621+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223046983
04-06 05:45:27.621+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[667]  Y[421] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:27.631+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:27.631+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:27.641+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
04-06 05:45:27.661+0900 I/MY_LOG  (14984): change
04-06 05:45:27.671+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:27.671+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-06 05:45:27.671+0900 W/CANDIDATE(  851): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.681+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 10, line_count = 2[0m
04-06 05:45:27.731+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223047083
04-06 05:45:27.731+0900 I/ISE_MULTI(  851): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=2[0m
04-06 05:45:27.841+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223047204
04-06 05:45:27.841+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223047204
04-06 05:45:27.851+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[659]  Y[419] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:27.851+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:27.851+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:27.861+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
04-06 05:45:27.871+0900 I/MY_LOG  (14984): change
04-06 05:45:27.871+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:27.871+0900 W/CANDIDATE(  851): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-06 05:45:27.871+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-06 05:45:27.881+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
04-06 05:45:27.881+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.881+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-06 05:45:27.881+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.881+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.881+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.881+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.881+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.891+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.891+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.891+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.891+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
04-06 05:45:27.901+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223047226
04-06 05:45:27.911+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223047271
04-06 05:45:27.911+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223047271
04-06 05:45:27.921+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[660]  Y[423] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:27.921+0900 I/ISE_MULTI(  851): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=1[0m
04-06 05:45:27.931+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:27.931+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:27.971+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
04-06 05:45:27.971+0900 W/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
04-06 05:45:27.971+0900 I/MY_LOG  (14984): change
04-06 05:45:27.971+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:27.981+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-06 05:45:27.981+0900 I/ISE_MULTI(  851): isemain.cpp: slot_set_caps_mode(1028) > [0;36m[hidden state:false] mode=1[0m
04-06 05:45:27.981+0900 W/CANDIDATE(  851): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-06 05:45:27.991+0900 W/CANDIDATE(  851): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
04-06 05:45:28.021+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223047381
04-06 05:45:28.021+0900 I/ISE_MULTI(  851): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
04-06 05:45:28.071+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223047436
04-06 05:45:28.071+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223047436
04-06 05:45:28.081+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[658]  Y[434] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:28.081+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:28.081+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:28.081+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:28.081+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-06 05:45:28.151+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223047513
04-06 05:45:28.192+0900 E/EFL     (  351): ecore_x<351> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223047548
04-06 05:45:28.192+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223047548
04-06 05:45:28.202+0900 E/ISE_MULTI(  851): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[662]  Y[439] aspect ratio is x[1.000000] y[1.000000][0m
04-06 05:45:28.202+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
04-06 05:45:28.202+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
04-06 05:45:28.202+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
04-06 05:45:28.212+0900 I/SWIFTKEY(  695): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-06 05:45:28.212+0900 E/EFL     (  851): ecore_x<851> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223047569
04-06 05:45:28.702+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223048058
04-06 05:45:28.702+0900 I/MY_LOG  (14984): Button pressed
04-06 05:45:28.792+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223048145
04-06 05:45:28.792+0900 I/ISE_MULTI(  851): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
04-06 05:45:28.802+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Learn_sentence(2373) > [0;36mDLM write[0m
04-06 05:45:28.862+0900 I/MY_LOG  (14984): Button unpressed
04-06 05:45:28.882+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x6400002 FAILED!
04-06 05:45:30.484+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223049849
04-06 05:45:30.664+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223050026
04-06 05:45:31.094+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223050454
04-06 05:45:31.194+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223050553
04-06 05:45:31.875+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223051237
04-06 05:45:32.035+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223051391
04-06 05:45:32.576+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223051924
04-06 05:45:32.756+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223052101
04-06 05:45:33.517+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223052859
04-06 05:45:33.957+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223053311
04-06 05:45:34.207+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223053554
04-06 05:45:34.828+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223054172
04-06 05:45:36.029+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:45:36.029+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:45:59.072+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:46:00.403+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-06 05:46:00.403+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 5:46
04-06 05:46:00.403+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 5:46"
04-06 05:46:00.403+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 5:46"
04-06 05:46:00.403+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-06 05:46:00.403+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145782436 Time: <font_size=31> </font_size> <font_size=31> 오전 5:46</font_size></font>"
04-06 05:46:06.048+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223085415
04-06 05:46:06.048+0900 I/MY_LOG  (14984): Button pressed
04-06 05:46:06.119+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223085481
04-06 05:46:06.119+0900 I/MY_LOG  (14984): Button unpressed
04-06 05:46:06.669+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=223085998
04-06 05:46:06.669+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=223086033
04-06 05:46:06.689+0900 E/EFL     (14984): elementary<14984> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-06 05:46:08.040+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=223086887
04-06 05:46:08.040+0900 E/EFL     (14984): ecore_x<14984> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=223087020
04-06 05:46:08.050+0900 I/MY_LOG  (14984): Button pressed
04-06 05:46:08.050+0900 I/MY_LOG  (14984): Button unpressed
04-06 05:46:08.221+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14984 pgid = 14984
04-06 05:46:08.221+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(14984)
04-06 05:46:08.231+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:08.241+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 05:46:08.241+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:46:08.241+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:46:08.241+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 05:46:08.241+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 05:46:08.271+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 05:46:08.271+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 05:46:08.271+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 05:46:08.281+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 14984
04-06 05:46:08.281+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[14984] terminate event is forwarded
04-06 05:46:08.281+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 05:46:08.281+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 14984, ]
04-06 05:46:08.281+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 05:46:08.281+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 05:46:08.281+0900 I/Tizen::App( 1231): (512) > Not registered pid(14984)
04-06 05:46:08.281+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 05:46:08.281+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:08.281+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14984
04-06 05:46:08.281+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 14984
04-06 05:46:08.281+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2358
04-06 05:46:08.291+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 05:46:08.291+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:08.291+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 14984.
04-06 05:46:08.311+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 05:46:08.311+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:46:08.311+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 05:46:08.311+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:46:08.341+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 05:46:08.341+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 05:46:08.341+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:46:08.361+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:46:08.371+0900 W/CRASH_MANAGER(15286): worker.c: worker_job(1199) > 0614984636c69149142516
