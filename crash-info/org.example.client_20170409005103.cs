S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 6842
Date: 2017-04-09 00:51:03+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 6842, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb6dfd374
r2   = 0x0000005f, r3   = 0x00000065
r4   = 0xb84ec450, r5   = 0xb6dfd374
r6   = 0xb8397938, r7   = 0xb86c0ec0
r8   = 0x00000000, r9   = 0xb82b55d8
r10  = 0xb6e63eac, fp   = 0x00000000
ip   = 0xb5ef81d8, sp   = 0xbedacea0
lr   = 0xb5ee36cd, pc   = 0xb67096f0
cpsr = 0xa0070030

Memory Information
MemTotal:   987012 KB
MemFree:    142048 KB
Buffers:     43880 KB
Cached:     335468 KB
VmPeak:     141548 KB
VmSize:     140252 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       36096 KB
VmRSS:       35140 KB
VmData:      52240 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35796 KB
VmPTE:         108 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6842 TID = 6842
6842 6844 6898 6899 6907 

Maps Information
aee8e000 af68d000 rw-p [stack:6907]
b0f81000 b0f92000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0fa2000 b0fa7000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b13a9000 b13b1000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13c3000 b1bc2000 rw-p [stack:6899]
b1bc2000 b1bc3000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bd3000 b1be7000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bfb000 b1bfc000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c0c000 b1c0f000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c20000 b1c21000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c31000 b1c33000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c43000 b1c45000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c55000 b1c65000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c75000 b1c81000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c93000 b2492000 rw-p [stack:6898]
b27c3000 b27ca000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27dd000 b27e3000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27f3000 b2813000 r-xp /opt/usr/apps/org.example.client/bin/client
b295c000 b2a3f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a76000 b2a9e000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ab0000 b32af000 rw-p [stack:6844]
b32af000 b32b1000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32c1000 b32cb000 r-xp /lib/libnss_files-2.20-2014.11.so
b32dc000 b32e5000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32f6000 b3307000 r-xp /lib/libnsl-2.20-2014.11.so
b331a000 b3320000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3331000 b3332000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b335a000 b3361000 r-xp /usr/lib/libminizip.so.1.0.0
b3371000 b3376000 r-xp /usr/lib/libstorage.so.0.1
b3386000 b33e5000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33fb000 b340f000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b341f000 b3463000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3473000 b347b000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b348b000 b34bb000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34ce000 b3587000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b359b000 b35ee000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35ff000 b361a000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b362a000 b36eb000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36fe000 b370e000 r-xp /usr/lib/libefl-assist.so.0.1.0
b371e000 b372b000 r-xp /usr/lib/libmdm-common.so.1.0.98
b373c000 b3743000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3753000 b3794000 r-xp /usr/lib/libmdm.so.1.2.12
b37a4000 b37ac000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37bb000 b37cb000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37ec000 b384c000 r-xp /usr/lib/libasound.so.2.0.0
b385e000 b3861000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3871000 b3874000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3884000 b3889000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3899000 b389a000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38aa000 b38b5000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38c9000 b38d0000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38e0000 b38e6000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38f6000 b38fb000 r-xp /usr/lib/libmmfsession.so.0.0.1
b390b000 b3926000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3936000 b393d000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b394d000 b3950000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3961000 b398f000 r-xp /usr/lib/libidn.so.11.5.44
b399f000 b39b5000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39c6000 b39d0000 r-xp /usr/lib/libcares.so.2.1.0
b39e0000 b39ea000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39fa000 b39fc000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a0c000 b3a0d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a1d000 b3a21000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a32000 b3a5a000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a6b000 b3a94000 r-xp /usr/lib/libturbojpeg.so
b3ab4000 b3aba000 r-xp /usr/lib/libgif.so.4.1.6
b3aca000 b3b10000 r-xp /usr/lib/libcurl.so.4.3.0
b3b21000 b3b42000 r-xp /usr/lib/libexif.so.12.3.3
b3b5d000 b3b72000 r-xp /usr/lib/libtts.so
b3b83000 b3b8b000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b9b000 b3c61000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c81000 b3d79000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d98000 b3e66000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e7d000 b3e7f000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e8f000 b3e95000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ea5000 b3ec8000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ed9000 b3edb000 r-xp /usr/lib/libappsvc.so.0.1.0
b3eeb000 b3eed000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3efe000 b3f03000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f1a000 b3f1c000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f2c000 b3f33000 r-xp /usr/lib/libsensord-share.so
b3f43000 b3f5b000 r-xp /usr/lib/libsensor.so.1.1.0
b3f6c000 b3f6f000 r-xp /usr/lib/libXv.so.1.0.0
b3f7f000 b3f84000 r-xp /usr/lib/libutilX.so.1.1.0
b3f94000 b3f99000 r-xp /usr/lib/libappcore-common.so.1.1
b3fa9000 b3fb0000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fc3000 b3fc7000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fd8000 b40b6000 r-xp /usr/lib/libCOREGL.so.4.0
b40d6000 b40d9000 r-xp /usr/lib/libuuid.so.1.3.0
b40e9000 b4100000 r-xp /usr/lib/libblkid.so.1.1.0
b4111000 b4113000 r-xp /usr/lib/libXau.so.6.0.0
b4123000 b416a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b417c000 b4182000 r-xp /usr/lib/libjson-c.so.2.0.1
b4193000 b4197000 r-xp /usr/lib/libogg.so.0.7.1
b41a7000 b41c9000 r-xp /usr/lib/libvorbis.so.0.4.3
b41d9000 b42bd000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42d9000 b42dc000 r-xp /usr/lib/libEGL.so.1.4
b42ed000 b42f3000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4303000 b4305000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4315000 b4322000 r-xp /usr/lib/libGLESv2.so.2.0
b4333000 b4395000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43aa000 b43c2000 r-xp /usr/lib/libmount.so.1.1.0
b43d4000 b43e8000 r-xp /usr/lib/libxcb.so.1.1.0
b43f8000 b43ff000 r-xp /lib/libcrypt-2.20-2014.11.so
b4437000 b4439000 r-xp /usr/lib/libiri.so
b4449000 b4454000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4465000 b449b000 r-xp /usr/lib/libpulse.so.0.16.2
b44ac000 b44ef000 r-xp /usr/lib/libsndfile.so.1.0.25
b4504000 b4519000 r-xp /lib/libexpat.so.1.5.2
b452b000 b45e9000 r-xp /usr/lib/libcairo.so.2.11200.14
b45fd000 b4605000 r-xp /usr/lib/libdrm.so.2.4.0
b4615000 b4618000 r-xp /usr/lib/libdri2.so.0.0.0
b4628000 b4676000 r-xp /usr/lib/libssl.so.1.0.0
b468b000 b4697000 r-xp /usr/lib/libeeze.so.1.13.0
b46a8000 b46b1000 r-xp /usr/lib/libethumb.so.1.13.0
b46c1000 b46c4000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46d4000 b488b000 r-xp /usr/lib/libcrypto.so.1.0.0
b5676000 b567f000 r-xp /usr/lib/libXi.so.6.1.0
b568f000 b5691000 r-xp /usr/lib/libXgesture.so.7.0.0
b56a1000 b56a5000 r-xp /usr/lib/libXtst.so.6.1.0
b56b5000 b56bb000 r-xp /usr/lib/libXrender.so.1.3.0
b56cb000 b56d1000 r-xp /usr/lib/libXrandr.so.2.2.0
b56e1000 b56e3000 r-xp /usr/lib/libXinerama.so.1.0.0
b56f4000 b56f7000 r-xp /usr/lib/libXfixes.so.3.1.0
b5707000 b5712000 r-xp /usr/lib/libXext.so.6.4.0
b5722000 b5724000 r-xp /usr/lib/libXdamage.so.1.1.0
b5734000 b5736000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5746000 b5828000 r-xp /usr/lib/libX11.so.6.3.0
b583c000 b5843000 r-xp /usr/lib/libXcursor.so.1.0.2
b5853000 b586b000 r-xp /usr/lib/libudev.so.1.6.0
b586d000 b5870000 r-xp /lib/libattr.so.1.1.0
b5880000 b58a0000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58a1000 b58a6000 r-xp /usr/lib/libffi.so.6.0.2
b58b7000 b58cf000 r-xp /lib/libz.so.1.2.8
b58df000 b58e1000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58f1000 b59c6000 r-xp /usr/lib/libxml2.so.2.9.2
b59db000 b5a76000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a92000 b5a95000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aa5000 b5abe000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5acf000 b5ae0000 r-xp /lib/libresolv-2.20-2014.11.so
b5af4000 b5b6e000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b83000 b5b85000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b95000 b5b9c000 r-xp /usr/lib/libembryo.so.1.13.0
b5bac000 b5bb6000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bc7000 b5bdf000 r-xp /usr/lib/libpng12.so.0.50.0
b5bf0000 b5c13000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c34000 b5c48000 r-xp /usr/lib/libector.so.1.13.0
b5c59000 b5c71000 r-xp /usr/lib/liblua-5.1.so
b5c82000 b5cd9000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ced000 b5d15000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d26000 b5d39000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d4a000 b5d84000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d95000 b5da3000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5db3000 b5dbb000 r-xp /usr/lib/libtbm.so.1.0.0
b5dcb000 b5dd8000 r-xp /usr/lib/libeio.so.1.13.0
b5de8000 b5dea000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dfa000 b5dff000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e0f000 b5e26000 r-xp /usr/lib/libefreet.so.1.13.0
b5e38000 b5e58000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e68000 b5e88000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e8a000 b5e90000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ea0000 b5eb1000 r-xp /usr/lib/libemotion.so.1.13.0
b5ec2000 b5ec9000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ed9000 b5ee8000 r-xp /usr/lib/libeo.so.1.13.0
b5ef9000 b5f0b000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f1c000 b5f21000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f31000 b5f4a000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f5a000 b5f77000 r-xp /usr/lib/libeet.so.1.13.0
b5f90000 b5fd8000 r-xp /usr/lib/libeina.so.1.13.0
b5fe9000 b5ff9000 r-xp /usr/lib/libefl.so.1.13.0
b600a000 b60ef000 r-xp /usr/lib/libicuuc.so.51.1
b610c000 b624c000 r-xp /usr/lib/libicui18n.so.51.1
b6263000 b629b000 r-xp /usr/lib/libecore_x.so.1.13.0
b62ad000 b62b0000 r-xp /lib/libcap.so.2.21
b62c0000 b62e9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62fa000 b6301000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6313000 b634a000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b635b000 b6446000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6459000 b64d2000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64e4000 b64e9000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64f9000 b6503000 r-xp /usr/lib/libvconf.so.0.2.45
b6513000 b6515000 r-xp /usr/lib/libvasum.so.0.3.1
b6525000 b6527000 r-xp /usr/lib/libttrace.so.1.1
b6537000 b653a000 r-xp /usr/lib/libiniparser.so.0
b654a000 b6570000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6580000 b6585000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6596000 b65ad000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65be000 b6629000 r-xp /lib/libm-2.20-2014.11.so
b663a000 b6640000 r-xp /lib/librt-2.20-2014.11.so
b6651000 b665e000 r-xp /usr/lib/libunwind.so.8.0.1
b6694000 b67b8000 r-xp /lib/libc-2.20-2014.11.so
b67cd000 b67e6000 r-xp /lib/libgcc_s-4.9.so.1
b67f6000 b68d8000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68e9000 b6913000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6924000 b6960000 r-xp /usr/lib/libsystemd.so.0.4.0
b6962000 b69e5000 r-xp /usr/lib/libedje.so.1.13.0
b69f8000 b6a16000 r-xp /usr/lib/libecore.so.1.13.0
b6a36000 b6bbd000 r-xp /usr/lib/libevas.so.1.13.0
b6bf2000 b6c06000 r-xp /lib/libpthread-2.20-2014.11.so
b6c1a000 b6e4e000 r-xp /usr/lib/libelementary.so.1.13.0
b6e7d000 b6e81000 r-xp /usr/lib/libsmack.so.1.0.0
b6e91000 b6e98000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ea8000 b6eaa000 r-xp /usr/lib/libdlog.so.0.0.0
b6eba000 b6ebd000 r-xp /usr/lib/libbundle.so.0.1.22
b6ecd000 b6ecf000 r-xp /lib/libdl-2.20-2014.11.so
b6ee0000 b6ef8000 r-xp /usr/lib/libaul.so.0.1.0
b6f0c000 b6f11000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f22000 b6f2f000 r-xp /usr/lib/liblptcp.so
b6f41000 b6f45000 r-xp /usr/lib/libsys-assert.so
b6f56000 b6f76000 r-xp /lib/ld-2.20-2014.11.so
b6f87000 b6f8c000 r-xp /usr/bin/launchpad-loader
b80f5000 b8aa0000 rw-p [heap]
bed8d000 bedae000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6842)
Call Stack Count: 1
 0: (0xb67096f0) [/lib/libc.so.6] + 0x756f0
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
 amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(6408)
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
04-09 00:50:10.849+0900 W/CRASH_MANAGER( 6784): worker.c: worker_job(1199) > 0606408636c691491666610
04-09 00:50:10.899+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_create(409) > New handle created[0xb858a908]
04-09 00:50:10.909+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_get_type(463) > Connected Network = 2
04-09 00:50:10.909+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_destroy(427) > Destroy handle: 0xb858a908
04-09 00:50:10.909+0900 E/weather-common( 1410): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-09 00:50:10.909+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-09 00:50:10.909+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-09 00:50:10.909+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-09 00:50:10.909+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: fg
04-09 00:50:18.286+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7755485
04-09 00:50:18.707+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7755905
04-09 00:50:18.967+0900 W/cluster-view(  868): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
04-09 00:50:19.518+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7756711
04-09 00:50:19.728+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7756921
04-09 00:50:19.988+0900 W/cluster-view(  868): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
04-09 00:50:20.999+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7758193
04-09 00:50:21.079+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7758270
04-09 00:50:21.079+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-09 00:50:21.079+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
04-09 00:50:21.079+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 868
04-09 00:50:21.089+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-09 00:50:21.089+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-09 00:50:21.089+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-09 00:50:21.099+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-09 00:50:21.099+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-09 00:50:21.109+0900 I/abc     ( 6770): abc
04-09 00:50:21.109+0900 I/CAPI_APPFW_APPLICATION( 6770): app_main.c: ui_app_main(789) > app_efl_main
04-09 00:50:21.109+0900 I/CAPI_APPFW_APPLICATION( 6770): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-09 00:50:21.139+0900 E/TBM     ( 6770): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-09 00:50:21.199+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6770, appid: org.example.client
04-09 00:50:21.199+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-09 00:50:21.209+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(425) > request cmd(1) result(6770)
04-09 00:50:21.399+0900 D/basicui ( 6770): successed to load edc file
04-09 00:50:21.429+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:21.429+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:21.449+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-09 00:50:21.449+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:50:21.459+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:50:21.459+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:50:21.489+0900 I/MY_LOG  ( 6770): change
04-09 00:50:21.530+0900 I/APP_CORE( 6770): appcore-efl.c: __do_app(514) > [APP 6770] Event: RESET State: CREATED
04-09 00:50:21.530+0900 I/CAPI_APPFW_APPLICATION( 6770): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-09 00:50:21.540+0900 E/EFL     ( 6770): edje<6770> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:50:21.540+0900 E/EFL     ( 6770): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:50:21.550+0900 E/EFL     ( 6770): edje<6770> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:50:21.550+0900 E/EFL     ( 6770): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:50:21.550+0900 E/EFL     ( 6770): edje<6770> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:50:21.550+0900 E/EFL     ( 6770): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:50:21.560+0900 W/APP_CORE( 6770): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
04-09 00:50:21.560+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-09 00:50:21.680+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-09 00:50:21.680+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-09 00:50:21.680+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-09 00:50:21.690+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-09 00:50:21.690+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-09 00:50:21.690+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-09 00:50:21.690+0900 I/APP_CORE( 6770): appcore-efl.c: __do_app(514) > [APP 6770] Event: RESUME State: CREATED
04-09 00:50:21.690+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6770) status(3)
04-09 00:50:21.690+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(6770)
04-09 00:50:21.690+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6770, appid: org.example.client, status: fg
04-09 00:50:21.700+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-09 00:50:21.700+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-09 00:50:21.700+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: bg
04-09 00:50:21.710+0900 I/APP_CORE( 6770): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-09 00:50:21.710+0900 I/APP_CORE( 6770): appcore-efl.c: __do_app(625) > [APP 6770] Initial Launching, call the resume_cb
04-09 00:50:21.710+0900 I/CAPI_APPFW_APPLICATION( 6770): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:50:22.050+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6770) status(0)
04-09 00:50:22.260+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.564
04-09 00:50:22.270+0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-09 00:50:22.270+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 6770.
04-09 00:50:23.021+0900 I/UXT     ( 6842): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-09 00:50:23.481+0900 E/EFL     ( 6770): ecore_x<6770> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7760669
04-09 00:50:23.562+0900 E/EFL     ( 6770): ecore_x<6770> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7760757
04-09 00:50:23.622+0900 D/basicui ( 6770): successed to load edc file
04-09 00:50:23.642+0900 I/MY_LOG  ( 6770): change
04-09 00:50:23.652+0900 I/MY_LOG  ( 6770): change
04-09 00:50:23.672+0900 I/MY_LOG  ( 6770): change
04-09 00:50:24.593+0900 E/EFL     ( 6770): ecore_x<6770> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7761787
04-09 00:50:24.603+0900 I/MY_LOG  ( 6770): Button pressed
04-09 00:50:24.693+0900 E/EFL     ( 6770): ecore_x<6770> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7761886
04-09 00:50:24.703+0900 E/VCONF   ( 6770): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-09 00:50:24.703+0900 E/VCONF   ( 6770): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-09 00:50:24.703+0900 E/VCONF   ( 6770): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-09 00:50:24.703+0900 E/VCONF   ( 6770): vconf.c: vconf_get_bool(2729) > vconf_get_bool(6770) : db/ise/keysound error
04-09 00:50:24.703+0900 E/VCONF   ( 6770): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-09 00:50:24.703+0900 E/VCONF   ( 6770): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-09 00:50:24.753+0900 I/MY_LOG  ( 6770): Button unpressed
04-09 00:50:24.843+0900 E/EFL     ( 6770): elementary<6770> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-09 00:50:26.695+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: MEM_FLUSH State: PAUSED
04-09 00:50:27.045+0900 W/CRASH_MANAGER( 6784): worker.c: worker_job(1199) > 1106770636c691491666626
04-09 00:50:27.075+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6770 pgid = 6770
04-09 00:50:27.075+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(6770)
04-09 00:50:27.075+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:27.135+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(3)
04-09 00:50:27.135+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-09 00:50:27.135+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-09 00:50:27.135+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(868)
04-09 00:50:27.135+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-09 00:50:27.135+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-09 00:50:27.165+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:27.165+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-09 00:50:27.165+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:50:27.165+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-09 00:50:27.165+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-09 00:50:27.165+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-09 00:50:27.165+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-09 00:50:27.175+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 6770
04-09 00:50:27.175+0900 I/Tizen::App( 1246): (243) > App[org.example.client] pid[6770] terminate event is forwarded
04-09 00:50:27.175+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-09 00:50:27.175+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [org.example.client, 6770, ]
04-09 00:50:27.175+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-09 00:50:27.175+0900 I/Tizen::App( 1246): (506) > TerminatedApp(org.example.client)
04-09 00:50:27.175+0900 I/Tizen::App( 1246): (512) > Not registered pid(6770)
04-09 00:50:27.175+0900 I/Tizen::System( 1246): (246) > Terminated app [org.example.client]
04-09 00:50:27.175+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:50:27.175+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6770
04-09 00:50:27.175+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 6770
04-09 00:50:27.175+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.568
04-09 00:50:27.195+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-09 00:50:27.195+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:50:27.195+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for org.example.client, 6770.
04-09 00:50:27.275+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [org.exampl] 
04-09 00:50:27.285+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:50:27.285+0900 E/weather-widget( 1410): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-09 00:50:27.285+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:50:27.305+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-09 00:50:27.305+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-09 00:50:27.305+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-09 00:50:27.305+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-09 00:50:27.305+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:50:27.305+0900 E/weather-common( 1410): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-09 00:50:27.365+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_create(409) > New handle created[0xb8531da8]
04-09 00:50:27.365+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_get_type(463) > Connected Network = 2
04-09 00:50:27.365+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_destroy(427) > Destroy handle: 0xb8531da8
04-09 00:50:27.375+0900 E/weather-common( 1410): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-09 00:50:27.375+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-09 00:50:27.375+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-09 00:50:27.375+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-09 00:50:27.375+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: fg
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:50:35.613+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7772805
04-09 00:50:35.703+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7772893
04-09 00:50:35.703+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-09 00:50:35.703+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
04-09 00:50:35.703+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 868
04-09 00:50:35.713+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-09 00:50:35.713+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-09 00:50:35.723+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-09 00:50:35.723+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-09 00:50:35.723+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-09 00:50:35.733+0900 I/abc     ( 6842): abc
04-09 00:50:35.733+0900 I/CAPI_APPFW_APPLICATION( 6842): app_main.c: ui_app_main(789) > app_efl_main
04-09 00:50:35.733+0900 I/CAPI_APPFW_APPLICATION( 6842): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-09 00:50:35.763+0900 E/TBM     ( 6842): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-09 00:50:35.823+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6842, appid: org.example.client
04-09 00:50:35.823+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-09 00:50:35.833+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(425) > request cmd(1) result(6842)
04-09 00:50:36.014+0900 D/basicui ( 6842): successed to load edc file
04-09 00:50:36.054+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:36.054+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:36.064+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-09 00:50:36.064+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:50:36.074+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:50:36.084+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:50:36.104+0900 I/MY_LOG  ( 6842): change
04-09 00:50:36.154+0900 I/APP_CORE( 6842): appcore-efl.c: __do_app(514) > [APP 6842] Event: RESET State: CREATED
04-09 00:50:36.154+0900 I/CAPI_APPFW_APPLICATION( 6842): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-09 00:50:36.164+0900 E/EFL     ( 6842): edje<6842> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:50:36.164+0900 E/EFL     ( 6842): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:50:36.164+0900 E/EFL     ( 6842): edje<6842> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:50:36.164+0900 E/EFL     ( 6842): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:50:36.174+0900 E/EFL     ( 6842): edje<6842> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:50:36.174+0900 E/EFL     ( 6842): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:50:36.174+0900 W/APP_CORE( 6842): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6c00002
04-09 00:50:36.174+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-09 00:50:36.304+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-09 00:50:36.304+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-09 00:50:36.304+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-09 00:50:36.304+0900 I/APP_CORE( 6842): appcore-efl.c: __do_app(514) > [APP 6842] Event: RESUME State: CREATED
04-09 00:50:36.304+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-09 00:50:36.304+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-09 00:50:36.304+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-09 00:50:36.304+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6842) status(3)
04-09 00:50:36.314+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(6842)
04-09 00:50:36.314+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6842, appid: org.example.client, status: fg
04-09 00:50:36.324+0900 I/APP_CORE( 6842): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-09 00:50:36.324+0900 I/APP_CORE( 6842): appcore-efl.c: __do_app(625) > [APP 6842] Initial Launching, call the resume_cb
04-09 00:50:36.324+0900 I/CAPI_APPFW_APPLICATION( 6842): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:50:36.324+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-09 00:50:36.324+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-09 00:50:36.324+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: bg
04-09 00:50:36.664+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6842) status(0)
04-09 00:50:36.864+0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-09 00:50:36.864+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 6842.
04-09 00:50:36.875+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.570
04-09 00:50:37.635+0900 I/UXT     ( 6904): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-09 00:50:38.016+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7775199
04-09 00:50:38.096+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7775287
04-09 00:50:39.087+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7776272
04-09 00:50:39.177+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7776371
04-09 00:50:39.227+0900 D/basicui ( 6842): successed to load edc file
04-09 00:50:39.257+0900 I/MY_LOG  ( 6842): change
04-09 00:50:39.257+0900 I/MY_LOG  ( 6842): change
04-09 00:50:39.277+0900 E/VCONF   ( 6842): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-09 00:50:39.277+0900 E/VCONF   ( 6842): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-09 00:50:39.277+0900 E/VCONF   ( 6842): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-09 00:50:39.277+0900 E/VCONF   ( 6842): vconf.c: vconf_get_bool(2729) > vconf_get_bool(6842) : db/ise/keysound error
04-09 00:50:39.277+0900 E/VCONF   ( 6842): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-09 00:50:39.277+0900 E/VCONF   ( 6842): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-09 00:50:39.317+0900 I/MY_LOG  ( 6842): change
04-09 00:50:40.208+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7777402
04-09 00:50:40.208+0900 I/MY_LOG  ( 6842): Button pressed
04-09 00:50:40.278+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7777468
04-09 00:50:40.278+0900 I/MY_LOG  ( 6842): Button unpressed
04-09 00:50:40.358+0900 E/EFL     ( 6842): elementary<6842> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-09 00:50:41.309+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: MEM_FLUSH State: PAUSED
04-09 00:50:43.371+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7780559
04-09 00:50:43.951+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7781146
04-09 00:50:48.326+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7785508
04-09 00:50:48.326+0900 I/MY_LOG  ( 6842): Button pressed
04-09 00:50:48.406+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7785596
04-09 00:50:48.406+0900 I/MY_LOG  ( 6842): Button unpressed
04-09 00:50:48.496+0900 D/basicui ( 6842): successed to load edc file
04-09 00:50:48.506+0900 I/MY_LOG  ( 6842): change
04-09 00:50:50.117+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7787302
04-09 00:50:50.428+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7787612
04-09 00:50:52.159+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7789334
04-09 00:50:52.219+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7789411
04-09 00:50:53.411+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7790605
04-09 00:50:53.491+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7790682
04-09 00:50:54.221+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7791411
04-09 00:50:54.302+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7791488
04-09 00:50:54.952+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7792142
04-09 00:50:55.353+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7792540
04-09 00:50:56.023+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7793209
04-09 00:50:56.364+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7793529
04-09 00:50:57.074+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7794254
04-09 00:50:57.144+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7794331
04-09 00:50:58.035+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7795222
04-09 00:50:58.125+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7795310
04-09 00:50:59.587+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7796777
04-09 00:50:59.587+0900 I/MY_LOG  ( 6842): Button pressed
04-09 00:50:59.667+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7796854
04-09 00:50:59.667+0900 I/MY_LOG  ( 6842): Button unpressed
04-09 00:50:59.687+0900 E/EFL     ( 6842): elementary<6842> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-09 00:50:59.997+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(195) > ""
04-09 00:51:00.007+0900 E/UXT     (  682): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:51
04-09 00:51:00.007+0900 I/INDICATOR(  682): clock.c: getTimeFormatted(176) > "time format : 오전 12:51"
04-09 00:51:00.007+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:51"
04-09 00:51:00.007+0900 W/INDICATOR(  682): clock.c: indicator_clock_changed_cb(272) > 
04-09 00:51:00.007+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145476264 Time: <font_size=31> </font_size> <font_size=31> 오전 12:51</font_size></font>"
04-09 00:51:01.338+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7798530
04-09 00:51:01.438+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7798629
04-09 00:51:01.489+0900 D/basicui ( 6842): successed to load edc file
04-09 00:51:01.509+0900 I/MY_LOG  ( 6842): change
04-09 00:51:01.509+0900 I/MY_LOG  ( 6842): change
04-09 00:51:01.529+0900 I/MY_LOG  ( 6842): change
04-09 00:51:02.510+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7799705
04-09 00:51:02.510+0900 I/MY_LOG  ( 6842): Button pressed
04-09 00:51:02.600+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7799792
04-09 00:51:02.600+0900 I/MY_LOG  ( 6842): Button unpressed
04-09 00:51:02.680+0900 E/EFL     ( 6842): elementary<6842> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-09 00:51:03.641+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7800837
04-09 00:51:03.751+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7800947
04-09 00:51:03.991+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:51:04.011+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(3)
04-09 00:51:04.011+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-09 00:51:04.011+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-09 00:51:04.011+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(868)
04-09 00:51:04.011+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-09 00:51:04.021+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-09 00:51:04.031+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6842 pgid = 6842
04-09 00:51:04.031+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(6842)
04-09 00:51:04.061+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-09 00:51:04.061+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:51:04.061+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:51:04.061+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-09 00:51:04.071+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-09 00:51:04.071+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-09 00:51:04.071+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-09 00:51:04.071+0900 I/Tizen::App( 1246): (243) > App[org.example.client] pid[6842] terminate event is forwarded
04-09 00:51:04.071+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-09 00:51:04.071+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [org.example.client, 6842, ]
04-09 00:51:04.071+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-09 00:51:04.071+0900 I/Tizen::App( 1246): (506) > TerminatedApp(org.example.client)
04-09 00:51:04.071+0900 I/Tizen::App( 1246): (512) > Not registered pid(6842)
04-09 00:51:04.071+0900 I/Tizen::System( 1246): (246) > Terminated app [org.example.client]
04-09 00:51:04.071+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:51:04.071+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 6842
04-09 00:51:04.071+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6842
04-09 00:51:04.071+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 6842
04-09 00:51:04.081+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.574
04-09 00:51:04.091+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:51:04.091+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for org.example.client, 6842.
04-09 00:51:04.101+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-09 00:51:04.101+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [org.exampl] 
04-09 00:51:04.111+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:51:04.141+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-09 00:51:04.141+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-09 00:51:04.141+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-09 00:51:04.141+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-09 00:51:04.151+0900 E/weather-widget( 1410): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-09 00:51:04.151+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:51:04.171+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7801362
04-09 00:51:04.181+0900 E/weather-common( 1410): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-09 00:51:04.181+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:51:04.181+0900 W/CRASH_MANAGER( 6913): worker.c: worker_job(1199) > 1106842636c69149166666
