S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 19086
Date: 2017-06-02 20:13:20+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 19086, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00004a8e
r2   = 0x00000006, r3   = 0xb41394c0
r4   = 0x00000002, r5   = 0xb4139000
r6   = 0xb683309c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f61708
r10  = 0xb7d73ba8, fp   = 0x80147e45
ip   = 0x00000000, sp   = 0xbec7deb4
lr   = 0xb6729f18, pc   = 0xb6728b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     61784 KB
Buffers:     82184 KB
Cached:     275984 KB
VmPeak:     147716 KB
VmSize:     146576 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       30920 KB
VmRSS:       30380 KB
VmData:      47244 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35860 KB
VmPTE:         106 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 19086 TID = 19086
19086 19087 19101 19102 19110 

Maps Information
ae72e000 aef2d000 rw-p [stack:19110]
b10de000 b10ef000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b10ff000 b1104000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1402000 b140a000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b141c000 b1c1b000 rw-p [stack:19102]
b1c1b000 b1c1c000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c2c000 b1c40000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c54000 b1c55000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c65000 b1c68000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c79000 b1c7a000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c8a000 b1c8c000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c9c000 b1c9e000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1cae000 b1cbe000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1cce000 b1cda000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cec000 b24eb000 rw-p [stack:19101]
b281c000 b2823000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2836000 b283c000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b284c000 b287c000 r-xp /opt/usr/apps/org.example.client/bin/client
b29c5000 b2aa8000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2adf000 b2b07000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b19000 b3318000 rw-p [stack:19087]
b3318000 b331a000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b332a000 b3334000 r-xp /lib/libnss_files-2.20-2014.11.so
b3345000 b334e000 r-xp /lib/libnss_nis-2.20-2014.11.so
b335f000 b3370000 r-xp /lib/libnsl-2.20-2014.11.so
b3383000 b3389000 r-xp /lib/libnss_compat-2.20-2014.11.so
b339a000 b339b000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33c3000 b33ca000 r-xp /usr/lib/libminizip.so.1.0.0
b33da000 b33df000 r-xp /usr/lib/libstorage.so.0.1
b33ef000 b344e000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3464000 b3478000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3488000 b34cc000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34dc000 b34e4000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34f4000 b3524000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3537000 b35f0000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3604000 b3657000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3668000 b3683000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3693000 b3754000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3767000 b3777000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3787000 b3794000 r-xp /usr/lib/libmdm-common.so.1.0.98
b37a5000 b37ac000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b37bc000 b37fd000 r-xp /usr/lib/libmdm.so.1.2.12
b380d000 b3815000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3824000 b3834000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3855000 b38b5000 r-xp /usr/lib/libasound.so.2.0.0
b38c7000 b38ca000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38da000 b38dd000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38ed000 b38f2000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3902000 b3903000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3913000 b391e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3932000 b3939000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3949000 b394f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b395f000 b3964000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3974000 b398f000 r-xp /usr/lib/libmmfsound.so.0.1.0
b399f000 b39a6000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b39b6000 b39b9000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39ca000 b39f8000 r-xp /usr/lib/libidn.so.11.5.44
b3a08000 b3a1e000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a2f000 b3a39000 r-xp /usr/lib/libcares.so.2.1.0
b3a49000 b3a53000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a63000 b3a65000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a75000 b3a76000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a86000 b3a8a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a9b000 b3ac3000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ad4000 b3afd000 r-xp /usr/lib/libturbojpeg.so
b3b1d000 b3b23000 r-xp /usr/lib/libgif.so.4.1.6
b3b33000 b3b79000 r-xp /usr/lib/libcurl.so.4.3.0
b3b8a000 b3bab000 r-xp /usr/lib/libexif.so.12.3.3
b3bc6000 b3bdb000 r-xp /usr/lib/libtts.so
b3bec000 b3bf4000 r-xp /usr/lib/libfeedback.so.0.1.4
b3c04000 b3cca000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cea000 b3de2000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3e01000 b3ecf000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ee6000 b3ee8000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ef8000 b3efe000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3f0e000 b3f31000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f42000 b3f44000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f54000 b3f56000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f67000 b3f6c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f83000 b3f85000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f95000 b3f9c000 r-xp /usr/lib/libsensord-share.so
b3fac000 b3fc4000 r-xp /usr/lib/libsensor.so.1.1.0
b3fd5000 b3fd8000 r-xp /usr/lib/libXv.so.1.0.0
b3fe8000 b3fed000 r-xp /usr/lib/libutilX.so.1.1.0
b3ffd000 b4002000 r-xp /usr/lib/libappcore-common.so.1.1
b4012000 b4019000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b402c000 b4030000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4041000 b411f000 r-xp /usr/lib/libCOREGL.so.4.0
b413f000 b4142000 r-xp /usr/lib/libuuid.so.1.3.0
b4152000 b4169000 r-xp /usr/lib/libblkid.so.1.1.0
b417a000 b417c000 r-xp /usr/lib/libXau.so.6.0.0
b418c000 b41d3000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41e5000 b41eb000 r-xp /usr/lib/libjson-c.so.2.0.1
b41fc000 b4200000 r-xp /usr/lib/libogg.so.0.7.1
b4210000 b4232000 r-xp /usr/lib/libvorbis.so.0.4.3
b4242000 b4326000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4342000 b4345000 r-xp /usr/lib/libEGL.so.1.4
b4356000 b435c000 r-xp /usr/lib/libxcb-render.so.0.0.0
b436c000 b436e000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b437e000 b438b000 r-xp /usr/lib/libGLESv2.so.2.0
b439c000 b43fe000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4413000 b442b000 r-xp /usr/lib/libmount.so.1.1.0
b443d000 b4451000 r-xp /usr/lib/libxcb.so.1.1.0
b4461000 b4468000 r-xp /lib/libcrypt-2.20-2014.11.so
b44a0000 b44a2000 r-xp /usr/lib/libiri.so
b44b2000 b44bd000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44ce000 b4504000 r-xp /usr/lib/libpulse.so.0.16.2
b4515000 b4558000 r-xp /usr/lib/libsndfile.so.1.0.25
b456d000 b4582000 r-xp /lib/libexpat.so.1.5.2
b4594000 b4652000 r-xp /usr/lib/libcairo.so.2.11200.14
b4666000 b466e000 r-xp /usr/lib/libdrm.so.2.4.0
b467e000 b4681000 r-xp /usr/lib/libdri2.so.0.0.0
b4691000 b46df000 r-xp /usr/lib/libssl.so.1.0.0
b46f4000 b4700000 r-xp /usr/lib/libeeze.so.1.13.0
b4711000 b471a000 r-xp /usr/lib/libethumb.so.1.13.0
b472a000 b472d000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b473d000 b48f4000 r-xp /usr/lib/libcrypto.so.1.0.0
b56df000 b56e8000 r-xp /usr/lib/libXi.so.6.1.0
b56f8000 b56fa000 r-xp /usr/lib/libXgesture.so.7.0.0
b570a000 b570e000 r-xp /usr/lib/libXtst.so.6.1.0
b571e000 b5724000 r-xp /usr/lib/libXrender.so.1.3.0
b5734000 b573a000 r-xp /usr/lib/libXrandr.so.2.2.0
b574a000 b574c000 r-xp /usr/lib/libXinerama.so.1.0.0
b575d000 b5760000 r-xp /usr/lib/libXfixes.so.3.1.0
b5770000 b577b000 r-xp /usr/lib/libXext.so.6.4.0
b578b000 b578d000 r-xp /usr/lib/libXdamage.so.1.1.0
b579d000 b579f000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57af000 b5891000 r-xp /usr/lib/libX11.so.6.3.0
b58a5000 b58ac000 r-xp /usr/lib/libXcursor.so.1.0.2
b58bc000 b58d4000 r-xp /usr/lib/libudev.so.1.6.0
b58d6000 b58d9000 r-xp /lib/libattr.so.1.1.0
b58e9000 b5909000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b590a000 b590f000 r-xp /usr/lib/libffi.so.6.0.2
b5920000 b5938000 r-xp /lib/libz.so.1.2.8
b5948000 b594a000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b595a000 b5a2f000 r-xp /usr/lib/libxml2.so.2.9.2
b5a44000 b5adf000 r-xp /usr/lib/libstdc++.so.6.0.20
b5afb000 b5afe000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b0e000 b5b27000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b38000 b5b49000 r-xp /lib/libresolv-2.20-2014.11.so
b5b5d000 b5bd7000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bec000 b5bee000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bfe000 b5c05000 r-xp /usr/lib/libembryo.so.1.13.0
b5c15000 b5c1f000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c30000 b5c48000 r-xp /usr/lib/libpng12.so.0.50.0
b5c59000 b5c7c000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c9d000 b5cb1000 r-xp /usr/lib/libector.so.1.13.0
b5cc2000 b5cda000 r-xp /usr/lib/liblua-5.1.so
b5ceb000 b5d42000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d56000 b5d7e000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d8f000 b5da2000 r-xp /usr/lib/libfribidi.so.0.3.1
b5db3000 b5ded000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dfe000 b5e0c000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e1c000 b5e24000 r-xp /usr/lib/libtbm.so.1.0.0
b5e34000 b5e41000 r-xp /usr/lib/libeio.so.1.13.0
b5e51000 b5e53000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e63000 b5e68000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e78000 b5e8f000 r-xp /usr/lib/libefreet.so.1.13.0
b5ea1000 b5ec1000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ed1000 b5ef1000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ef3000 b5ef9000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f09000 b5f1a000 r-xp /usr/lib/libemotion.so.1.13.0
b5f2b000 b5f32000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f42000 b5f51000 r-xp /usr/lib/libeo.so.1.13.0
b5f62000 b5f74000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f85000 b5f8a000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f9a000 b5fb3000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fc3000 b5fe0000 r-xp /usr/lib/libeet.so.1.13.0
b5ff9000 b6041000 r-xp /usr/lib/libeina.so.1.13.0
b6052000 b6062000 r-xp /usr/lib/libefl.so.1.13.0
b6073000 b6158000 r-xp /usr/lib/libicuuc.so.51.1
b6175000 b62b5000 r-xp /usr/lib/libicui18n.so.51.1
b62cc000 b6304000 r-xp /usr/lib/libecore_x.so.1.13.0
b6316000 b6319000 r-xp /lib/libcap.so.2.21
b6329000 b6352000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6363000 b636a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b637c000 b63b3000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63c4000 b64af000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64c2000 b653b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b654d000 b6552000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6562000 b656c000 r-xp /usr/lib/libvconf.so.0.2.45
b657c000 b657e000 r-xp /usr/lib/libvasum.so.0.3.1
b658e000 b6590000 r-xp /usr/lib/libttrace.so.1.1
b65a0000 b65a3000 r-xp /usr/lib/libiniparser.so.0
b65b3000 b65d9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65e9000 b65ee000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65ff000 b6616000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6627000 b6692000 r-xp /lib/libm-2.20-2014.11.so
b66a3000 b66a9000 r-xp /lib/librt-2.20-2014.11.so
b66ba000 b66c7000 r-xp /usr/lib/libunwind.so.8.0.1
b66fd000 b6821000 r-xp /lib/libc-2.20-2014.11.so
b6836000 b684f000 r-xp /lib/libgcc_s-4.9.so.1
b685f000 b6941000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6952000 b697c000 r-xp /usr/lib/libdbus-1.so.3.8.12
b698d000 b69c9000 r-xp /usr/lib/libsystemd.so.0.4.0
b69cb000 b6a4e000 r-xp /usr/lib/libedje.so.1.13.0
b6a61000 b6a7f000 r-xp /usr/lib/libecore.so.1.13.0
b6a9f000 b6c26000 r-xp /usr/lib/libevas.so.1.13.0
b6c5b000 b6c6f000 r-xp /lib/libpthread-2.20-2014.11.so
b6c83000 b6eb7000 r-xp /usr/lib/libelementary.so.1.13.0
b6ee6000 b6eea000 r-xp /usr/lib/libsmack.so.1.0.0
b6efa000 b6f01000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f11000 b6f13000 r-xp /usr/lib/libdlog.so.0.0.0
b6f23000 b6f26000 r-xp /usr/lib/libbundle.so.0.1.22
b6f36000 b6f38000 r-xp /lib/libdl-2.20-2014.11.so
b6f49000 b6f61000 r-xp /usr/lib/libaul.so.0.1.0
b6f75000 b6f7a000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f8b000 b6f98000 r-xp /usr/lib/liblptcp.so
b6faa000 b6fae000 r-xp /usr/lib/libsys-assert.so
b6fbf000 b6fdf000 r-xp /lib/ld-2.20-2014.11.so
b6ff0000 b6ff5000 r-xp /usr/bin/launchpad-loader
b791b000 b7e2d000 rw-p [heap]
bec5e000 bec7f000 rw-p [stack]
b791b000 b7e2d000 rw-p [heap]
bec5e000 bec7f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19086)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6728b84) [/lib/libc.so.6] + 0x2bb84
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
__find_op_cbinfo(312) > tmp is NULL
06-02 20:12:35.471+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:35.471+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:35.471+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:35.471+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:35.471+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:35.471+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:35.471+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:35.471+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:35.471+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:35.471+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:35.471+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:35.471+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:35.481+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:35.481+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:35.481+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:36.842+0900 E/PKGMGR_SERVER(19015): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-02 20:12:37.292+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-02 20:12:37.292+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-02 20:12:37.292+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-02 20:12:37.292+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
06-02 20:12:37.292+0900 I/Tizen::App( 1233): (78) > Installation is Completed. [Package = org.example.client]
06-02 20:12:37.292+0900 I/Tizen::App( 1233): (671) > Enter. package(org.example.client), installationResult(0)
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.292+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:12:37.312+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-02 20:12:37.322+0900 I/Tizen::App( 1233): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
06-02 20:12:37.332+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
06-02 20:12:37.332+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
06-02 20:12:37.332+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-02 20:12:37.332+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-02 20:12:37.332+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
06-02 20:12:37.342+0900 I/Tizen::App( 1233): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
06-02 20:12:37.352+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
06-02 20:12:37.352+0900 E/HOME_APPS(  867): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
06-02 20:12:37.352+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
06-02 20:12:37.352+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
06-02 20:12:37.363+0900 I/Tizen::App( 1233): (416) > appName = [client]
06-02 20:12:37.363+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-02 20:12:37.363+0900 E/PKGMGR_INFO( 1233): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-02 20:12:37.363+0900 I/Tizen::App( 1233): (683) > Application count(1) in this package
06-02 20:12:37.363+0900 I/Tizen::App( 1233): (840) > Enter.
06-02 20:12:37.363+0900 I/Tizen::App( 1233): (703) > Exit.
06-02 20:12:37.363+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [1]
06-02 20:12:37.373+0900 E/util-view(  867): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-02 20:12:37.373+0900 I/Tizen::App( 1233): (416) > appName = [client]
06-02 20:12:37.373+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-02 20:12:37.373+0900 I/Tizen::App( 1233): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
06-02 20:12:37.373+0900 I/Tizen::App( 1233): (131) > Enter
06-02 20:12:37.373+0900 I/Tizen::App( 1233): (137) > org.example.client does not have launch condition
06-02 20:12:37.373+0900 I/Tizen::App( 1233): (883) > Exit.
06-02 20:12:37.393+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-02 20:12:37.413+0900 E/PKGMGR_SERVER(19015): pkgmgr-server.c: sighandler(417) > child NORMAL exit [19018]
06-02 20:12:38.844+0900 E/PKGMGR_SERVER(19015): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-02 20:12:38.844+0900 E/PKGMGR_SERVER(19015): pkgmgr-server.c: main(2471) > package manager server terminated.
06-02 20:12:41.507+0900 W/AUL     (19072): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-02 20:12:41.507+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
06-02 20:12:41.517+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-02 20:12:41.527+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-02 20:12:41.527+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-02 20:12:41.527+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 19072
06-02 20:12:41.527+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-02 20:12:41.537+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
06-02 20:12:41.537+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-02 20:12:41.537+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
06-02 20:12:41.537+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-02 20:12:41.537+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
06-02 20:12:41.557+0900 I/abc     (17846): abc
06-02 20:12:41.557+0900 I/CAPI_APPFW_APPLICATION(17846): app_main.c: ui_app_main(789) > app_efl_main
06-02 20:12:41.557+0900 I/CAPI_APPFW_APPLICATION(17846): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-02 20:12:41.587+0900 E/TBM     (17846): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-02 20:12:41.637+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 17846, appid: org.example.client
06-02 20:12:41.637+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-02 20:12:41.657+0900 W/AUL     (19072): launch.c: app_request_to_launchpad(425) > request cmd(0) result(17846)
06-02 20:12:41.847+0900 D/basicui (17846): successed to load edc file
06-02 20:12:41.897+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:12:41.897+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:12:41.907+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
06-02 20:12:41.917+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:12:41.917+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:12:41.927+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 20:12:41.997+0900 I/MY_LOG  (17846): change
06-02 20:12:42.057+0900 I/APP_CORE(17846): appcore-efl.c: __do_app(514) > [APP 17846] Event: RESET State: CREATED
06-02 20:12:42.057+0900 I/CAPI_APPFW_APPLICATION(17846): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-02 20:12:42.067+0900 E/EFL     (17846): edje<17846> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 20:12:42.067+0900 E/EFL     (17846): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:12:42.067+0900 E/EFL     (17846): edje<17846> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 20:12:42.067+0900 E/EFL     (17846): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:12:42.077+0900 E/EFL     (17846): edje<17846> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 20:12:42.077+0900 E/EFL     (17846): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:12:42.077+0900 I/MY_LOG  (17846): change
06-02 20:12:42.087+0900 W/APP_CORE(17846): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5c00002
06-02 20:12:42.087+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-02 20:12:42.187+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-02 20:12:42.187+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-02 20:12:42.187+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-02 20:12:42.187+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-02 20:12:42.187+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-02 20:12:42.187+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-02 20:12:42.187+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(17846) status(3)
06-02 20:12:42.187+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:12:42.187+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:12:42.187+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(17846)
06-02 20:12:42.187+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 17846, appid: org.example.client, status: fg
06-02 20:12:42.187+0900 I/APP_CORE(17846): appcore-efl.c: __do_app(514) > [APP 17846] Event: RESUME State: CREATED
06-02 20:12:42.207+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-02 20:12:42.207+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-02 20:12:42.207+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-02 20:12:42.207+0900 I/APP_CORE(17846): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-02 20:12:42.207+0900 I/APP_CORE(17846): appcore-efl.c: __do_app(625) > [APP 17846] Initial Launching, call the resume_cb
06-02 20:12:42.207+0900 I/CAPI_APPFW_APPLICATION(17846): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:12:42.548+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(17846) status(0)
06-02 20:12:42.708+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
06-02 20:12:42.708+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 17846.
06-02 20:12:42.708+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2497
06-02 20:12:43.498+0900 I/UXT     (19086): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-02 20:12:44.550+0900 E/EFL     (17846): ecore_x<17846> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=950561662
06-02 20:12:44.550+0900 E/EFL     (17846): ecore_x<17846> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=950561708
06-02 20:12:44.550+0900 I/CAPI_APPFW_APPLICATION(17846): app_main.c: ui_app_exit(800) > ui_app_exit
06-02 20:12:44.550+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 22
06-02 20:12:44.550+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(1201) > app status : 5
06-02 20:12:44.550+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(17846)
06-02 20:12:44.550+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 17846, appid: org.example.client, status: bg
06-02 20:12:44.570+0900 I/TIZEN_N_EFL_UTIL_WINDOW(17846): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 12
06-02 20:12:44.570+0900 E/APP_CORE(17846): appcore-efl.c: _capture_and_make_file(1619) > win[5c00002] widget[720] height[1280]
06-02 20:12:44.570+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 33
06-02 20:12:44.760+0900 I/CAPI_APPFW_APPLICATION(17846): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-02 20:12:44.760+0900 I/CAPI_APPFW_APPLICATION(17846): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-02 20:12:44.770+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:12:44.780+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-02 20:12:44.780+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:12:44.780+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:12:44.780+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-02 20:12:44.780+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-02 20:12:44.800+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-02 20:12:44.840+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:12:44.840+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-02 20:12:44.840+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:12:44.840+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-02 20:12:44.850+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
06-02 20:12:44.850+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:12:44.860+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:12:44.880+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-02 20:12:44.880+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-02 20:12:44.880+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 20:12:44.880+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-02 20:12:44.880+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 20:12:44.880+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 20:12:44.910+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
06-02 20:12:44.930+0900 E/weather-common( 1310): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
06-02 20:12:44.940+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_create(409) > New handle created[0xb816a060]
06-02 20:12:44.940+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_get_type(463) > Connected Network = 2
06-02 20:12:44.940+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_destroy(427) > Destroy handle: 0xb816a060
06-02 20:12:44.940+0900 E/weather-common( 1310): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
06-02 20:12:44.940+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
06-02 20:12:44.940+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-02 20:12:44.940+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-02 20:12:44.940+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: fg
06-02 20:12:45.120+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 17846 pgid = 17846
06-02 20:12:45.120+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(17846)
06-02 20:12:45.150+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-02 20:12:45.150+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-02 20:12:45.150+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
06-02 20:12:45.150+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 17846
06-02 20:12:45.150+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[17846] terminate event is forwarded
06-02 20:12:45.150+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
06-02 20:12:45.150+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 17846, ]
06-02 20:12:45.150+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
06-02 20:12:45.150+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
06-02 20:12:45.150+0900 I/Tizen::App( 1233): (512) > Not registered pid(17846)
06-02 20:12:45.150+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 17846
06-02 20:12:45.150+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
06-02 20:12:45.150+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 17846
06-02 20:12:45.150+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:12:45.160+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2500
06-02 20:12:45.170+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:12:45.170+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.example.client, 17846.
06-02 20:12:46.912+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:12:46.912+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:12:46.912+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:12:46.912+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:12:46.922+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:12:46.922+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:12:46.922+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-02 20:12:46.922+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:12:46.922+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:12:46.922+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:12:46.922+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:12:46.922+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:12:49.554+0900 W/AUL_AMD (  612): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-02 20:12:56.231+0900 E/EFL     (  867): ecore_x<867> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950573394
06-02 20:12:56.341+0900 E/EFL     (  867): ecore_x<867> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950573505
06-02 20:12:56.341+0900 W/AUL     (  867): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
06-02 20:12:56.351+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 1
06-02 20:12:56.351+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 867
06-02 20:12:56.361+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
06-02 20:12:56.361+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-02 20:12:56.361+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
06-02 20:12:56.361+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-02 20:12:56.361+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
06-02 20:12:56.371+0900 I/abc     (19086): abc
06-02 20:12:56.371+0900 I/CAPI_APPFW_APPLICATION(19086): app_main.c: ui_app_main(789) > app_efl_main
06-02 20:12:56.371+0900 I/CAPI_APPFW_APPLICATION(19086): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-02 20:12:56.401+0900 E/TBM     (19086): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-02 20:12:56.461+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 19086, appid: org.example.client
06-02 20:12:56.461+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-02 20:12:56.471+0900 W/AUL     (  867): launch.c: app_request_to_launchpad(425) > request cmd(1) result(19086)
06-02 20:12:56.631+0900 D/basicui (19086): successed to load edc file
06-02 20:12:56.661+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:12:56.661+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:12:56.681+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
06-02 20:12:56.681+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:12:56.691+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:12:56.691+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 20:12:56.771+0900 I/MY_LOG  (19086): change
06-02 20:12:56.821+0900 I/APP_CORE(19086): appcore-efl.c: __do_app(514) > [APP 19086] Event: RESET State: CREATED
06-02 20:12:56.821+0900 I/CAPI_APPFW_APPLICATION(19086): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-02 20:12:56.832+0900 E/EFL     (19086): edje<19086> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 20:12:56.832+0900 E/EFL     (19086): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:12:56.832+0900 E/EFL     (19086): edje<19086> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 20:12:56.832+0900 E/EFL     (19086): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:12:56.832+0900 E/EFL     (19086): edje<19086> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 20:12:56.832+0900 E/EFL     (19086): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:12:56.842+0900 I/MY_LOG  (19086): change
06-02 20:12:56.842+0900 W/APP_CORE(19086): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
06-02 20:12:56.842+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-02 20:12:56.962+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-02 20:12:56.962+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-02 20:12:56.962+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-02 20:12:56.962+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-02 20:12:56.962+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-02 20:12:56.962+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-02 20:12:56.962+0900 I/APP_CORE(19086): appcore-efl.c: __do_app(514) > [APP 19086] Event: RESUME State: CREATED
06-02 20:12:56.972+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(19086) status(3)
06-02 20:12:56.972+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(19086)
06-02 20:12:56.972+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 19086, appid: org.example.client, status: fg
06-02 20:12:56.982+0900 I/APP_CORE(19086): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-02 20:12:56.982+0900 I/APP_CORE(19086): appcore-efl.c: __do_app(625) > [APP 19086] Initial Launching, call the resume_cb
06-02 20:12:56.982+0900 I/CAPI_APPFW_APPLICATION(19086): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:12:56.982+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-02 20:12:56.982+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-02 20:12:56.982+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-02 20:12:57.162+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:12:57.162+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:12:57.162+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:12:57.162+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:12:57.162+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:12:57.162+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:12:57.162+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-02 20:12:57.162+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:12:57.162+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:12:57.162+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:12:57.162+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:12:57.162+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:12:57.332+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(19086) status(0)
06-02 20:12:57.532+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2501
06-02 20:12:57.542+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
06-02 20:12:57.542+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 19086.
06-02 20:12:58.313+0900 I/UXT     (19107): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-02 20:12:59.334+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950576491
06-02 20:12:59.334+0900 I/MY_LOG  (19086): Button pressed
06-02 20:12:59.444+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950576603
06-02 20:12:59.454+0900 E/VCONF   (19086): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-02 20:12:59.454+0900 E/VCONF   (19086): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-02 20:12:59.454+0900 E/VCONF   (19086): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-02 20:12:59.454+0900 E/VCONF   (19086): vconf.c: vconf_get_bool(2729) > vconf_get_bool(19086) : db/ise/keysound error
06-02 20:12:59.454+0900 E/VCONF   (19086): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-02 20:12:59.454+0900 E/VCONF   (19086): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-02 20:12:59.504+0900 I/MY_LOG  (19086): Button unpressed
06-02 20:12:59.684+0900 I/MY_LOG  (19086): change
06-02 20:13:00.125+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950577288
06-02 20:13:00.235+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950577399
06-02 20:13:00.285+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-02 20:13:00.285+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 8:13
06-02 20:13:00.285+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 8:13"
06-02 20:13:00.285+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 8:13"
06-02 20:13:00.285+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-02 20:13:00.285+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145929067 Time: <font_size=31> </font_size> <font_size=31> 오후 8:13</font_size></font>"
06-02 20:13:00.575+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950577738
06-02 20:13:00.575+0900 I/MY_LOG  (19086): Button pressed
06-02 20:13:00.685+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950577849
06-02 20:13:00.695+0900 I/MY_LOG  (19086): Button unpressed
06-02 20:13:00.805+0900 I/MY_LOG  (19086): change
06-02 20:13:01.136+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950578304
06-02 20:13:01.266+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950578437
06-02 20:13:01.516+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950578682
06-02 20:13:01.516+0900 I/MY_LOG  (19086): Button pressed
06-02 20:13:01.646+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950578815
06-02 20:13:01.656+0900 I/MY_LOG  (19086): Button unpressed
06-02 20:13:01.776+0900 I/MY_LOG  (19086): change
06-02 20:13:01.957+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-02 20:13:02.087+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950579246
06-02 20:13:02.217+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950579377
06-02 20:13:02.317+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950579478
06-02 20:13:02.437+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950579599
06-02 20:13:02.787+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950579949
06-02 20:13:02.787+0900 I/MY_LOG  (19086): Button pressed
06-02 20:13:02.947+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950580116
06-02 20:13:02.947+0900 E/EFL     (19086): edje<19086> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
06-02 20:13:02.947+0900 E/EFL     (19086): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:13:02.957+0900 I/MY_LOG  (19086): Button unpressed
06-02 20:13:03.118+0900 I/MY_LOG  (19086): change
06-02 20:13:03.418+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950580586
06-02 20:13:03.548+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950580708
06-02 20:13:03.658+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950580819
06-02 20:13:03.768+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950580930
06-02 20:13:04.079+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950581239
06-02 20:13:04.079+0900 I/MY_LOG  (19086): Button pressed
06-02 20:13:04.189+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950581350
06-02 20:13:04.189+0900 I/MY_LOG  (19086): Button unpressed
06-02 20:13:15.750+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950592910
06-02 20:13:15.750+0900 I/MY_LOG  (19086): Button pressed
06-02 20:13:15.880+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950593043
06-02 20:13:15.890+0900 I/MY_LOG  (19086): Button unpressed
06-02 20:13:16.601+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950593759
06-02 20:13:16.601+0900 I/MY_LOG  (19086): Button pressed
06-02 20:13:16.711+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950593869
06-02 20:13:16.711+0900 I/MY_LOG  (19086): Button unpressed
06-02 20:13:16.751+0900 D/basicui (19086): successed to load edc file
06-02 20:13:16.771+0900 E/EFL     (19086): elementary<19086> elm_layout.c:991 _elm_layout_elm_container_content_set() could not swallow 0x8013cbea into part 'swallow_content'
06-02 20:13:19.434+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950596590
06-02 20:13:19.554+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950596712
06-02 20:13:19.604+0900 E/EFL     (19086): edje<19086> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p9';
06-02 20:13:19.604+0900 E/EFL     (19086): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:13:20.845+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950598017
06-02 20:13:20.955+0900 E/EFL     (19086): ecore_x<19086> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950598116
06-02 20:13:21.085+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:13:21.105+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-02 20:13:21.105+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:13:21.105+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:13:21.105+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-02 20:13:21.105+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-02 20:13:21.115+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 19086 pgid = 19086
06-02 20:13:21.115+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(19086)
06-02 20:13:21.125+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-02 20:13:21.155+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:13:21.155+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-02 20:13:21.155+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-02 20:13:21.155+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
06-02 20:13:21.165+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 19086
06-02 20:13:21.165+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 19086
06-02 20:13:21.165+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 19086
06-02 20:13:21.165+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2505
06-02 20:13:21.175+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-02 20:13:21.175+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:13:21.175+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-02 20:13:21.195+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-02 20:13:21.195+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
06-02 20:13:21.195+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:13:21.195+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:13:21.205+0900 E/EFL     (  676): <676> lib/ecore_ipc/ecore_ipc.c:804 ecore_ipc_client_send() safety check failed: !ecore_con_client_connected_get(cl->client) is true
06-02 20:13:21.205+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[19086] terminate event is forwarded
06-02 20:13:21.205+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
06-02 20:13:21.205+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 19086, ]
06-02 20:13:21.205+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
06-02 20:13:21.205+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
06-02 20:13:21.205+0900 I/Tizen::App( 1233): (512) > Not registered pid(19086)
06-02 20:13:21.205+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
06-02 20:13:21.205+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:13:21.205+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:13:21.205+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.example.client, 19086.
06-02 20:13:21.215+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-02 20:13:21.215+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 20:13:21.215+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-02 20:13:21.215+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 20:13:21.215+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 20:13:21.245+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
06-02 20:13:21.275+0900 E/weather-common( 1310): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
06-02 20:13:21.285+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_create(409) > New handle created[0xb829e400]
06-02 20:13:21.285+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_get_type(463) > Connected Network = 2
06-02 20:13:21.285+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_destroy(427) > Destroy handle: 0xb829e400
06-02 20:13:21.285+0900 E/weather-common( 1310): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
06-02 20:13:21.295+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
06-02 20:13:21.295+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-02 20:13:21.295+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-02 20:13:21.295+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: fg
06-02 20:13:21.375+0900 W/CRASH_MANAGER(19113): worker.c: worker_job(1199) > 0619086636c69149640200
