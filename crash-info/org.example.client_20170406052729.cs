S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 12275
Date: 2017-04-06 05:27:29+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 12275, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00002ff3
r2   = 0x00000006, r3   = 0xb41424c0
r4   = 0x00000002, r5   = 0xb4142000
r6   = 0xb683c09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f6a708
r10  = 0xb8bca910, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbe9e5c2c
lr   = 0xb6732f18, pc   = 0xb6731b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     71084 KB
Buffers:     63204 KB
Cached:     290480 KB
VmPeak:     133904 KB
VmSize:     133900 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28320 KB
VmRSS:       28320 KB
VmData:      45844 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35780 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 12275 TID = 12275
12275 12276 12571 12572 12581 

Maps Information
af22e000 afa2d000 rw-p [stack:12581]
b0fe8000 b0ff9000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1009000 b100e000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1410000 b1418000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b142a000 b1c29000 rw-p [stack:12572]
b1c29000 b1c2a000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c3a000 b1c4e000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c62000 b1c63000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c73000 b1c76000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c87000 b1c88000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c98000 b1c9a000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1caa000 b1cac000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1cbc000 b1ccc000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1cdc000 b1ce8000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cfa000 b24f9000 rw-p [stack:12571]
b282a000 b2831000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2844000 b284a000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b285a000 b2876000 r-xp /opt/usr/apps/org.example.client/bin/client
b29ce000 b2ab1000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ae8000 b2b10000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b22000 b3321000 rw-p [stack:12276]
b3321000 b3323000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3333000 b333d000 r-xp /lib/libnss_files-2.20-2014.11.so
b334e000 b3357000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3368000 b3379000 r-xp /lib/libnsl-2.20-2014.11.so
b338c000 b3392000 r-xp /lib/libnss_compat-2.20-2014.11.so
b33a3000 b33a4000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33cc000 b33d3000 r-xp /usr/lib/libminizip.so.1.0.0
b33e3000 b33e8000 r-xp /usr/lib/libstorage.so.0.1
b33f8000 b3457000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b346d000 b3481000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3491000 b34d5000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34e5000 b34ed000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34fd000 b352d000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3540000 b35f9000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b360d000 b3660000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3671000 b368c000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b369c000 b375d000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3770000 b3780000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3790000 b379d000 r-xp /usr/lib/libmdm-common.so.1.0.98
b37ae000 b37b5000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b37c5000 b3806000 r-xp /usr/lib/libmdm.so.1.2.12
b3816000 b381e000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b382d000 b383d000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b385e000 b38be000 r-xp /usr/lib/libasound.so.2.0.0
b38d0000 b38d3000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38e3000 b38e6000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38f6000 b38fb000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b390b000 b390c000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b391c000 b3927000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b393b000 b3942000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3952000 b3958000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3968000 b396d000 r-xp /usr/lib/libmmfsession.so.0.0.1
b397d000 b3998000 r-xp /usr/lib/libmmfsound.so.0.1.0
b39a8000 b39af000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b39bf000 b39c2000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39d3000 b3a01000 r-xp /usr/lib/libidn.so.11.5.44
b3a11000 b3a27000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a38000 b3a42000 r-xp /usr/lib/libcares.so.2.1.0
b3a52000 b3a5c000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a6c000 b3a6e000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a7e000 b3a7f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a8f000 b3a93000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3aa4000 b3acc000 r-xp /usr/lib/libui-extension.so.0.1.0
b3add000 b3b06000 r-xp /usr/lib/libturbojpeg.so
b3b26000 b3b2c000 r-xp /usr/lib/libgif.so.4.1.6
b3b3c000 b3b82000 r-xp /usr/lib/libcurl.so.4.3.0
b3b93000 b3bb4000 r-xp /usr/lib/libexif.so.12.3.3
b3bcf000 b3be4000 r-xp /usr/lib/libtts.so
b3bf5000 b3bfd000 r-xp /usr/lib/libfeedback.so.0.1.4
b3c0d000 b3cd3000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cf3000 b3deb000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3e0a000 b3ed8000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3eef000 b3ef1000 r-xp /usr/lib/libboost_system.so.1.51.0
b3f01000 b3f07000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3f17000 b3f3a000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f4b000 b3f4d000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f5d000 b3f5f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f70000 b3f75000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f8c000 b3f8e000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f9e000 b3fa5000 r-xp /usr/lib/libsensord-share.so
b3fb5000 b3fcd000 r-xp /usr/lib/libsensor.so.1.1.0
b3fde000 b3fe1000 r-xp /usr/lib/libXv.so.1.0.0
b3ff1000 b3ff6000 r-xp /usr/lib/libutilX.so.1.1.0
b4006000 b400b000 r-xp /usr/lib/libappcore-common.so.1.1
b401b000 b4022000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b4035000 b4039000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b404a000 b4128000 r-xp /usr/lib/libCOREGL.so.4.0
b4148000 b414b000 r-xp /usr/lib/libuuid.so.1.3.0
b415b000 b4172000 r-xp /usr/lib/libblkid.so.1.1.0
b4183000 b4185000 r-xp /usr/lib/libXau.so.6.0.0
b4195000 b41dc000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41ee000 b41f4000 r-xp /usr/lib/libjson-c.so.2.0.1
b4205000 b4209000 r-xp /usr/lib/libogg.so.0.7.1
b4219000 b423b000 r-xp /usr/lib/libvorbis.so.0.4.3
b424b000 b432f000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b434b000 b434e000 r-xp /usr/lib/libEGL.so.1.4
b435f000 b4365000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4375000 b4377000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4387000 b4394000 r-xp /usr/lib/libGLESv2.so.2.0
b43a5000 b4407000 r-xp /usr/lib/libpixman-1.so.0.28.2
b441c000 b4434000 r-xp /usr/lib/libmount.so.1.1.0
b4446000 b445a000 r-xp /usr/lib/libxcb.so.1.1.0
b446a000 b4471000 r-xp /lib/libcrypt-2.20-2014.11.so
b44a9000 b44ab000 r-xp /usr/lib/libiri.so
b44bb000 b44c6000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44d7000 b450d000 r-xp /usr/lib/libpulse.so.0.16.2
b451e000 b4561000 r-xp /usr/lib/libsndfile.so.1.0.25
b4576000 b458b000 r-xp /lib/libexpat.so.1.5.2
b459d000 b465b000 r-xp /usr/lib/libcairo.so.2.11200.14
b466f000 b4677000 r-xp /usr/lib/libdrm.so.2.4.0
b4687000 b468a000 r-xp /usr/lib/libdri2.so.0.0.0
b469a000 b46e8000 r-xp /usr/lib/libssl.so.1.0.0
b46fd000 b4709000 r-xp /usr/lib/libeeze.so.1.13.0
b471a000 b4723000 r-xp /usr/lib/libethumb.so.1.13.0
b4733000 b4736000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4746000 b48fd000 r-xp /usr/lib/libcrypto.so.1.0.0
b56e8000 b56f1000 r-xp /usr/lib/libXi.so.6.1.0
b5701000 b5703000 r-xp /usr/lib/libXgesture.so.7.0.0
b5713000 b5717000 r-xp /usr/lib/libXtst.so.6.1.0
b5727000 b572d000 r-xp /usr/lib/libXrender.so.1.3.0
b573d000 b5743000 r-xp /usr/lib/libXrandr.so.2.2.0
b5753000 b5755000 r-xp /usr/lib/libXinerama.so.1.0.0
b5766000 b5769000 r-xp /usr/lib/libXfixes.so.3.1.0
b5779000 b5784000 r-xp /usr/lib/libXext.so.6.4.0
b5794000 b5796000 r-xp /usr/lib/libXdamage.so.1.1.0
b57a6000 b57a8000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57b8000 b589a000 r-xp /usr/lib/libX11.so.6.3.0
b58ae000 b58b5000 r-xp /usr/lib/libXcursor.so.1.0.2
b58c5000 b58dd000 r-xp /usr/lib/libudev.so.1.6.0
b58df000 b58e2000 r-xp /lib/libattr.so.1.1.0
b58f2000 b5912000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5913000 b5918000 r-xp /usr/lib/libffi.so.6.0.2
b5929000 b5941000 r-xp /lib/libz.so.1.2.8
b5951000 b5953000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5963000 b5a38000 r-xp /usr/lib/libxml2.so.2.9.2
b5a4d000 b5ae8000 r-xp /usr/lib/libstdc++.so.6.0.20
b5b04000 b5b07000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b17000 b5b30000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b41000 b5b52000 r-xp /lib/libresolv-2.20-2014.11.so
b5b66000 b5be0000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bf5000 b5bf7000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c07000 b5c0e000 r-xp /usr/lib/libembryo.so.1.13.0
b5c1e000 b5c28000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c39000 b5c51000 r-xp /usr/lib/libpng12.so.0.50.0
b5c62000 b5c85000 r-xp /usr/lib/libjpeg.so.8.0.2
b5ca6000 b5cba000 r-xp /usr/lib/libector.so.1.13.0
b5ccb000 b5ce3000 r-xp /usr/lib/liblua-5.1.so
b5cf4000 b5d4b000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d5f000 b5d87000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d98000 b5dab000 r-xp /usr/lib/libfribidi.so.0.3.1
b5dbc000 b5df6000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5e07000 b5e15000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e25000 b5e2d000 r-xp /usr/lib/libtbm.so.1.0.0
b5e3d000 b5e4a000 r-xp /usr/lib/libeio.so.1.13.0
b5e5a000 b5e5c000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e6c000 b5e71000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e81000 b5e98000 r-xp /usr/lib/libefreet.so.1.13.0
b5eaa000 b5eca000 r-xp /usr/lib/libeldbus.so.1.13.0
b5eda000 b5efa000 r-xp /usr/lib/libecore_con.so.1.13.0
b5efc000 b5f02000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f12000 b5f23000 r-xp /usr/lib/libemotion.so.1.13.0
b5f34000 b5f3b000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f4b000 b5f5a000 r-xp /usr/lib/libeo.so.1.13.0
b5f6b000 b5f7d000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f8e000 b5f93000 r-xp /usr/lib/libecore_file.so.1.13.0
b5fa3000 b5fbc000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fcc000 b5fe9000 r-xp /usr/lib/libeet.so.1.13.0
b6002000 b604a000 r-xp /usr/lib/libeina.so.1.13.0
b605b000 b606b000 r-xp /usr/lib/libefl.so.1.13.0
b607c000 b6161000 r-xp /usr/lib/libicuuc.so.51.1
b617e000 b62be000 r-xp /usr/lib/libicui18n.so.51.1
b62d5000 b630d000 r-xp /usr/lib/libecore_x.so.1.13.0
b631f000 b6322000 r-xp /lib/libcap.so.2.21
b6332000 b635b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b636c000 b6373000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6385000 b63bc000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63cd000 b64b8000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64cb000 b6544000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6556000 b655b000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b656b000 b6575000 r-xp /usr/lib/libvconf.so.0.2.45
b6585000 b6587000 r-xp /usr/lib/libvasum.so.0.3.1
b6597000 b6599000 r-xp /usr/lib/libttrace.so.1.1
b65a9000 b65ac000 r-xp /usr/lib/libiniparser.so.0
b65bc000 b65e2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65f2000 b65f7000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6608000 b661f000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6630000 b669b000 r-xp /lib/libm-2.20-2014.11.so
b66ac000 b66b2000 r-xp /lib/librt-2.20-2014.11.so
b66c3000 b66d0000 r-xp /usr/lib/libunwind.so.8.0.1
b6706000 b682a000 r-xp /lib/libc-2.20-2014.11.so
b683f000 b6858000 r-xp /lib/libgcc_s-4.9.so.1
b6868000 b694a000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b695b000 b6985000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6996000 b69d2000 r-xp /usr/lib/libsystemd.so.0.4.0
b69d4000 b6a57000 r-xp /usr/lib/libedje.so.1.13.0
b6a6a000 b6a88000 r-xp /usr/lib/libecore.so.1.13.0
b6aa8000 b6c2f000 r-xp /usr/lib/libevas.so.1.13.0
b6c64000 b6c78000 r-xp /lib/libpthread-2.20-2014.11.so
b6c8c000 b6ec0000 r-xp /usr/lib/libelementary.so.1.13.0
b6eef000 b6ef3000 r-xp /usr/lib/libsmack.so.1.0.0
b6f03000 b6f0a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f1a000 b6f1c000 r-xp /usr/lib/libdlog.so.0.0.0
b6f2c000 b6f2f000 r-xp /usr/lib/libbundle.so.0.1.22
b6f3f000 b6f41000 r-xp /lib/libdl-2.20-2014.11.so
b6f52000 b6f6a000 r-xp /usr/lib/libaul.so.0.1.0
b6f7e000 b6f83000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f94000 b6fa1000 r-xp /usr/lib/liblptcp.so
b6fb3000 b6fb7000 r-xp /usr/lib/libsys-assert.so
b6fc8000 b6fe8000 r-xp /lib/ld-2.20-2014.11.so
b6ff9000 b6ffe000 r-xp /usr/bin/launchpad-loader
b8847000 b8c26000 rw-p [heap]
be9c6000 be9e7000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12275)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6731b84) [/lib/libc.so.6] + 0x2bb84
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
k is now broken!
04-06 05:25:39.492+0900 W/APP_CORE(11662): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800002
04-06 05:25:39.492+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 05:25:39.602+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 05:25:39.602+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:25:39.602+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 05:25:39.612+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 05:25:39.612+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 05:25:39.612+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 05:25:39.612+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(11662) status(3)
04-06 05:25:39.612+0900 I/APP_CORE(11662): appcore-efl.c: __do_app(514) > [APP 11662] Event: RESUME State: CREATED
04-06 05:25:39.612+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:25:39.612+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:25:39.612+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(11662)
04-06 05:25:39.612+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 11662, appid: org.example.client, status: fg
04-06 05:25:39.622+0900 I/APP_CORE(11662): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:25:39.622+0900 I/APP_CORE(11662): appcore-efl.c: __do_app(625) > [APP 11662] Initial Launching, call the resume_cb
04-06 05:25:39.622+0900 I/CAPI_APPFW_APPLICATION(11662): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:25:39.632+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 05:25:39.632+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 05:25:39.632+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 05:25:39.982+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(11662) status(0)
04-06 05:25:40.172+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2197
04-06 05:25:40.183+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 05:25:40.183+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 11662.
04-06 05:25:40.963+0900 I/UXT     (12275): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:25:43.075+0900 E/EFL     (11662): ecore_x<11662> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=221862443
04-06 05:25:43.075+0900 I/MY_LOG  (11662): Button pressed
04-06 05:25:43.185+0900 E/EFL     (11662): ecore_x<11662> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=221862553
04-06 05:25:43.185+0900 E/VCONF   (11662): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 05:25:43.195+0900 E/VCONF   (11662): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 05:25:43.195+0900 E/VCONF   (11662): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 05:25:43.195+0900 E/VCONF   (11662): vconf.c: vconf_get_bool(2729) > vconf_get_bool(11662) : db/ise/keysound error
04-06 05:25:43.195+0900 E/VCONF   (11662): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 05:25:43.195+0900 E/VCONF   (11662): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 05:25:43.256+0900 I/MY_LOG  (11662): Button unpressed
04-06 05:25:43.426+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:25:43.436+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 05:25:43.436+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:25:43.436+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:25:43.436+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 05:25:43.436+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 05:25:43.466+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 05:25:43.476+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 11662 pgid = 11662
04-06 05:25:43.476+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(11662)
04-06 05:25:43.486+0900 E/EFL     (  661): <661> lib/ecore_ipc/ecore_ipc.c:804 ecore_ipc_client_send() safety check failed: !ecore_con_client_connected_get(cl->client) is true
04-06 05:25:43.506+0900 W/CRASH_MANAGER(12280): worker.c: worker_job(1199) > 0611662636c691491423943
04-06 05:25:43.526+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 05:25:43.526+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:25:43.526+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 05:25:43.526+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:25:43.536+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 05:25:43.546+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 05:25:43.546+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:25:43.576+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 05:25:43.576+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 05:25:43.576+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 05:25:43.576+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 11662
04-06 05:25:43.586+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 11662
04-06 05:25:43.586+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 11662
04-06 05:25:43.586+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2202
04-06 05:25:43.596+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 05:25:43.606+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:25:43.606+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[11662] terminate event is forwarded
04-06 05:25:43.606+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 05:25:43.606+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 11662, ]
04-06 05:25:43.606+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 05:25:43.606+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 05:25:43.606+0900 I/Tizen::App( 1231): (512) > Not registered pid(11662)
04-06 05:25:43.606+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 05:25:43.606+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:25:43.616+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 05:25:43.616+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:25:43.616+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 05:25:43.616+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:25:43.616+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:25:43.616+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 11662.
04-06 05:25:43.616+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:25:43.636+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 05:25:43.666+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7b94ae0]
04-06 05:25:43.666+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 05:25:43.666+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7b94ae0
04-06 05:25:43.676+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 05:25:43.676+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 05:25:43.676+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 05:25:43.676+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 05:25:43.676+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-06 05:26:00.232+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-06 05:26:00.232+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 5:26
04-06 05:26:00.232+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 5:26"
04-06 05:26:00.232+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 5:26"
04-06 05:26:00.232+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-06 05:26:00.232+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146663333 Time: <font_size=31> </font_size> <font_size=31> 오전 5:26</font_size></font>"
04-06 05:26:03.535+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:26:03.535+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:26:03.535+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:26:03.535+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:26:03.535+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:26:03.535+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:26:03.535+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 05:26:03.535+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:26:03.535+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:26:03.535+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:26:03.535+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:26:03.535+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:27:00.241+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-06 05:27:00.241+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 5:27
04-06 05:27:00.241+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 5:27"
04-06 05:27:00.241+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 5:27"
04-06 05:27:00.241+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-06 05:27:00.241+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146463583 Time: <font_size=31> </font_size> <font_size=31> 오전 5:27</font_size></font>"
04-06 05:27:04.975+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:27:04.975+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:27:04.975+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:27:04.975+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:27:04.975+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:27:04.975+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:27:04.975+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 05:27:04.975+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:27:04.975+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:27:04.975+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:27:04.985+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:27:04.985+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:27:12.282+0900 E/PKGMGR_SERVER(12368): pkgmgr-server.c: main(2414) > package manager server start
04-06 05:27:12.332+0900 E/PKGMGR  (12366): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-06 05:27:12.362+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 05:27:12.372+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-06 05:27:12.382+0900 E/PKGMGR_SERVER(12368): pkgmgr-server.c: sighandler(417) > child NORMAL exit [12371]
04-06 05:27:14.635+0900 E/PKGMGR_SERVER(12368): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 05:27:14.635+0900 E/PKGMGR_SERVER(12368): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 05:27:16.336+0900 E/PKGMGR  (12455): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-06 05:27:16.416+0900 E/PKGMGR_SERVER(12457): pkgmgr-server.c: main(2414) > package manager server start
04-06 05:27:16.456+0900 E/PKGMGR_SERVER(12457): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-06 05:27:16.466+0900 E/PKGMGR_SERVER(12457): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-06 05:27:16.466+0900 E/PKGMGR  (12455): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[124550002]
04-06 05:27:16.627+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-06 05:27:16.627+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-06 05:27:16.627+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:16.627+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:16.627+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:16.627+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:16.627+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:16.627+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:16.637+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-06 05:27:16.637+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-06 05:27:16.637+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-06 05:27:16.637+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-06 05:27:16.647+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:16.647+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:16.647+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:16.647+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:16.647+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:16.647+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:16.797+0900 W/CERT_SVC_VCORE(12460): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-06 05:27:16.877+0900 E/rpm-installer(12460): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-06 05:27:16.877+0900 E/rpm-installer(12460): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-06 05:27:16.937+0900 E/PKGMGR_PARSER(12460): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-06 05:27:16.957+0900 I/PRIVACY-MANAGER-CLIENT(12460): SocketClient.cpp: SocketClient(37) > Client created
04-06 05:27:16.957+0900 I/PRIVACY-MANAGER-CLIENT(12460): SocketClient.cpp: connect(62) > Client connected
04-06 05:27:16.957+0900 I/PRIVACY-MANAGER-SERVER(  915): SocketService.cpp: mainloop(230) > Got incoming connection
04-06 05:27:16.957+0900 I/PRIVACY-MANAGER-CLIENT(12460): SocketClient.cpp: disconnect(72) > Client disconnected
04-06 05:27:16.957+0900 E/PKGMGR_CERT(12460): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-06 05:27:16.967+0900 E/PKGMGR_CERT(12460): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-06 05:27:16.967+0900 E/PKGMGR_CERT(12460): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-06 05:27:17.007+0900 E/rpm-installer(12460): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-06 05:27:17.007+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:17.007+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-06 05:27:17.007+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:17.007+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:17.007+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:17.007+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
04-06 05:27:17.007+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:17.007+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:17.007+0900 E/ESD     (  893): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-06 05:27:17.017+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-06 05:27:17.017+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-06 05:27:17.017+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-06 05:27:18.639+0900 E/PKGMGR_SERVER(12457): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 05:27:18.659+0900 E/PKGMGR_SERVER(12457): pkgmgr-server.c: sighandler(417) > child NORMAL exit [12460]
04-06 05:27:19.680+0900 E/PKGMGR  (12508): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-06 05:27:19.710+0900 E/PKGMGR_SERVER(12457): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-06 05:27:19.720+0900 E/PKGMGR_INFO(12457): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-06 05:27:19.730+0900 E/rpm-installer(12457): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-06 05:27:19.740+0900 E/PKGMGR_SERVER(12457): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-06 05:27:19.740+0900 E/PKGMGR  (12508): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[125080002]
04-06 05:27:19.870+0900 E/PKGMGR_INSTALLER(12510): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-06 05:27:19.870+0900 E/rpm-installer(12510): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-06 05:27:19.880+0900 E/rpm-installer(12510): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-06 05:27:19.880+0900 E/rpm-installer(12510): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-06 05:27:19.880+0900 E/rpm-installer(12510): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-06 05:27:19.880+0900 E/rpm-installer(12510): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-06 05:27:19.890+0900 E/rpm-installer(12510): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-06 05:27:19.940+0900 W/CERT_SVC_VCORE(12510): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-06 05:27:19.990+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-06 05:27:19.990+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
04-06 05:27:19.990+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:19.990+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:19.990+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:19.990+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:19.990+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:19.990+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.000+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-06 05:27:20.000+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-06 05:27:20.000+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-06 05:27:20.010+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.010+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.010+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.010+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.010+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.010+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.240+0900 E/rpm-installer(12510): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-06 05:27:20.240+0900 E/rpm-installer(12510): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-06 05:27:20.240+0900 E/rpm-installer(12510): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-06 05:27:20.240+0900 E/rpm-installer(12510): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-06 05:27:20.240+0900 E/rpm-installer(12510): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-06 05:27:20.240+0900 E/rpm-installer(12510): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-06 05:27:20.250+0900 E/PKGMGR_PARSER(12510): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-06 05:27:20.250+0900 E/PKGMGR_PARSER(12510): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-06 05:27:20.290+0900 I/PRIVACY-MANAGER-CLIENT(12510): SocketClient.cpp: SocketClient(37) > Client created
04-06 05:27:20.500+0900 E/PKGMGR_PARSER(12510): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-06 05:27:20.520+0900 E/PKGMGR_CERT(12510): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-06 05:27:20.520+0900 E/PKGMGR_CERT(12510): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 109
04-06 05:27:20.520+0900 E/PKGMGR_CERT(12510): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 109
04-06 05:27:20.520+0900 E/PKGMGR_CERT(12510): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-06 05:27:20.520+0900 E/PKGMGR_CERT(12510): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 4
04-06 05:27:20.520+0900 E/PKGMGR_CERT(12510): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 4
04-06 05:27:20.520+0900 E/PKGMGR_CERT(12510): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-06 05:27:20.530+0900 E/PKGMGR_CERT(12510): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-06 05:27:20.540+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-06 05:27:20.540+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [60]
04-06 05:27:20.540+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
04-06 05:27:20.540+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.540+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.540+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.540+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.540+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.540+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.550+0900 E/rpm-installer(12510): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-06 05:27:20.570+0900 E/rpm-installer(12510): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-06 05:27:20.580+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.580+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-06 05:27:20.580+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.580+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [100]
04-06 05:27:20.580+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.580+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
04-06 05:27:20.580+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.580+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.580+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:20.641+0900 E/PKGMGR_SERVER(12457): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 05:27:22.592+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-06 05:27:22.592+0900 I/Tizen::App( 1231): (78) > Installation is Completed. [Package = org.example.client]
04-06 05:27:22.592+0900 I/Tizen::App( 1231): (671) > Enter. package(org.example.client), installationResult(0)
04-06 05:27:22.592+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:22.592+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:22.592+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:22.592+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:22.592+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:22.592+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:27:22.592+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-06 05:27:22.592+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-06 05:27:22.592+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-06 05:27:22.642+0900 E/PKGMGR_SERVER(12457): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 05:27:22.642+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-06 05:27:22.683+0900 I/Tizen::App( 1231): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-06 05:27:22.693+0900 I/Tizen::App( 1231): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-06 05:27:22.703+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-06 05:27:22.703+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-06 05:27:22.703+0900 E/PKGMGR_INFO( 1231): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-06 05:27:22.703+0900 I/Tizen::App( 1231): (683) > Application count(1) in this package
04-06 05:27:22.703+0900 I/Tizen::App( 1231): (840) > Enter.
04-06 05:27:22.713+0900 I/Tizen::App( 1231): (703) > Exit.
04-06 05:27:22.713+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [1]
04-06 05:27:22.713+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-06 05:27:22.713+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-06 05:27:22.713+0900 I/Tizen::App( 1231): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-06 05:27:22.713+0900 I/Tizen::App( 1231): (131) > Enter
04-06 05:27:22.713+0900 I/Tizen::App( 1231): (137) > org.example.client does not have launch condition
04-06 05:27:22.713+0900 I/Tizen::App( 1231): (883) > Exit.
04-06 05:27:22.713+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-06 05:27:22.723+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-06 05:27:22.723+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-06 05:27:22.723+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-06 05:27:22.723+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-06 05:27:22.733+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-06 05:27:22.733+0900 E/HOME_APPS(  858): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-06 05:27:22.733+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-06 05:27:22.733+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-06 05:27:22.733+0900 E/PKGMGR_SERVER(12457): pkgmgr-server.c: sighandler(417) > child NORMAL exit [12510]
04-06 05:27:22.753+0900 E/util-view(  858): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-06 05:27:22.773+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-06 05:27:24.634+0900 E/PKGMGR_SERVER(12457): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 05:27:24.634+0900 E/PKGMGR_SERVER(12457): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 05:27:25.455+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:27:25.455+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:27:25.455+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:27:25.455+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:27:25.455+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:27:25.455+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:27:25.455+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 05:27:25.455+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:27:25.455+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:27:25.455+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 05:27:25.455+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:27:25.455+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 05:27:26.837+0900 W/AUL     (12564): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-06 05:27:26.837+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-06 05:27:26.847+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-06 05:27:26.857+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-06 05:27:26.857+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:27:26.857+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 12564
04-06 05:27:26.857+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:27:26.867+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 05:27:26.867+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 05:27:26.867+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 05:27:26.867+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 05:27:26.867+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 05:27:26.887+0900 I/abc     (12275): abc
04-06 05:27:26.887+0900 I/CAPI_APPFW_APPLICATION(12275): app_main.c: ui_app_main(789) > app_efl_main
04-06 05:27:26.887+0900 I/CAPI_APPFW_APPLICATION(12275): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 05:27:26.917+0900 E/TBM     (12275): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:27:26.967+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 12275, appid: org.example.client
04-06 05:27:26.967+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 05:27:26.977+0900 W/AUL     (12564): launch.c: app_request_to_launchpad(425) > request cmd(0) result(12275)
04-06 05:27:27.177+0900 D/basicui (12275): successed to load edc file
04-06 05:27:27.217+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:27:27.217+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:27:27.237+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 05:27:27.237+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:27:27.237+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:27:27.247+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:27:27.277+0900 I/MY_LOG  (12275): change
04-06 05:27:27.317+0900 I/APP_CORE(12275): appcore-efl.c: __do_app(514) > [APP 12275] Event: RESET State: CREATED
04-06 05:27:27.317+0900 I/CAPI_APPFW_APPLICATION(12275): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 05:27:27.327+0900 E/EFL     (12275): edje<12275> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:27:27.327+0900 E/EFL     (12275): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:27:27.337+0900 E/EFL     (12275): edje<12275> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:27:27.337+0900 E/EFL     (12275): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:27:27.337+0900 E/EFL     (12275): edje<12275> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:27:27.337+0900 E/EFL     (12275): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:27:27.347+0900 W/APP_CORE(12275): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
04-06 05:27:27.347+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 05:27:27.457+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 05:27:27.457+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:27:27.457+0900 I/APP_CORE(12275): appcore-efl.c: __do_app(514) > [APP 12275] Event: RESUME State: CREATED
04-06 05:27:27.457+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 05:27:27.457+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 05:27:27.457+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 05:27:27.457+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 05:27:27.467+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(12275) status(3)
04-06 05:27:27.467+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:27:27.467+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:27:27.467+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(12275)
04-06 05:27:27.467+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 12275, appid: org.example.client, status: fg
04-06 05:27:27.477+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 05:27:27.477+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 05:27:27.477+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 05:27:27.477+0900 I/APP_CORE(12275): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:27:27.477+0900 I/APP_CORE(12275): appcore-efl.c: __do_app(625) > [APP 12275] Initial Launching, call the resume_cb
04-06 05:27:27.477+0900 I/CAPI_APPFW_APPLICATION(12275): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:27:27.818+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(12275) status(0)
04-06 05:27:28.038+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 05:27:28.038+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 12275.
04-06 05:27:28.038+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2213
04-06 05:27:28.798+0900 I/UXT     (12578): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:27:29.289+0900 E/EFL     (12275): ecore_x<12275> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=221968657
04-06 05:27:29.299+0900 I/MY_LOG  (12275): Button pressed
04-06 05:27:29.379+0900 E/EFL     (12275): ecore_x<12275> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=221968745
04-06 05:27:29.379+0900 E/VCONF   (12275): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 05:27:29.379+0900 E/VCONF   (12275): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 05:27:29.379+0900 E/VCONF   (12275): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 05:27:29.379+0900 E/VCONF   (12275): vconf.c: vconf_get_bool(2729) > vconf_get_bool(12275) : db/ise/keysound error
04-06 05:27:29.379+0900 E/VCONF   (12275): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 05:27:29.379+0900 E/VCONF   (12275): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 05:27:29.419+0900 I/MY_LOG  (12275): Button unpressed
04-06 05:27:29.579+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:27:29.579+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 12275 pgid = 12275
04-06 05:27:29.579+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(12275)
04-06 05:27:29.609+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 05:27:29.609+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 05:27:29.609+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 05:27:29.609+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[12275] terminate event is forwarded
04-06 05:27:29.609+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 05:27:29.609+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 12275, ]
04-06 05:27:29.609+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 05:27:29.609+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 05:27:29.609+0900 I/Tizen::App( 1231): (512) > Not registered pid(12275)
04-06 05:27:29.609+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 05:27:29.609+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:27:29.609+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 12275
04-06 05:27:29.609+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 12275
04-06 05:27:29.609+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 12275
04-06 05:27:29.619+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2217
04-06 05:27:29.629+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 05:27:29.629+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:27:29.629+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:27:29.629+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 05:27:29.629+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 05:27:29.629+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 05:27:29.639+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:27:29.639+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 12275.
04-06 05:27:29.669+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 05:27:29.669+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:27:29.669+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 05:27:29.679+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:27:29.709+0900 W/CRASH_MANAGER(12585): worker.c: worker_job(1199) > 0612275636c69149142404
