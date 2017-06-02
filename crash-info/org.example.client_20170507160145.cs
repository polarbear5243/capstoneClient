S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 3125
Date: 2017-05-07 16:01:45+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 3125, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000c35
r2   = 0x00000006, r3   = 0xb41394c0
r4   = 0x00000002, r5   = 0xb4139000
r6   = 0xb683309c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f61708
r10  = 0xb87c9e28, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbe88de9c
lr   = 0xb6729f18, pc   = 0xb6728b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:    195320 KB
Buffers:     36256 KB
Cached:     316396 KB
VmPeak:     134872 KB
VmSize:     131652 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31656 KB
VmRSS:       28092 KB
VmData:      45684 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35832 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 3125 TID = 3125
3125 3126 3160 3161 3169 

Maps Information
af99b000 b019a000 rw-p [stack:3169]
b11a8000 b11b9000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b11c9000 b11ce000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b13f9000 b1401000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1413000 b1c12000 rw-p [stack:3161]
b1c12000 b1c13000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c23000 b1c37000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c4b000 b1c4c000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c5c000 b1c5f000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c70000 b1c71000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c81000 b1c83000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c93000 b1c95000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1ca5000 b1cb5000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1cc5000 b1cd1000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1ce3000 b24e2000 rw-p [stack:3160]
b2813000 b281a000 r-xp /usr/lib/libefl-extension.so.0.1.0
b282d000 b2833000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2843000 b286c000 r-xp /opt/usr/apps/org.example.client/bin/client
b29c5000 b2aa8000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2adf000 b2b07000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b19000 b3318000 rw-p [stack:3126]
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
b8426000 b880d000 rw-p [heap]
be86e000 be88f000 rw-p [stack]
be86e000 be88f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3125)
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
1:25.297+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9620956
05-07 16:01:25.297+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[356]  Y[316] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:25.297+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:25.297+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:25.297+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:25.297+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:25.317+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:25.317+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9620989
05-07 16:01:25.327+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9620989
05-07 16:01:25.417+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9621089
05-07 16:01:25.417+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:25.417+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[159]  Y[294] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:25.417+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9621089
05-07 16:01:25.417+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:25.417+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:25.417+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9621089
05-07 16:01:25.417+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:25.417+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:25.497+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9621177
05-07 16:01:25.497+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[418]  Y[302] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:25.497+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:25.507+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:25.507+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:25.507+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:25.517+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:25.547+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9621222
05-07 16:01:25.547+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9621222
05-07 16:01:25.697+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9621333
05-07 16:01:25.697+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[175]  Y[272] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:25.697+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:25.697+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:25.707+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:25.707+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:25.717+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:25.727+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[437]  Y[330] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:25.727+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:25.727+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:25.727+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:25.727+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:25.767+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9621444
05-07 16:01:25.767+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9621444
05-07 16:01:25.827+0900 W/EFL     (  335): e<335> e_border.c:1220 e_border_new() EEEEK! 2 borders with same client window id in them! very bad!
05-07 16:01:25.827+0900 W/EFL     (  335): optimisations failing due to bizarre client behavior. will
05-07 16:01:25.827+0900 W/EFL     (  335): work around.
05-07 16:01:25.827+0900 W/EFL     (  335): bd=0xb8c66c90, bd->references=9, bd->deleted=1, bd->client.win=2800009
05-07 16:01:25.877+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[401]  Y[423] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:25.877+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:25.877+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:25.887+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[191]  Y[213] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:25.887+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:25.887+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:25.887+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:25.887+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:25.897+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:25.897+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:25.927+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9621576
05-07 16:01:25.988+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9621666
05-07 16:01:26.008+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9621666
05-07 16:01:26.038+0900 W/EFL     (  335): e<335> e_border.c:1220 e_border_new() EEEEK! 2 borders with same client window id in them! very bad!
05-07 16:01:26.038+0900 W/EFL     (  335): optimisations failing due to bizarre client behavior. will
05-07 16:01:26.038+0900 W/EFL     (  335): work around.
05-07 16:01:26.038+0900 W/EFL     (  335): bd=0xb8c7c350, bd->references=9, bd->deleted=1, bd->client.win=2800009
05-07 16:01:26.088+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9621765
05-07 16:01:26.088+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[473]  Y[362] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:26.088+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:26.098+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:26.098+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[210]  Y[253] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:26.098+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:26.098+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:26.098+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:26.108+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:26.108+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:26.108+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:26.178+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9621855
05-07 16:01:26.178+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9621855
05-07 16:01:26.228+0900 W/EFL     (  335): e<335> e_border.c:1220 e_border_new() EEEEK! 2 borders with same client window id in them! very bad!
05-07 16:01:26.228+0900 W/EFL     (  335): optimisations failing due to bizarre client behavior. will
05-07 16:01:26.228+0900 W/EFL     (  335): work around.
05-07 16:01:26.228+0900 W/EFL     (  335): bd=0xb8c6afa8, bd->references=9, bd->deleted=1, bd->client.win=2800009
05-07 16:01:26.278+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9621954
05-07 16:01:26.278+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[556]  Y[275] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:26.278+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:26.278+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:26.288+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[231]  Y[275] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:26.288+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:26.288+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:26.288+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:26.288+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:26.298+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:26.298+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:26.338+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9622010
05-07 16:01:26.338+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9622010
05-07 16:01:26.398+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:26.488+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9622132
05-07 16:01:26.488+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[523]  Y[265] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:26.488+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:26.488+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:26.498+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[236]  Y[305] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:26.498+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:26.498+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:26.498+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:26.498+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
05-07 16:01:26.498+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:26.508+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:26.508+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:26.508+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:26.518+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9622199
05-07 16:01:26.528+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9622199
05-07 16:01:26.658+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:26.678+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9622320
05-07 16:01:26.678+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[421]  Y[371] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:26.678+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:26.678+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:26.688+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[207]  Y[282] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:26.688+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:26.688+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:26.688+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:26.688+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:26.688+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:26.698+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:26.708+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9622387
05-07 16:01:26.708+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9622387
05-07 16:01:26.848+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9622498
05-07 16:01:26.848+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[452]  Y[405] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:26.848+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:26.848+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:26.848+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[189]  Y[258] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:26.858+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:26.858+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:26.858+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:26.858+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:26.858+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:26.858+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:26.878+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:26.908+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9622587
05-07 16:01:26.908+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9622587
05-07 16:01:27.049+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9622697
05-07 16:01:27.049+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[556]  Y[306] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:27.049+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:27.049+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:27.059+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[186]  Y[277] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:27.059+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:27.059+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:27.059+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:27.059+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:27.069+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:27.069+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:27.079+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:27.119+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9622797
05-07 16:01:27.119+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9622797
05-07 16:01:27.219+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9622886
05-07 16:01:27.219+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[508]  Y[314] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:27.219+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:27.219+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:27.229+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:27.229+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:27.259+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:27.279+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[197]  Y[288] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:27.279+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:27.279+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:27.289+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:27.289+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:27.309+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9622986
05-07 16:01:27.309+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9622986
05-07 16:01:27.389+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:27.419+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9623096
05-07 16:01:27.419+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[443]  Y[406] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:27.419+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:27.419+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:27.429+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:27.429+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:27.679+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: prediction_gen_timer(159) > [0;36mprediction_gen_timer[0m
05-07 16:01:27.699+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Generate_prediction_TH(1695) > [0;36mGen prediction[0m
05-07 16:01:27.699+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: prediction_gen_thread(144) > [0;36mpredic gen set [1][0m
05-07 16:01:27.709+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 70[0m
05-07 16:01:27.709+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
05-07 16:01:27.719+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 1[0m
05-07 16:01:27.719+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
05-07 16:01:27.719+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 631, total_width = 0[0m
05-07 16:01:27.719+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 1, line_count = 0[0m
05-07 16:01:27.839+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9623511
05-07 16:01:27.939+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9623611
05-07 16:01:27.949+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Learn_sentence(2373) > [0;36mDLM write[0m
05-07 16:01:27.969+0900 I/ISE_MULTI(  837): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
05-07 16:01:28.210+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x6c00002 FAILED!
05-07 16:01:28.220+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
05-07 16:01:28.220+0900 I/MY_LOG  ( 3125): change
05-07 16:01:28.220+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
05-07 16:01:28.230+0900 I/ISE_MULTI(  837): xt9-setting.cpp: xt9_change_onoff(165) > [0;36mPrediction OFF[0m
05-07 16:01:28.230+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
05-07 16:01:28.230+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
05-07 16:01:28.230+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
05-07 16:01:28.230+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
05-07 16:01:28.280+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_hide(927) > [0;33mHide[0m
05-07 16:01:28.280+0900 E/ISE_MULTI(  837): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 577  rect->height : 505[0m
05-07 16:01:28.280+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
05-07 16:01:28.280+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
05-07 16:01:28.320+0900 I/ISE_MULTI(  837): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
05-07 16:01:29.251+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9624928
05-07 16:01:29.251+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9624928
05-07 16:01:29.361+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:29.381+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9625048
05-07 16:01:29.381+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[30]  Y[153] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:29.381+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:29.391+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:29.401+0900 I/MY_LOG  ( 3125): change
05-07 16:01:29.401+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:29.401+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:29.401+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=1[0m
05-07 16:01:29.641+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9625327
05-07 16:01:29.641+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9625327
05-07 16:01:29.761+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9625448
05-07 16:01:29.771+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[102]  Y[151] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:29.771+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:29.771+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:29.771+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=2[0m
05-07 16:01:29.771+0900 I/MY_LOG  ( 3125): change
05-07 16:01:29.771+0900 I/MY_LOG  ( 3125): change
05-07 16:01:29.781+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:29.781+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:29.791+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:29.921+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9625604
05-07 16:01:29.921+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9625604
05-07 16:01:30.021+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:30.041+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9625725
05-07 16:01:30.041+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[182]  Y[153] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:30.041+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:30.052+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:30.052+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=3[0m
05-07 16:01:30.052+0900 I/MY_LOG  ( 3125): change
05-07 16:01:30.052+0900 I/MY_LOG  ( 3125): change
05-07 16:01:30.052+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:30.052+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:30.122+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-07 16:01:30.122+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-07 16:01:30.122+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-07 16:01:30.122+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-07 16:01:30.132+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-07 16:01:30.132+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-07 16:01:30.132+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
05-07 16:01:30.132+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-07 16:01:30.132+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-07 16:01:30.132+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-07 16:01:30.132+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-07 16:01:30.132+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-07 16:01:30.162+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9625847
05-07 16:01:30.162+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9625847
05-07 16:01:30.272+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:30.272+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9625958
05-07 16:01:30.282+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[260]  Y[138] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:30.282+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:30.282+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:30.282+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=4[0m
05-07 16:01:30.282+0900 I/MY_LOG  ( 3125): change
05-07 16:01:30.282+0900 I/MY_LOG  ( 3125): change
05-07 16:01:30.282+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:30.282+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:30.682+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9626356
05-07 16:01:30.812+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9626489
05-07 16:01:30.812+0900 I/ISE_MULTI(  837): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
05-07 16:01:30.832+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x6c00002 FAILED!
05-07 16:01:30.882+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
05-07 16:01:30.882+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
05-07 16:01:30.882+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
05-07 16:01:30.882+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
05-07 16:01:30.882+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
05-07 16:01:30.922+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
05-07 16:01:30.922+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_hide(927) > [0;33mHide[0m
05-07 16:01:30.922+0900 E/ISE_MULTI(  837): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 505  rect->height : 505[0m
05-07 16:01:30.922+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
05-07 16:01:30.962+0900 I/ISE_MULTI(  837): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
05-07 16:01:31.042+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
05-07 16:01:31.413+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9627083
05-07 16:01:31.413+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9627083
05-07 16:01:31.503+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:31.553+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9627238
05-07 16:01:31.563+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[29]  Y[177] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:31.563+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:31.563+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:31.563+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=1[0m
05-07 16:01:31.563+0900 I/MY_LOG  ( 3125): change
05-07 16:01:31.563+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:31.563+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:31.843+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9627517
05-07 16:01:31.853+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9627517
05-07 16:01:31.933+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:31.953+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9627638
05-07 16:01:31.963+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[110]  Y[140] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:31.963+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:31.963+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:31.963+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=2[0m
05-07 16:01:31.963+0900 I/MY_LOG  ( 3125): change
05-07 16:01:31.963+0900 I/MY_LOG  ( 3125): change
05-07 16:01:31.963+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:31.963+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:32.144+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9627828
05-07 16:01:32.154+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9627828
05-07 16:01:32.244+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:32.284+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9627960
05-07 16:01:32.284+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[188]  Y[147] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:32.284+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:32.284+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:32.284+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=3[0m
05-07 16:01:32.284+0900 I/MY_LOG  ( 3125): change
05-07 16:01:32.284+0900 I/MY_LOG  ( 3125): change
05-07 16:01:32.294+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:32.294+0900 I/MY_LOG  ( 3125): change
05-07 16:01:32.294+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:32.414+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9628094
05-07 16:01:32.414+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9628094
05-07 16:01:32.494+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
05-07 16:01:32.514+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9628193
05-07 16:01:32.524+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[244]  Y[135] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:32.524+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:32.524+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
05-07 16:01:32.524+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=4[0m
05-07 16:01:32.524+0900 I/MY_LOG  ( 3125): change
05-07 16:01:32.524+0900 I/MY_LOG  ( 3125): change
05-07 16:01:32.534+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:32.534+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:32.774+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9628457
05-07 16:01:32.784+0900 I/ISE_MULTI(  837): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
05-07 16:01:32.784+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
05-07 16:01:33.175+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9628856
05-07 16:01:34.075+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9629752
05-07 16:01:34.075+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9629752
05-07 16:01:34.166+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9629840
05-07 16:01:34.166+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[670]  Y[468] aspect ratio is x[1.000000] y[1.000000][0m
05-07 16:01:34.166+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
05-07 16:01:34.166+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
05-07 16:01:34.166+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
05-07 16:01:34.176+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
05-07 16:01:34.526+0900 I/MY_LOG  ( 3125): change
05-07 16:01:35.317+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=9630928
05-07 16:01:35.317+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=9630992
05-07 16:01:35.317+0900 I/ISE_MULTI(  837): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
05-07 16:01:35.347+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x6c00002 FAILED!
05-07 16:01:35.347+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
05-07 16:01:36.097+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=9631774
05-07 16:01:36.097+0900 I/MY_LOG  ( 3125): Button pressed
05-07 16:01:36.197+0900 E/EFL     ( 3125): ecore_x<3125> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=9631873
05-07 16:01:36.197+0900 I/ISE_MULTI(  837): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:true][0m
05-07 16:01:36.208+0900 I/MY_LOG  ( 3125): Button unpressed
05-07 16:01:45.206+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-07 16:01:45.216+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
05-07 16:01:45.216+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-07 16:01:45.216+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
05-07 16:01:45.216+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
05-07 16:01:45.216+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
05-07 16:01:45.226+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 3125 pgid = 3125
05-07 16:01:45.226+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(3125)
05-07 16:01:45.256+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
05-07 16:01:45.276+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
05-07 16:01:45.276+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-07 16:01:45.276+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
05-07 16:01:45.276+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-07 16:01:45.296+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
05-07 16:01:45.296+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
05-07 16:01:45.296+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
05-07 16:01:45.316+0900 I/CAPI_WIDGET_APPLICATION( 1397): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
05-07 16:01:45.316+0900 I/CAPI_WIDGET_APPLICATION( 1397): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
05-07 16:01:45.316+0900 W/AUL     ( 1397): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1397, appid: live-com.samsung.browser, status: fg
05-07 16:01:45.326+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
05-07 16:01:45.326+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-07 16:01:45.346+0900 E/cluster-home(  867): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
05-07 16:01:45.346+0900 W/cluster-view(  867): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
05-07 16:01:45.346+0900 W/CRASH_MANAGER( 3173): worker.c: worker_job(1199) > 0603125636c69149414050
