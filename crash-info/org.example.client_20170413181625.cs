S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 26723
Date: 2017-04-13 18:16:25+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 26723, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00006863
r2   = 0x00000006, r3   = 0xb413a4c0
r4   = 0x00000002, r5   = 0xb413a000
r6   = 0xb683409c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f62708
r10  = 0xb77af1c0, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbeaeba64
lr   = 0xb672af18, pc   = 0xb6729b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     56736 KB
Buffers:     66792 KB
Cached:     355444 KB
VmPeak:     134448 KB
VmSize:     133416 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27908 KB
VmRSS:       27560 KB
VmData:      45548 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35732 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 26723 TID = 26723
26723 26724 26803 26804 26812 

Maps Information
af22e000 afa2d000 rw-p [stack:26812]
b13fd000 b1405000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1417000 b1c16000 rw-p [stack:26804]
b1c16000 b1c17000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c27000 b1c3b000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c4f000 b1c50000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c60000 b1c63000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c74000 b1c75000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c85000 b1c87000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c97000 b1c99000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1ca9000 b1cb9000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1cc9000 b1cd5000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1ce7000 b24e6000 rw-p [stack:26803]
b2817000 b281e000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2831000 b2837000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2847000 b286d000 r-xp /opt/usr/apps/org.example.client/bin/client
b29c6000 b2aa9000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ae0000 b2b08000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b1a000 b3319000 rw-p [stack:26724]
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
b7476000 b7821000 rw-p [heap]
beacc000 beaed000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26723)
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
13 18:13:40.599+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-13 18:13:40.599+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [30]
04-13 18:13:40.599+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-13 18:13:40.599+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.599+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.599+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.599+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.599+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.599+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.599+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.599+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:40.849+0900 E/rpm-installer(26655): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-13 18:13:40.849+0900 E/rpm-installer(26655): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-13 18:13:40.849+0900 E/rpm-installer(26655): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-13 18:13:40.849+0900 E/rpm-installer(26655): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-13 18:13:40.849+0900 E/rpm-installer(26655): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-13 18:13:40.849+0900 E/rpm-installer(26655): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-13 18:13:40.859+0900 E/PKGMGR_PARSER(26655): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-13 18:13:40.859+0900 E/PKGMGR_PARSER(26655): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-13 18:13:40.889+0900 I/PRIVACY-MANAGER-CLIENT(26655): SocketClient.cpp: SocketClient(37) > Client created
04-13 18:13:41.099+0900 E/PKGMGR_PARSER(26655): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-13 18:13:41.119+0900 E/PKGMGR_CERT(26655): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-13 18:13:41.119+0900 E/PKGMGR_CERT(26655): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 110
04-13 18:13:41.119+0900 E/PKGMGR_CERT(26655): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 110
04-13 18:13:41.119+0900 E/PKGMGR_CERT(26655): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-13 18:13:41.119+0900 E/PKGMGR_CERT(26655): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 5
04-13 18:13:41.119+0900 E/PKGMGR_CERT(26655): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 5
04-13 18:13:41.119+0900 E/PKGMGR_CERT(26655): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-13 18:13:41.129+0900 E/PKGMGR_CERT(26655): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-13 18:13:41.139+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-13 18:13:41.139+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [60]
04-13 18:13:41.139+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
04-13 18:13:41.139+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.139+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.139+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.139+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.139+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.139+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.139+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.139+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.149+0900 E/rpm-installer(26655): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-13 18:13:41.169+0900 E/rpm-installer(26655): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-13 18:13:41.179+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.179+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-13 18:13:41.179+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.179+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.179+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [100]
04-13 18:13:41.179+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.179+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-13 18:13:41.179+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.179+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.179+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:41.179+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:42.551+0900 E/PKGMGR_SERVER(26652): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-13 18:13:43.041+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:43.041+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-13 18:13:43.041+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:43.041+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:43.041+0900 I/Tizen::App( 1246): (78) > Installation is Completed. [Package = org.example.client]
04-13 18:13:43.041+0900 I/Tizen::App( 1246): (671) > Enter. package(org.example.client), installationResult(0)
04-13 18:13:43.041+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:43.041+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:43.041+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:43.041+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:43.041+0900 E/PKGMGR  ( 1479): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-13 18:13:43.041+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-13 18:13:43.041+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-13 18:13:43.041+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-13 18:13:43.041+0900 I/Tizen::App( 1246): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-13 18:13:43.061+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-13 18:13:43.061+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-13 18:13:43.061+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-13 18:13:43.061+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-13 18:13:43.061+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-13 18:13:43.061+0900 I/Tizen::App( 1246): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-13 18:13:43.081+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-13 18:13:43.081+0900 E/HOME_APPS(  868): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-13 18:13:43.081+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-13 18:13:43.081+0900 W/ISF_PANEL_EFL(  789): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-13 18:13:43.081+0900 W/HOME_APPS(  868): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-13 18:13:43.111+0900 E/util-view(  868): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-13 18:13:43.111+0900 E/PKGMGR_SERVER(26652): pkgmgr-server.c: sighandler(417) > child NORMAL exit [26655]
04-13 18:13:43.111+0900 I/Tizen::App( 1246): (416) > appName = [client]
04-13 18:13:43.111+0900 I/Tizen::App( 1246): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-13 18:13:43.111+0900 E/PKGMGR_INFO( 1246): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-13 18:13:43.111+0900 I/Tizen::App( 1246): (683) > Application count(1) in this package
04-13 18:13:43.111+0900 I/Tizen::App( 1246): (703) > Exit.
04-13 18:13:43.111+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-13 18:13:43.111+0900 I/Tizen::App( 1246): (840) > Enter.
04-13 18:13:43.131+0900 I/Tizen::App( 1246): (416) > appName = [client]
04-13 18:13:43.131+0900 I/Tizen::App( 1246): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-13 18:13:43.131+0900 I/Tizen::App( 1246): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-13 18:13:43.131+0900 I/Tizen::App( 1246): (131) > Enter
04-13 18:13:43.141+0900 W/HOME_APPS(  868): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-13 18:13:43.141+0900 I/Tizen::App( 1246): (137) > org.example.client does not have launch condition
04-13 18:13:43.141+0900 I/Tizen::App( 1246): (883) > Exit.
04-13 18:13:44.553+0900 E/PKGMGR_SERVER(26652): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-13 18:13:44.553+0900 E/PKGMGR_SERVER(26652): pkgmgr-server.c: main(2471) > package manager server terminated.
04-13 18:13:47.145+0900 W/AUL     (26710): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-13 18:13:47.145+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
04-13 18:13:47.155+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-13 18:13:47.165+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-13 18:13:47.165+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-13 18:13:47.165+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 26710
04-13 18:13:47.165+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-13 18:13:47.175+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 4
04-13 18:13:47.175+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-13 18:13:47.175+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-13 18:13:47.175+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-13 18:13:47.175+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-13 18:13:47.185+0900 I/abc     (26392): abc
04-13 18:13:47.185+0900 I/CAPI_APPFW_APPLICATION(26392): app_main.c: ui_app_main(789) > app_efl_main
04-13 18:13:47.185+0900 I/CAPI_APPFW_APPLICATION(26392): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-13 18:13:47.215+0900 E/TBM     (26392): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-13 18:13:47.275+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 26392, appid: org.example.client
04-13 18:13:47.275+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-13 18:13:47.275+0900 W/AUL     (26710): launch.c: app_request_to_launchpad(425) > request cmd(0) result(26392)
04-13 18:13:47.495+0900 I/APP_CORE(26392): appcore-efl.c: __do_app(514) > [APP 26392] Event: RESET State: CREATED
04-13 18:13:47.495+0900 I/CAPI_APPFW_APPLICATION(26392): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-13 18:13:47.505+0900 E/EFL     (26392): edje<26392> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-13 18:13:47.505+0900 E/EFL     (26392): By the power of Grayskull, your previous Embryo stack is now broken!
04-13 18:13:47.515+0900 E/EFL     (26392): edje<26392> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-13 18:13:47.515+0900 E/EFL     (26392): By the power of Grayskull, your previous Embryo stack is now broken!
04-13 18:13:47.515+0900 E/EFL     (26392): edje<26392> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-13 18:13:47.515+0900 E/EFL     (26392): By the power of Grayskull, your previous Embryo stack is now broken!
04-13 18:13:47.526+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:13:47.526+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:13:47.526+0900 W/APP_CORE(26392): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6c00002
04-13 18:13:47.526+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-13 18:13:47.536+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-13 18:13:47.536+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-13 18:13:47.546+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-13 18:13:47.556+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-13 18:13:47.656+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-13 18:13:47.656+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-13 18:13:47.656+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-13 18:13:47.656+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-13 18:13:47.656+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-13 18:13:47.656+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-13 18:13:47.656+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(26392) status(3)
04-13 18:13:47.656+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-13 18:13:47.656+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-13 18:13:47.656+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(26392)
04-13 18:13:47.656+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 26392, appid: org.example.client, status: fg
04-13 18:13:47.666+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-13 18:13:47.666+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-13 18:13:47.666+0900 W/AUL     ( 1437): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1437, appid: live-com.samsung.browser, status: bg
04-13 18:13:47.676+0900 I/APP_CORE(26392): appcore-efl.c: __do_app(514) > [APP 26392] Event: RESUME State: CREATED
04-13 18:13:47.686+0900 I/APP_CORE(26392): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-13 18:13:47.686+0900 I/APP_CORE(26392): appcore-efl.c: __do_app(625) > [APP 26392] Initial Launching, call the resume_cb
04-13 18:13:47.686+0900 I/CAPI_APPFW_APPLICATION(26392): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-13 18:13:47.846+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:13:48.016+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(26392) status(0)
04-13 18:13:48.326+0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-13 18:13:48.326+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 26392.
04-13 18:13:48.326+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1873
04-13 18:13:49.107+0900 I/UXT     (26723): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-13 18:13:52.661+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: MEM_FLUSH State: PAUSED
04-13 18:13:56.064+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:13:56.584+0900 E/EFL     (26392): ecore_x<26392> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=81285031
04-13 18:13:56.584+0900 I/MY_LOG  (26392): Button pressed
04-13 18:13:56.684+0900 E/EFL     (26392): ecore_x<26392> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=81285130
04-13 18:13:56.684+0900 E/VCONF   (26392): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-13 18:13:56.684+0900 E/VCONF   (26392): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-13 18:13:56.684+0900 E/VCONF   (26392): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-13 18:13:56.684+0900 E/VCONF   (26392): vconf.c: vconf_get_bool(2729) > vconf_get_bool(26392) : db/ise/keysound error
04-13 18:13:56.684+0900 E/VCONF   (26392): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-13 18:13:56.684+0900 E/VCONF   (26392): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-13 18:13:56.765+0900 I/MY_LOG  (26392): Button unpressed
04-13 18:14:00.158+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(195) > ""
04-13 18:14:00.158+0900 E/UXT     (  682): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 6:14
04-13 18:14:00.158+0900 I/INDICATOR(  682): clock.c: getTimeFormatted(176) > "time format : 오후 6:14"
04-13 18:14:00.158+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 6:14"
04-13 18:14:00.158+0900 W/INDICATOR(  682): clock.c: indicator_clock_changed_cb(272) > 
04-13 18:14:00.158+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146480136 Time: <font_size=31> </font_size> <font_size=31> 오후 6:14</font_size></font>"
04-13 18:14:16.063+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:14:17.515+0900 E/EFL     (26392): ecore_x<26392> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=81305964
04-13 18:14:17.515+0900 I/MY_LOG  (26392): Button pressed
04-13 18:14:17.595+0900 E/EFL     (26392): ecore_x<26392> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=81306042
04-13 18:14:17.605+0900 I/MY_LOG  (26392): Button unpressed
04-13 18:14:17.655+0900 D/basicui (26392): successed to load edc file
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.616+0900 E/RESOURCED(  684): proc-monitor.c: proc_dbus_watchdog_handler(711) > Receive watchdog signal to pid: 26392(client)
04-13 18:14:28.616+0900 E/RESOURCED(  684): proc-monitor.c: proc_dbus_watchdog_handler(727) > just kill watchdog process when debug enabled pid: 26392(client)
04-13 18:14:28.616+0900 E/RESOURCED(  684): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
04-13 18:14:28.616+0900 E/RESOURCED(  684): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
04-13 18:14:28.616+0900 E/RESOURCED(  684): cgroup.c: place_pid_to_cgroup_by_fullpath(76) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
04-13 18:14:28.786+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 26392 pgid = 26392
04-13 18:14:28.786+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(26392)
04-13 18:14:28.786+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:14:28.816+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(3)
04-13 18:14:28.816+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-13 18:14:28.816+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-13 18:14:28.816+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(868)
04-13 18:14:28.816+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-13 18:14:28.846+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-13 18:14:28.846+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-13 18:14:28.846+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-13 18:14:28.856+0900 I/Tizen::App( 1246): (243) > App[org.example.client] pid[26392] terminate event is forwarded
04-13 18:14:28.856+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-13 18:14:28.856+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [org.example.client, 26392, ]
04-13 18:14:28.856+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-13 18:14:28.856+0900 I/Tizen::App( 1246): (506) > TerminatedApp(org.example.client)
04-13 18:14:28.856+0900 I/Tizen::App( 1246): (512) > Not registered pid(26392)
04-13 18:14:28.856+0900 I/Tizen::System( 1246): (246) > Terminated app [org.example.client]
04-13 18:14:28.856+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-13 18:14:28.856+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 26392
04-13 18:14:28.856+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 26392
04-13 18:14:28.856+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 26392
04-13 18:14:28.856+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1877
04-13 18:14:28.866+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-13 18:14:28.876+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:14:28.876+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-13 18:14:28.876+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-13 18:14:28.876+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-13 18:14:28.876+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-13 18:14:28.876+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for org.example.client, 26392.
04-13 18:14:28.916+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [org.exampl] 
04-13 18:14:28.916+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-13 18:14:28.926+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-13 18:14:28.926+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-13 18:14:28.926+0900 W/AUL     ( 1437): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1437, appid: live-com.samsung.browser, status: fg
04-13 18:14:28.936+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-13 18:14:28.956+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:28.956+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:28.986+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-13 18:14:28.986+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-13 18:14:28.996+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-13 18:14:28.996+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-13 18:14:28.996+0900 W/CRASH_MANAGER(26736): worker.c: worker_job(1199) > 0626392636c691492074868
04-13 18:14:28.996+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-13 18:14:29.937+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:29.937+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:29.957+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:29.957+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:29.977+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:29.977+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:29.997+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:29.997+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:30.007+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:30.017+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:30.027+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:30.027+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:30.047+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:30.047+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:30.067+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:30.067+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:30.087+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:30.087+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:30.107+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:30.107+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:30.117+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:30.127+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:30.137+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:30.137+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:36.063+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:14:38.615+0900 E/RESOURCED(  684): procfs.c: proc_get_oom_score_adj(131) > fopen /proc/26392/oom_score_adj failed
04-13 18:14:56.082+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:15:00.176+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(195) > ""
04-13 18:15:00.176+0900 E/UXT     (  682): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 6:15
04-13 18:15:00.176+0900 I/INDICATOR(  682): clock.c: getTimeFormatted(176) > "time format : 오후 6:15"
04-13 18:15:00.176+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 6:15"
04-13 18:15:00.176+0900 W/INDICATOR(  682): clock.c: indicator_clock_changed_cb(272) > 
04-13 18:15:00.176+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146428786 Time: <font_size=31> </font_size> <font_size=31> 오후 6:15</font_size></font>"
04-13 18:15:16.062+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:15:36.071+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:15:56.071+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:16:00.215+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(195) > ""
04-13 18:16:00.215+0900 E/UXT     (  682): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 6:16
04-13 18:16:00.215+0900 I/INDICATOR(  682): clock.c: getTimeFormatted(176) > "time format : 오후 6:16"
04-13 18:16:00.215+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 6:16"
04-13 18:16:00.215+0900 W/INDICATOR(  682): clock.c: indicator_clock_changed_cb(272) > 
04-13 18:16:00.215+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146439534 Time: <font_size=31> </font_size> <font_size=31> 오후 6:16</font_size></font>"
04-13 18:16:16.060+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:16:22.196+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=81430639
04-13 18:16:22.276+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=81430727
04-13 18:16:22.296+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-13 18:16:22.296+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
04-13 18:16:22.296+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 868
04-13 18:16:22.307+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 4
04-13 18:16:22.307+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-13 18:16:22.307+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-13 18:16:22.307+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-13 18:16:22.307+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-13 18:16:22.327+0900 I/abc     (26723): abc
04-13 18:16:22.327+0900 I/CAPI_APPFW_APPLICATION(26723): app_main.c: ui_app_main(789) > app_efl_main
04-13 18:16:22.327+0900 I/CAPI_APPFW_APPLICATION(26723): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-13 18:16:22.347+0900 E/TBM     (26723): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-13 18:16:22.407+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 26723, appid: org.example.client
04-13 18:16:22.407+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-13 18:16:22.407+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(425) > request cmd(1) result(26723)
04-13 18:16:22.627+0900 I/APP_CORE(26723): appcore-efl.c: __do_app(514) > [APP 26723] Event: RESET State: CREATED
04-13 18:16:22.627+0900 I/CAPI_APPFW_APPLICATION(26723): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-13 18:16:22.637+0900 E/EFL     (26723): edje<26723> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-13 18:16:22.637+0900 E/EFL     (26723): By the power of Grayskull, your previous Embryo stack is now broken!
04-13 18:16:22.647+0900 E/EFL     (26723): edje<26723> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-13 18:16:22.647+0900 E/EFL     (26723): By the power of Grayskull, your previous Embryo stack is now broken!
04-13 18:16:22.657+0900 E/EFL     (26723): edje<26723> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-13 18:16:22.657+0900 E/EFL     (26723): By the power of Grayskull, your previous Embryo stack is now broken!
04-13 18:16:22.657+0900 W/APP_CORE(26723): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
04-13 18:16:22.667+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-13 18:16:22.667+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:16:22.667+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:16:22.687+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-13 18:16:22.687+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-13 18:16:22.687+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-13 18:16:22.697+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-13 18:16:22.757+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-13 18:16:22.757+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-13 18:16:22.757+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-13 18:16:22.767+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-13 18:16:22.767+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-13 18:16:22.767+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-13 18:16:22.767+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(26723) status(3)
04-13 18:16:22.777+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(26723)
04-13 18:16:22.777+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 26723, appid: org.example.client, status: fg
04-13 18:16:22.777+0900 I/APP_CORE(26723): appcore-efl.c: __do_app(514) > [APP 26723] Event: RESUME State: CREATED
04-13 18:16:22.777+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-13 18:16:22.777+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-13 18:16:22.777+0900 W/AUL     ( 1437): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1437, appid: live-com.samsung.browser, status: bg
04-13 18:16:22.787+0900 I/APP_CORE(26723): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-13 18:16:22.787+0900 I/APP_CORE(26723): appcore-efl.c: __do_app(625) > [APP 26723] Initial Launching, call the resume_cb
04-13 18:16:22.787+0900 I/CAPI_APPFW_APPLICATION(26723): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-13 18:16:22.937+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:16:23.137+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(26723) status(0)
04-13 18:16:23.458+0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-13 18:16:23.458+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 26723.
04-13 18:16:23.458+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1879
04-13 18:16:23.728+0900 E/EFL     (26723): ecore_x<26723> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=81432173
04-13 18:16:23.818+0900 E/EFL     (26723): ecore_x<26723> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=81432261
04-13 18:16:24.268+0900 I/UXT     (26809): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-13 18:16:24.429+0900 E/EFL     (26723): ecore_x<26723> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=81432869
04-13 18:16:24.429+0900 I/MY_LOG  (26723): Button pressed
04-13 18:16:24.509+0900 E/EFL     (26723): ecore_x<26723> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=81432957
04-13 18:16:24.509+0900 E/VCONF   (26723): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-13 18:16:24.509+0900 E/VCONF   (26723): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-13 18:16:24.509+0900 E/VCONF   (26723): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-13 18:16:24.509+0900 E/VCONF   (26723): vconf.c: vconf_get_bool(2729) > vconf_get_bool(26723) : db/ise/keysound error
04-13 18:16:24.509+0900 E/VCONF   (26723): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-13 18:16:24.509+0900 E/VCONF   (26723): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-13 18:16:24.559+0900 I/MY_LOG  (26723): Button unpressed
04-13 18:16:25.299+0900 E/EFL     (26723): ecore_x<26723> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=81433746
04-13 18:16:25.299+0900 I/MY_LOG  (26723): Button pressed
04-13 18:16:25.359+0900 E/EFL     (26723): ecore_x<26723> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=81433812
04-13 18:16:25.369+0900 I/MY_LOG  (26723): Button unpressed
04-13 18:16:25.410+0900 D/basicui (26723): successed to load edc file
04-13 18:16:25.570+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:16:25.580+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 26723 pgid = 26723
04-13 18:16:25.580+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(26723)
04-13 18:16:25.590+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(3)
04-13 18:16:25.590+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-13 18:16:25.590+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-13 18:16:25.590+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(868)
04-13 18:16:25.590+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-13 18:16:25.630+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-13 18:16:25.630+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-13 18:16:25.630+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-13 18:16:25.630+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-13 18:16:25.630+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 26723
04-13 18:16:25.630+0900 I/Tizen::App( 1246): (243) > App[org.example.client] pid[26723] terminate event is forwarded
04-13 18:16:25.630+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-13 18:16:25.630+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [org.example.client, 26723, ]
04-13 18:16:25.630+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-13 18:16:25.630+0900 I/Tizen::App( 1246): (506) > TerminatedApp(org.example.client)
04-13 18:16:25.630+0900 I/Tizen::App( 1246): (512) > Not registered pid(26723)
04-13 18:16:25.630+0900 I/Tizen::System( 1246): (246) > Terminated app [org.example.client]
04-13 18:16:25.630+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-13 18:16:25.630+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 26723
04-13 18:16:25.630+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 26723
04-13 18:16:25.650+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-13 18:16:25.650+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for org.example.client, 26723.
04-13 18:16:25.670+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-13 18:16:25.670+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-13 18:16:25.670+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-13 18:16:25.670+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:16:25.690+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-13 18:16:25.690+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-13 18:16:25.690+0900 W/AUL     ( 1437): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1437, appid: live-com.samsung.browser, status: fg
04-13 18:16:25.700+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:16:25.700+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:16:25.700+0900 W/CRASH_MANAGER(26815): worker.c: worker_job(1199) > 0626723636c69149207498
