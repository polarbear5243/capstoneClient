S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 2469
Date: 2017-04-06 06:32:54+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 2469, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x000009a5
r2   = 0x00000006, r3   = 0xb413a4c0
r4   = 0x00000002, r5   = 0xb413a000
r6   = 0xb683409c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f62708
r10  = 0xb915fd08, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbe8e6c1c
lr   = 0xb672af18, pc   = 0xb6729b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:    180716 KB
Buffers:     42032 KB
Cached:     316764 KB
VmPeak:     133908 KB
VmSize:     133904 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28324 KB
VmRSS:       28324 KB
VmData:      45844 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35780 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 2469 TID = 2469
2469 2470 3981 3982 3990 

Maps Information
af22e000 afa2d000 rw-p [stack:3990]
b0fdf000 b0ff0000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1000000 b1005000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1407000 b140f000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1421000 b1c20000 rw-p [stack:3982]
b1c20000 b1c21000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c31000 b1c45000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c59000 b1c5a000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c6a000 b1c6d000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c7e000 b1c7f000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c8f000 b1c91000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1ca1000 b1ca3000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1cb3000 b1cc3000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1cd3000 b1cdf000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cf1000 b24f0000 rw-p [stack:3981]
b2821000 b2828000 r-xp /usr/lib/libefl-extension.so.0.1.0
b283b000 b2841000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2851000 b286d000 r-xp /opt/usr/apps/org.example.client/bin/client
b29c6000 b2aa9000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ae0000 b2b08000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b1a000 b3319000 rw-p [stack:2470]
b3319000 b331b000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b332b000 b3335000 r-xp /lib/libnss_files-2.20-2014.11.so
b3346000 b334f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3360000 b3371000 r-xp /lib/libnsl-2.20-2014.11.so
b3384000 b338a000 r-xp /lib/libnss_compat-2.20-2014.11.so
b339b000 b339c000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33c4000 b33cb000 r-xp /usr/lib/libminizip.so.1.0.0
b33db000 b33e0000 r-xp /usr/lib/libstorage.so.0.1
b33f0000 b344f000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3465000 b3479000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3489000 b34cd000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34dd000 b34e5000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34f5000 b3525000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3538000 b35f1000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3605000 b3658000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3669000 b3684000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3694000 b3755000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3768000 b3778000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3788000 b3795000 r-xp /usr/lib/libmdm-common.so.1.0.98
b37a6000 b37ad000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b37bd000 b37fe000 r-xp /usr/lib/libmdm.so.1.2.12
b380e000 b3816000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3825000 b3835000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3856000 b38b6000 r-xp /usr/lib/libasound.so.2.0.0
b38c8000 b38cb000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38db000 b38de000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38ee000 b38f3000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3903000 b3904000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3914000 b391f000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3933000 b393a000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b394a000 b3950000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3960000 b3965000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3975000 b3990000 r-xp /usr/lib/libmmfsound.so.0.1.0
b39a0000 b39a7000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b39b7000 b39ba000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39cb000 b39f9000 r-xp /usr/lib/libidn.so.11.5.44
b3a09000 b3a1f000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a30000 b3a3a000 r-xp /usr/lib/libcares.so.2.1.0
b3a4a000 b3a54000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a64000 b3a66000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a76000 b3a77000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a87000 b3a8b000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a9c000 b3ac4000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ad5000 b3afe000 r-xp /usr/lib/libturbojpeg.so
b3b1e000 b3b24000 r-xp /usr/lib/libgif.so.4.1.6
b3b34000 b3b7a000 r-xp /usr/lib/libcurl.so.4.3.0
b3b8b000 b3bac000 r-xp /usr/lib/libexif.so.12.3.3
b3bc7000 b3bdc000 r-xp /usr/lib/libtts.so
b3bed000 b3bf5000 r-xp /usr/lib/libfeedback.so.0.1.4
b3c05000 b3ccb000 r-xp /usr/lib/libdali-core.so.0.0.0
b3ceb000 b3de3000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3e02000 b3ed0000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ee7000 b3ee9000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ef9000 b3eff000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3f0f000 b3f32000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f43000 b3f45000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f55000 b3f57000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f68000 b3f6d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f84000 b3f86000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f96000 b3f9d000 r-xp /usr/lib/libsensord-share.so
b3fad000 b3fc5000 r-xp /usr/lib/libsensor.so.1.1.0
b3fd6000 b3fd9000 r-xp /usr/lib/libXv.so.1.0.0
b3fe9000 b3fee000 r-xp /usr/lib/libutilX.so.1.1.0
b3ffe000 b4003000 r-xp /usr/lib/libappcore-common.so.1.1
b4013000 b401a000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b402d000 b4031000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4042000 b4120000 r-xp /usr/lib/libCOREGL.so.4.0
b4140000 b4143000 r-xp /usr/lib/libuuid.so.1.3.0
b4153000 b416a000 r-xp /usr/lib/libblkid.so.1.1.0
b417b000 b417d000 r-xp /usr/lib/libXau.so.6.0.0
b418d000 b41d4000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41e6000 b41ec000 r-xp /usr/lib/libjson-c.so.2.0.1
b41fd000 b4201000 r-xp /usr/lib/libogg.so.0.7.1
b4211000 b4233000 r-xp /usr/lib/libvorbis.so.0.4.3
b4243000 b4327000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4343000 b4346000 r-xp /usr/lib/libEGL.so.1.4
b4357000 b435d000 r-xp /usr/lib/libxcb-render.so.0.0.0
b436d000 b436f000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b437f000 b438c000 r-xp /usr/lib/libGLESv2.so.2.0
b439d000 b43ff000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4414000 b442c000 r-xp /usr/lib/libmount.so.1.1.0
b443e000 b4452000 r-xp /usr/lib/libxcb.so.1.1.0
b4462000 b4469000 r-xp /lib/libcrypt-2.20-2014.11.so
b44a1000 b44a3000 r-xp /usr/lib/libiri.so
b44b3000 b44be000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44cf000 b4505000 r-xp /usr/lib/libpulse.so.0.16.2
b4516000 b4559000 r-xp /usr/lib/libsndfile.so.1.0.25
b456e000 b4583000 r-xp /lib/libexpat.so.1.5.2
b4595000 b4653000 r-xp /usr/lib/libcairo.so.2.11200.14
b4667000 b466f000 r-xp /usr/lib/libdrm.so.2.4.0
b467f000 b4682000 r-xp /usr/lib/libdri2.so.0.0.0
b4692000 b46e0000 r-xp /usr/lib/libssl.so.1.0.0
b46f5000 b4701000 r-xp /usr/lib/libeeze.so.1.13.0
b4712000 b471b000 r-xp /usr/lib/libethumb.so.1.13.0
b472b000 b472e000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b473e000 b48f5000 r-xp /usr/lib/libcrypto.so.1.0.0
b56e0000 b56e9000 r-xp /usr/lib/libXi.so.6.1.0
b56f9000 b56fb000 r-xp /usr/lib/libXgesture.so.7.0.0
b570b000 b570f000 r-xp /usr/lib/libXtst.so.6.1.0
b571f000 b5725000 r-xp /usr/lib/libXrender.so.1.3.0
b5735000 b573b000 r-xp /usr/lib/libXrandr.so.2.2.0
b574b000 b574d000 r-xp /usr/lib/libXinerama.so.1.0.0
b575e000 b5761000 r-xp /usr/lib/libXfixes.so.3.1.0
b5771000 b577c000 r-xp /usr/lib/libXext.so.6.4.0
b578c000 b578e000 r-xp /usr/lib/libXdamage.so.1.1.0
b579e000 b57a0000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57b0000 b5892000 r-xp /usr/lib/libX11.so.6.3.0
b58a6000 b58ad000 r-xp /usr/lib/libXcursor.so.1.0.2
b58bd000 b58d5000 r-xp /usr/lib/libudev.so.1.6.0
b58d7000 b58da000 r-xp /lib/libattr.so.1.1.0
b58ea000 b590a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b590b000 b5910000 r-xp /usr/lib/libffi.so.6.0.2
b5921000 b5939000 r-xp /lib/libz.so.1.2.8
b5949000 b594b000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b595b000 b5a30000 r-xp /usr/lib/libxml2.so.2.9.2
b5a45000 b5ae0000 r-xp /usr/lib/libstdc++.so.6.0.20
b5afc000 b5aff000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b0f000 b5b28000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b39000 b5b4a000 r-xp /lib/libresolv-2.20-2014.11.so
b5b5e000 b5bd8000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bed000 b5bef000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bff000 b5c06000 r-xp /usr/lib/libembryo.so.1.13.0
b5c16000 b5c20000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c31000 b5c49000 r-xp /usr/lib/libpng12.so.0.50.0
b5c5a000 b5c7d000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c9e000 b5cb2000 r-xp /usr/lib/libector.so.1.13.0
b5cc3000 b5cdb000 r-xp /usr/lib/liblua-5.1.so
b5cec000 b5d43000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d57000 b5d7f000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d90000 b5da3000 r-xp /usr/lib/libfribidi.so.0.3.1
b5db4000 b5dee000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dff000 b5e0d000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e1d000 b5e25000 r-xp /usr/lib/libtbm.so.1.0.0
b5e35000 b5e42000 r-xp /usr/lib/libeio.so.1.13.0
b5e52000 b5e54000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e64000 b5e69000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e79000 b5e90000 r-xp /usr/lib/libefreet.so.1.13.0
b5ea2000 b5ec2000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ed2000 b5ef2000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ef4000 b5efa000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f0a000 b5f1b000 r-xp /usr/lib/libemotion.so.1.13.0
b5f2c000 b5f33000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f43000 b5f52000 r-xp /usr/lib/libeo.so.1.13.0
b5f63000 b5f75000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f86000 b5f8b000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f9b000 b5fb4000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fc4000 b5fe1000 r-xp /usr/lib/libeet.so.1.13.0
b5ffa000 b6042000 r-xp /usr/lib/libeina.so.1.13.0
b6053000 b6063000 r-xp /usr/lib/libefl.so.1.13.0
b6074000 b6159000 r-xp /usr/lib/libicuuc.so.51.1
b6176000 b62b6000 r-xp /usr/lib/libicui18n.so.51.1
b62cd000 b6305000 r-xp /usr/lib/libecore_x.so.1.13.0
b6317000 b631a000 r-xp /lib/libcap.so.2.21
b632a000 b6353000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6364000 b636b000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b637d000 b63b4000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63c5000 b64b0000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64c3000 b653c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b654e000 b6553000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6563000 b656d000 r-xp /usr/lib/libvconf.so.0.2.45
b657d000 b657f000 r-xp /usr/lib/libvasum.so.0.3.1
b658f000 b6591000 r-xp /usr/lib/libttrace.so.1.1
b65a1000 b65a4000 r-xp /usr/lib/libiniparser.so.0
b65b4000 b65da000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65ea000 b65ef000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6600000 b6617000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6628000 b6693000 r-xp /lib/libm-2.20-2014.11.so
b66a4000 b66aa000 r-xp /lib/librt-2.20-2014.11.so
b66bb000 b66c8000 r-xp /usr/lib/libunwind.so.8.0.1
b66fe000 b6822000 r-xp /lib/libc-2.20-2014.11.so
b6837000 b6850000 r-xp /lib/libgcc_s-4.9.so.1
b6860000 b6942000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6953000 b697d000 r-xp /usr/lib/libdbus-1.so.3.8.12
b698e000 b69ca000 r-xp /usr/lib/libsystemd.so.0.4.0
b69cc000 b6a4f000 r-xp /usr/lib/libedje.so.1.13.0
b6a62000 b6a80000 r-xp /usr/lib/libecore.so.1.13.0
b6aa0000 b6c27000 r-xp /usr/lib/libevas.so.1.13.0
b6c5c000 b6c70000 r-xp /lib/libpthread-2.20-2014.11.so
b6c84000 b6eb8000 r-xp /usr/lib/libelementary.so.1.13.0
b6ee7000 b6eeb000 r-xp /usr/lib/libsmack.so.1.0.0
b6efb000 b6f02000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f12000 b6f14000 r-xp /usr/lib/libdlog.so.0.0.0
b6f24000 b6f27000 r-xp /usr/lib/libbundle.so.0.1.22
b6f37000 b6f39000 r-xp /lib/libdl-2.20-2014.11.so
b6f4a000 b6f62000 r-xp /usr/lib/libaul.so.0.1.0
b6f76000 b6f7b000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f8c000 b6f99000 r-xp /usr/lib/liblptcp.so
b6fab000 b6faf000 r-xp /usr/lib/libsys-assert.so
b6fc0000 b6fe0000 r-xp /lib/ld-2.20-2014.11.so
b6ff1000 b6ff6000 r-xp /usr/bin/launchpad-loader
b8ddc000 b91bb000 rw-p [heap]
be8c7000 be8e8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2469)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6729b84) [/lib/libc.so.6] + 0x2bb84
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
est_signal(423) > send_app_launch_signal, pid: 3721, appid: org.example.client
04-06 06:29:06.904+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 06:29:06.924+0900 W/AUL     ( 3718): launch.c: app_request_to_launchpad(425) > request cmd(0) result(3721)
04-06 06:29:07.905+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 06:29:07.905+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 06:29:10.468+0900 I/abc     ( 3721): abc
04-06 06:29:10.488+0900 I/CAPI_APPFW_APPLICATION( 3721): app_main.c: ui_app_main(789) > app_efl_main
04-06 06:29:11.609+0900 I/CAPI_APPFW_APPLICATION( 3721): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 06:29:11.909+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(3721)
04-06 06:29:11.909+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 3721, appid: org.example.client, status: bg
04-06 06:29:13.841+0900 E/TBM     ( 3721): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 06:29:15.022+0900 D/basicui ( 3721): successed to load edc file
04-06 06:29:15.052+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 06:29:15.052+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 06:29:15.082+0900 I/Tizen::System( 1248): (259) > Active app [org.exampl], current [com.samsun] 
04-06 06:29:15.082+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 06:29:15.082+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 06:29:15.082+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 06:29:15.753+0900 I/MY_LOG  ( 3721): change
04-06 06:29:15.803+0900 I/APP_CORE( 3721): appcore-efl.c: __do_app(514) > [APP 3721] Event: RESET State: CREATED
04-06 06:29:15.803+0900 I/CAPI_APPFW_APPLICATION( 3721): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 06:29:15.833+0900 W/APP_CORE( 3721): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6800002
04-06 06:29:15.833+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 06:29:16.083+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: PAUSE State: RUNNING
04-06 06:29:16.083+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 06:29:16.083+0900 E/cluster-home(  869): homescreen.cpp: OnPause(260) >  app pause
04-06 06:29:16.083+0900 I/APP_CORE( 3721): appcore-efl.c: __do_app(514) > [APP 3721] Event: RESUME State: CREATED
04-06 06:29:16.083+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(4)
04-06 06:29:16.083+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(869)
04-06 06:29:16.083+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: bg
04-06 06:29:16.083+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(3721) status(3)
04-06 06:29:16.093+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 06:29:16.093+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 06:29:16.093+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(3721)
04-06 06:29:16.093+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 3721, appid: org.example.client, status: fg
04-06 06:29:16.093+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 06:29:16.093+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 06:29:16.093+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: bg
04-06 06:29:16.113+0900 I/APP_CORE( 3721): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 06:29:16.113+0900 I/APP_CORE( 3721): appcore-efl.c: __do_app(625) > [APP 3721] Initial Launching, call the resume_cb
04-06 06:29:16.113+0900 I/CAPI_APPFW_APPLICATION( 3721): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 06:29:16.443+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(3721) status(0)
04-06 06:29:17.574+0900 I/MY_LOG  ( 3721): Button pressed
04-06 06:29:17.675+0900 E/VCONF   ( 3721): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 06:29:17.675+0900 E/VCONF   ( 3721): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 06:29:17.675+0900 E/VCONF   ( 3721): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 06:29:17.675+0900 E/VCONF   ( 3721): vconf.c: vconf_get_bool(2729) > vconf_get_bool(3721) : db/ise/keysound error
04-06 06:29:17.685+0900 E/VCONF   ( 3721): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 06:29:17.685+0900 E/VCONF   ( 3721): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 06:29:17.735+0900 I/MY_LOG  ( 3721): Button unpressed
04-06 06:29:21.088+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: MEM_FLUSH State: PAUSED
04-06 06:30:00.857+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-06 06:30:00.857+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 6:30
04-06 06:30:00.857+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 6:30"
04-06 06:30:00.857+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 6:30"
04-06 06:30:00.867+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-06 06:30:00.867+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146224737 Time: <font_size=31> </font_size> <font_size=31> 오전 6:30</font_size></font>"
04-06 06:31:00.915+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-06 06:31:00.945+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 6:31
04-06 06:31:00.945+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 6:31"
04-06 06:31:00.945+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 6:31"
04-06 06:31:00.945+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-06 06:31:00.945+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146222685 Time: <font_size=31> </font_size> <font_size=31> 오전 6:31</font_size></font>"
04-06 06:31:08.773+0900 D/basicui ( 3721): successed to load edc file
04-06 06:31:08.793+0900 I/MY_LOG  ( 3721): change
04-06 06:31:25.739+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:31:25.739+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:31:25.739+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:31:25.739+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:31:25.739+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 06:31:25.739+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 06:31:25.739+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 06:31:25.739+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:31:25.739+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:31:25.739+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:31:25.739+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 06:31:25.739+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 06:31:36.940+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 06:31:36.960+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(3)
04-06 06:31:36.960+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 06:31:36.960+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 06:31:36.960+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(869)
04-06 06:31:36.960+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: fg
04-06 06:31:36.970+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(0)
04-06 06:31:37.000+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 06:31:37.000+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: RESUME State: PAUSED
04-06 06:31:37.000+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 06:31:37.000+0900 E/cluster-home(  869): homescreen.cpp: OnResume(233) >  app resume
04-06 06:31:37.020+0900 I/Tizen::System( 1248): (259) > Active app [com.samsun], current [org.exampl] 
04-06 06:31:37.020+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 06:31:37.031+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 06:31:37.031+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 06:31:37.031+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 06:31:37.031+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: fg
04-06 06:31:37.041+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:31:37.051+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:31:37.051+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 06:31:37.051+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 06:31:37.051+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 06:31:37.051+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 06:31:37.051+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 06:31:38.041+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:31:38.041+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:31:38.062+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:31:38.062+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:31:38.072+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:31:38.082+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:31:38.092+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:31:38.092+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:31:38.112+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:31:38.112+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:31:38.132+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:31:38.132+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:31:38.152+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:31:38.152+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:31:38.172+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:31:38.172+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:31:38.182+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:31:38.192+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:31:38.202+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:31:38.212+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:31:38.222+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:31:38.222+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:31:38.232+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:31:38.232+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:31:38.242+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:31:38.252+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:31:42.196+0900 E/PKGMGR_SERVER( 3800): pkgmgr-server.c: main(2414) > package manager server start
04-06 06:31:42.246+0900 E/PKGMGR  ( 3798): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-06 06:31:42.286+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 06:31:42.286+0900 E/AUL_AMD (  610): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 3426
04-06 06:31:42.286+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-06 06:31:42.296+0900 E/PKGMGR_SERVER( 3800): pkgmgr-server.c: sighandler(417) > child NORMAL exit [3803]
04-06 06:31:44.638+0900 W/AUL     ( 3855): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-06 06:31:44.648+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-06 06:31:44.648+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-06 06:31:44.658+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-06 06:31:44.658+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 06:31:44.658+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 3855
04-06 06:31:44.658+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 06:31:44.668+0900 E/RESOURCED(  665): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-06 06:31:44.668+0900 E/RESOURCED(  665): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 06:31:44.668+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-4)
04-06 06:31:44.788+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 3857, appid: org.example.client
04-06 06:31:44.788+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 06:31:44.798+0900 W/AUL     ( 3855): launch.c: app_request_to_launchpad(425) > request cmd(0) result(3857)
04-06 06:31:44.898+0900 E/PKGMGR_SERVER( 3800): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 06:31:44.898+0900 E/PKGMGR_SERVER( 3800): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 06:31:45.789+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 06:31:45.789+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 06:31:47.981+0900 I/abc     ( 3857): abc
04-06 06:31:47.991+0900 I/CAPI_APPFW_APPLICATION( 3857): app_main.c: ui_app_main(789) > app_efl_main
04-06 06:31:49.122+0900 I/CAPI_APPFW_APPLICATION( 3857): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 06:31:49.793+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(3857)
04-06 06:31:49.793+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 3857, appid: org.example.client, status: bg
04-06 06:31:51.254+0900 E/TBM     ( 3857): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 06:31:52.295+0900 D/basicui ( 3857): successed to load edc file
04-06 06:31:52.325+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 06:31:52.325+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 06:31:52.355+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 06:31:52.355+0900 I/Tizen::System( 1248): (259) > Active app [org.exampl], current [com.samsun] 
04-06 06:31:52.355+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 06:31:52.365+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 06:31:53.086+0900 I/MY_LOG  ( 3857): change
04-06 06:31:53.146+0900 I/APP_CORE( 3857): appcore-efl.c: __do_app(514) > [APP 3857] Event: RESET State: CREATED
04-06 06:31:53.146+0900 I/CAPI_APPFW_APPLICATION( 3857): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 06:31:53.166+0900 W/APP_CORE( 3857): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6800002
04-06 06:31:53.166+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 06:31:53.406+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: PAUSE State: RUNNING
04-06 06:31:53.406+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 06:31:53.406+0900 E/cluster-home(  869): homescreen.cpp: OnPause(260) >  app pause
04-06 06:31:53.416+0900 I/APP_CORE( 3857): appcore-efl.c: __do_app(514) > [APP 3857] Event: RESUME State: CREATED
04-06 06:31:53.416+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(4)
04-06 06:31:53.416+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(869)
04-06 06:31:53.416+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: bg
04-06 06:31:53.416+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(3857) status(3)
04-06 06:31:53.416+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 06:31:53.416+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 06:31:53.416+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(3857)
04-06 06:31:53.416+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 3857, appid: org.example.client, status: fg
04-06 06:31:53.427+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 06:31:53.427+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 06:31:53.427+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: bg
04-06 06:31:53.447+0900 I/APP_CORE( 3857): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 06:31:53.447+0900 I/APP_CORE( 3857): appcore-efl.c: __do_app(625) > [APP 3857] Initial Launching, call the resume_cb
04-06 06:31:53.447+0900 I/CAPI_APPFW_APPLICATION( 3857): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 06:31:53.787+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(3857) status(0)
04-06 06:31:54.407+0900 I/MY_LOG  ( 3857): Button pressed
04-06 06:31:54.508+0900 E/VCONF   ( 3857): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 06:31:54.508+0900 E/VCONF   ( 3857): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 06:31:54.508+0900 E/VCONF   ( 3857): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 06:31:54.508+0900 E/VCONF   ( 3857): vconf.c: vconf_get_bool(2729) > vconf_get_bool(3857) : db/ise/keysound error
04-06 06:31:54.508+0900 E/VCONF   ( 3857): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 06:31:54.508+0900 E/VCONF   ( 3857): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 06:31:54.558+0900 I/MY_LOG  ( 3857): Button unpressed
04-06 06:31:58.421+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: MEM_FLUSH State: PAUSED
04-06 06:31:59.022+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:31:59.022+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:31:59.022+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:31:59.022+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:31:59.022+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 06:31:59.022+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 06:31:59.022+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 06:31:59.022+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:31:59.022+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:31:59.022+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:31:59.032+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 06:31:59.032+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 06:32:00.914+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-06 06:32:00.934+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 6:32
04-06 06:32:00.934+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 6:32"
04-06 06:32:00.934+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 6:32"
04-06 06:32:00.934+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-06 06:32:00.944+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146156506 Time: <font_size=31> </font_size> <font_size=31> 오전 6:32</font_size></font>"
04-06 06:32:02.405+0900 D/basicui ( 3857): successed to load edc file
04-06 06:32:02.425+0900 I/MY_LOG  ( 3857): change
04-06 06:32:24.627+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:32:24.627+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:32:24.627+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:32:24.627+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:32:24.627+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 06:32:24.627+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 06:32:24.627+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 06:32:24.627+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:32:24.627+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:32:24.627+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:32:24.627+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 06:32:24.627+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 06:32:29.742+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:32:29.742+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:32:29.742+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:32:29.742+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:32:29.752+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 06:32:29.752+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 06:32:29.752+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 06:32:29.752+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:32:29.752+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:32:29.752+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 06:32:29.752+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 06:32:29.752+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 06:32:45.487+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 06:32:45.507+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(3)
04-06 06:32:45.507+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 06:32:45.507+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 06:32:45.507+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(869)
04-06 06:32:45.507+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: fg
04-06 06:32:45.547+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 06:32:45.547+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: RESUME State: PAUSED
04-06 06:32:45.547+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 06:32:45.547+0900 E/cluster-home(  869): homescreen.cpp: OnResume(233) >  app resume
04-06 06:32:45.557+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(0)
04-06 06:32:45.587+0900 I/Tizen::System( 1248): (259) > Active app [com.samsun], current [org.exampl] 
04-06 06:32:45.587+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 06:32:45.587+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 06:32:45.587+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 06:32:45.587+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: fg
04-06 06:32:45.597+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 06:32:45.627+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:32:45.627+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:32:45.637+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 06:32:45.637+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 06:32:45.647+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 06:32:45.647+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 06:32:45.647+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 06:32:46.618+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:32:46.618+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:32:46.628+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:32:46.638+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:32:46.648+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:32:46.658+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:32:46.668+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:32:46.668+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:32:46.688+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:32:46.688+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:32:46.708+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:32:46.708+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:32:46.729+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:32:46.729+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:32:46.749+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:32:46.749+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:32:46.749+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:32:46.749+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:32:46.769+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:32:46.769+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:32:46.789+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:32:46.789+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:32:46.799+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:32:46.809+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:32:46.819+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:32:46.829+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:32:49.231+0900 E/PKGMGR_SERVER( 3922): pkgmgr-server.c: main(2414) > package manager server start
04-06 06:32:49.281+0900 E/PKGMGR  ( 3920): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-06 06:32:49.311+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 06:32:49.311+0900 E/AUL_AMD (  610): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 3721
04-06 06:32:49.321+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-06 06:32:49.331+0900 E/PKGMGR_SERVER( 3922): pkgmgr-server.c: sighandler(417) > child NORMAL exit [3925]
04-06 06:32:51.523+0900 W/AUL     ( 3974): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-06 06:32:51.523+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-06 06:32:51.533+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-06 06:32:51.543+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-06 06:32:51.543+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 06:32:51.543+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 3974
04-06 06:32:51.543+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 06:32:51.553+0900 E/RESOURCED(  665): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-06 06:32:51.553+0900 E/RESOURCED(  665): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 06:32:51.553+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 06:32:51.553+0900 W/AUL_PAD ( 1536): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 06:32:51.553+0900 W/AUL_PAD ( 1536): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 06:32:51.563+0900 I/abc     ( 2469): abc
04-06 06:32:51.573+0900 I/CAPI_APPFW_APPLICATION( 2469): app_main.c: ui_app_main(789) > app_efl_main
04-06 06:32:51.573+0900 I/CAPI_APPFW_APPLICATION( 2469): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 06:32:51.603+0900 E/TBM     ( 2469): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 06:32:51.653+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 2469, appid: org.example.client
04-06 06:32:51.653+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 06:32:51.663+0900 W/AUL     ( 3974): launch.c: app_request_to_launchpad(425) > request cmd(0) result(2469)
04-06 06:32:51.894+0900 E/PKGMGR_SERVER( 3922): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 06:32:51.894+0900 E/PKGMGR_SERVER( 3922): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 06:32:51.904+0900 D/basicui ( 2469): successed to load edc file
04-06 06:32:51.934+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 06:32:51.934+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 06:32:51.954+0900 I/Tizen::System( 1248): (259) > Active app [org.exampl], current [com.samsun] 
04-06 06:32:51.954+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 06:32:51.954+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 06:32:51.964+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 06:32:51.994+0900 I/MY_LOG  ( 2469): change
04-06 06:32:52.034+0900 I/APP_CORE( 2469): appcore-efl.c: __do_app(514) > [APP 2469] Event: RESET State: CREATED
04-06 06:32:52.034+0900 I/CAPI_APPFW_APPLICATION( 2469): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 06:32:52.044+0900 E/EFL     ( 2469): edje<2469> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 06:32:52.044+0900 E/EFL     ( 2469): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 06:32:52.054+0900 E/EFL     ( 2469): edje<2469> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 06:32:52.054+0900 E/EFL     ( 2469): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 06:32:52.054+0900 E/EFL     ( 2469): edje<2469> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 06:32:52.054+0900 E/EFL     ( 2469): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 06:32:52.064+0900 W/APP_CORE( 2469): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
04-06 06:32:52.064+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 06:32:52.164+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: PAUSE State: RUNNING
04-06 06:32:52.164+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 06:32:52.164+0900 E/cluster-home(  869): homescreen.cpp: OnPause(260) >  app pause
04-06 06:32:52.174+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(4)
04-06 06:32:52.174+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(869)
04-06 06:32:52.174+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: bg
04-06 06:32:52.174+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(2469) status(3)
04-06 06:32:52.174+0900 I/APP_CORE( 2469): appcore-efl.c: __do_app(514) > [APP 2469] Event: RESUME State: CREATED
04-06 06:32:52.174+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 06:32:52.174+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 06:32:52.174+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(2469)
04-06 06:32:52.174+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 2469, appid: org.example.client, status: fg
04-06 06:32:52.184+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 06:32:52.184+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 06:32:52.184+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: bg
04-06 06:32:52.184+0900 I/APP_CORE( 2469): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 06:32:52.184+0900 I/APP_CORE( 2469): appcore-efl.c: __do_app(625) > [APP 2469] Initial Launching, call the resume_cb
04-06 06:32:52.184+0900 I/CAPI_APPFW_APPLICATION( 2469): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 06:32:52.544+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(2469) status(0)
04-06 06:32:52.724+0900 I/Tizen::App( 1248): (499) > LaunchedApp(org.example.client)
04-06 06:32:52.724+0900 I/Tizen::App( 1248): (733) > Finished invoking application event listener for org.example.client, 2469.
04-06 06:32:52.724+0900 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.362
04-06 06:32:53.485+0900 I/UXT     ( 3987): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 06:32:54.116+0900 E/EFL     ( 2469): ecore_x<2469> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=2731226
04-06 06:32:54.126+0900 I/MY_LOG  ( 2469): Button pressed
04-06 06:32:54.206+0900 E/EFL     ( 2469): ecore_x<2469> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=2731314
04-06 06:32:54.216+0900 E/VCONF   ( 2469): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 06:32:54.216+0900 E/VCONF   ( 2469): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 06:32:54.216+0900 E/VCONF   ( 2469): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 06:32:54.216+0900 E/VCONF   ( 2469): vconf.c: vconf_get_bool(2729) > vconf_get_bool(2469) : db/ise/keysound error
04-06 06:32:54.216+0900 E/VCONF   ( 2469): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 06:32:54.216+0900 E/VCONF   ( 2469): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 06:32:54.266+0900 I/MY_LOG  ( 2469): Button unpressed
04-06 06:32:54.416+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 06:32:54.416+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(3)
04-06 06:32:54.416+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 06:32:54.416+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 06:32:54.426+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(869)
04-06 06:32:54.426+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: fg
04-06 06:32:54.436+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 2469 pgid = 2469
04-06 06:32:54.436+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(143) > dead_pid(2469)
04-06 06:32:54.476+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 06:32:54.476+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 06:32:54.476+0900 E/AUL_PAD ( 1536): launchpad.c: main(698) > error reading sigchld info
04-06 06:32:54.476+0900 I/Tizen::App( 1248): (243) > App[org.example.client] pid[2469] terminate event is forwarded
04-06 06:32:54.476+0900 I/Tizen::System( 1248): (256) > osp.accessorymanager.service provider is found.
04-06 06:32:54.476+0900 I/Tizen::System( 1248): (196) > Accessory Owner is removed [org.example.client, 2469, ]
04-06 06:32:54.476+0900 I/Tizen::System( 1248): (256) > osp.system.service provider is found.
04-06 06:32:54.476+0900 I/Tizen::App( 1248): (506) > TerminatedApp(org.example.client)
04-06 06:32:54.476+0900 I/Tizen::App( 1248): (512) > Not registered pid(2469)
04-06 06:32:54.476+0900 I/Tizen::System( 1248): (246) > Terminated app [org.example.client]
04-06 06:32:54.476+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 06:32:54.486+0900 I/ESD     (  901): esd_main.c: __esd_app_dead_handler(1773) > pid: 2469
04-06 06:32:54.486+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 2469
04-06 06:32:54.486+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 2469
04-06 06:32:54.486+0900 E/EFL     (  663): <663> lib/ecore_ipc/ecore_ipc.c:804 ecore_ipc_client_send() safety check failed: !ecore_con_client_connected_get(cl->client) is true
04-06 06:32:54.486+0900 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.366
04-06 06:32:54.496+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(0)
04-06 06:32:54.506+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 06:32:54.506+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: RESUME State: PAUSED
04-06 06:32:54.506+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 06:32:54.506+0900 E/cluster-home(  869): homescreen.cpp: OnResume(233) >  app resume
04-06 06:32:54.506+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 06:32:54.506+0900 I/Tizen::App( 1248): (782) > Finished invoking application event listener for org.example.client, 2469.
04-06 06:32:54.516+0900 I/Tizen::System( 1248): (259) > Active app [com.samsun], current [org.exampl] 
04-06 06:32:54.526+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 06:32:54.526+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 06:32:54.536+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 06:32:54.536+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 06:32:54.536+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: fg
04-06 06:32:54.576+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 06:32:54.586+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 06:32:54.586+0900 W/CRASH_MANAGER( 3992): worker.c: worker_job(1199) > 0602469636c69149142797
