S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 14374
Date: 2017-06-13 13:51:01+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 14374, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00003826
r2   = 0x00000006, r3   = 0xb413a4c0
r4   = 0x00000002, r5   = 0xb413a000
r6   = 0xb683409c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb8326840
r10  = 0xbeafa498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbeafa004
lr   = 0xb672af18, pc   = 0xb6729b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     70308 KB
Buffers:     59936 KB
Cached:     228036 KB
VmPeak:      98736 KB
VmSize:      98732 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19640 KB
VmRSS:       19640 KB
VmData:      30212 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35776 KB
VmPTE:          74 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 14374 TID = 14374
14374 14377 14467 14468 

Maps Information
b13f2000 b13fa000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b140c000 b1c0b000 rw-p [stack:14468]
b1c0b000 b1c0c000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c1c000 b1c30000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c44000 b1c45000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c55000 b1c58000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c69000 b1c6a000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c7a000 b1c7c000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c8c000 b1c8e000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c9e000 b1cae000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1cbe000 b1cca000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cdc000 b24db000 rw-p [stack:14467]
b280c000 b2813000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2826000 b282c000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b283c000 b286d000 r-xp /opt/usr/apps/org.example.client/bin/client
b29c6000 b2aa9000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ae0000 b2b08000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b1a000 b3319000 rw-p [stack:14377]
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
b82ae000 b84f3000 rw-p [heap]
beada000 beafb000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14374)
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
47) >  Main Scroll Completed
06-13 13:50:55.596+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 13:50:55.596+0900 W/CAPI_APPFW_APP_CONTROL( 1167): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-13 13:50:55.606+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(564) > Legacy lifecycle: 0
06-13 13:50:55.606+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(566) > [APP 1167] App already running, raise the window
06-13 13:50:55.616+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 13:50:55.616+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:50:55.616+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 13:50:55.616+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 13:50:55.616+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 13:50:55.676+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:50:55.676+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:50:55.676+0900 E/EFL     (  860): eo<860> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:164: func 'edje_obj_part_geometry_get' (762) could not be resolved for class 'Elm_Layout'.
06-13 13:50:55.686+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 13:50:55.696+0900 I/APP_CORE(14360): appcore-efl.c: __do_app(514) > [APP 14360] Event: PAUSE State: RUNNING
06-13 13:50:55.696+0900 I/CAPI_APPFW_APPLICATION(14360): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 13:50:55.706+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(14360) status(4)
06-13 13:50:55.706+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.myfile-lite(14360)
06-13 13:50:55.706+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 14360, appid: com.samsung.myfile-lite, status: bg
06-13 13:50:55.716+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 13:50:55.716+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 13:50:55.716+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 13:50:55.716+0900 I/TIZEN_N_EFL_UTIL_WINDOW(14360): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 15
06-13 13:50:55.716+0900 E/APP_CORE(14360): appcore-efl.c: _capture_and_make_file(1619) > win[6000003] widget[720] height[1280]
06-13 13:50:55.716+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
06-13 13:50:55.716+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 13:50:55.716+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 13:50:55.736+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 13:50:55.746+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 13:50:55.746+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 13:50:55.746+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:50:55.746+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:50:55.746+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:50:55.756+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 13:50:55.756+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:50:55.756+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 13:50:55.756+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 13:50:55.756+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 13:50:55.756+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 13:50:55.766+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 13:50:55.866+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 13:50:55.876+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 13:50:55.876+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16441973
06-13 13:50:55.876+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16442076
06-13 13:50:55.876+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 13:50:55.876+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 13:50:56.567+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16442770
06-13 13:50:56.597+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 13:50:56.597+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 13:50:56.617+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 13:50:56.617+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 13:50:56.617+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 13:50:56.617+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 13:50:56.657+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16442858
06-13 13:50:57.087+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16443290
06-13 13:50:57.187+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16443389
06-13 13:50:57.447+0900 W/cluster-view( 1167): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
06-13 13:50:57.768+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16443982
06-13 13:50:57.768+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 13:50:57.768+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16443982
06-13 13:50:57.768+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 13:50:57.768+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 13:50:57.788+0900 W/MEDIA_THUMBNAIL_SERVER(14429): thumb-server-internal.c: _thumb_server_read_socket(514) > [32mreceived KILL msg from thumbnail agent.
06-13 13:50:57.788+0900 W/MEDIA_THUMBNAIL_SERVER(14429): thumb-server-internal.c: _thumb_server_read_socket(575) > [32mShutting down...
06-13 13:50:57.788+0900 E/MEDIA_THUMBNAIL_DCM(14429): thumb-server-dcm.c: _thumb_server_dcm_quit_main_loop(445) > [31mInvalid DCM thread main loop![0m
06-13 13:50:57.968+0900 E/MEDIA_SERVER(  895): media-server-main.c: _ms_signal_handler(183) > [14429] Thumbnail server is stopped by media-server
06-13 13:50:57.968+0900 E/MEDIA_SERVER_THUMB(  895): media-server-thumb.c: ms_thumb_reset_server_status(162) > [no-err] g_thumb_server_extracting = 0 -> FALSE
06-13 13:50:58.068+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 13:50:58.078+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 13:50:58.078+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 13:50:58.078+0900 E/STARTER (  721): )
06-13 13:50:58.078+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 13:50:58.078+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 13:50:58.078+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 13:50:58.098+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
06-13 13:50:58.098+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 13:50:58.108+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 13:50:58.108+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 13:50:58.108+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 13:50:58.108+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 13:50:58.118+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:50:58.128+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:50:58.128+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 13:50:58.128+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:50:58.138+0900 E/CAPI_APPFW_APPLICATION(14394): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:50:58.138+0900 E/CAPI_APPFW_APPLICATION(14394): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:50:58.138+0900 E/CAPI_APPFW_APPLICATION(14394): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:50:58.138+0900 E/CAPI_APPFW_APPLICATION(14394): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:50:58.138+0900 E/CAPI_APPFW_APPLICATION(14394): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 13:50:58.138+0900 I/CAPI_APPFW_APPLICATION(14394): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:50:58.148+0900 I/CAPI_APPFW_APPLICATION(14394): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:50:58.218+0900 W/TASK_MGR_LITE(14394): task-mgr-lite.c: create_win(197) > changeable ui enabled success
06-13 13:50:58.218+0900 I/GXT_SIB (14394): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 13:50:58.228+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 14394, appid: com.samsung.task-mgr
06-13 13:50:58.228+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:50:58.228+0900 E/RESOURCED(  667): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-13 13:50:58.248+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(14394)
06-13 13:50:58.268+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:50:58.268+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:50:58.298+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 13:50:58.298+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 13:50:58.308+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 13:50:58.308+0900 E/RUA     (14394): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 25, ncols : 5
06-13 13:50:58.308+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 13:50:58.308+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 13:50:58.308+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:50:58.308+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 14360
06-13 13:50:58.308+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 13:50:58.318+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 13:50:58.328+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:50:58.328+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 14311
06-13 13:50:58.328+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 13:50:58.328+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 13:50:58.388+0900 I/APP_CORE(14394): appcore-efl.c: __do_app(514) > [APP 14394] Event: RESET State: CREATED
06-13 13:50:58.388+0900 I/CAPI_APPFW_APPLICATION(14394): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 13:50:58.388+0900 E/EFL     (14394): edje<14394> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:50:58.388+0900 E/EFL     (14394): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:50:58.388+0900 E/EFL     (14394): edje<14394> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:50:58.388+0900 E/EFL     (14394): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:50:58.388+0900 W/APP_CORE(14394): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800003
06-13 13:50:58.388+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
06-13 13:50:58.579+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: PAUSE State: RUNNING
06-13 13:50:58.579+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 13:50:58.579+0900 E/cluster-home( 1167): homescreen.cpp: OnPause(260) >  app pause
06-13 13:50:58.579+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(4)
06-13 13:50:58.579+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(1167)
06-13 13:50:58.579+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: bg
06-13 13:50:58.589+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(14394) status(3)
06-13 13:50:58.589+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:50:58.589+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 13:50:58.589+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(14394)
06-13 13:50:58.589+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 14394, appid: com.samsung.task-mgr, status: fg
06-13 13:50:58.589+0900 I/APP_CORE(14394): appcore-efl.c: __do_app(514) > [APP 14394] Event: RESUME State: CREATED
06-13 13:50:58.609+0900 I/APP_CORE(14394): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-13 13:50:58.609+0900 I/APP_CORE(14394): appcore-efl.c: __do_app(625) > [APP 14394] Initial Launching, call the resume_cb
06-13 13:50:58.609+0900 I/CAPI_APPFW_APPLICATION(14394): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 13:50:58.939+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(14394) status(0)
06-13 13:50:58.959+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 13:50:58.959+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16445173
06-13 13:50:58.959+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16445173
06-13 13:50:58.959+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 13:50:58.969+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 13:50:58.969+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 13:50:58.969+0900 E/STARTER (  721): )
06-13 13:50:58.969+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 13:50:58.969+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 13:50:58.969+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 13:50:58.969+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 13:50:59.279+0900 E/EFL     (14394): ecore_x<14394> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16445489
06-13 13:50:59.279+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1486
06-13 13:50:59.319+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 13:50:59.319+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 14394.
06-13 13:50:59.379+0900 E/EFL     (14394): ecore_x<14394> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16445577
06-13 13:50:59.720+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:50:59.720+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:50:59.720+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(14394)
06-13 13:50:59.720+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 14394, appid: com.samsung.task-mgr, status: bg
06-13 13:50:59.720+0900 I/CAPI_APPFW_APPLICATION(14394): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 13:50:59.720+0900 W/TASK_MGR_LITE(14394): task-mgr-lite.c: _pause_app(406) > 
06-13 13:50:59.720+0900 I/CAPI_APPFW_APPLICATION(14394): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 13:50:59.720+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:50:59.720+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 14360
06-13 13:50:59.720+0900 W/AUL     (14394): launch.c: app_request_to_launchpad(396) > request cmd(4) to(14360)
06-13 13:50:59.720+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 4
06-13 13:50:59.720+0900 I/APP_CORE(14360): appcore-efl.c: __do_app(514) > [APP 14360] Event: TERMINATE State: PAUSED
06-13 13:50:59.720+0900 W/AUL_AMD (  607): amd_launch.c: __reply_handler(1083) > listen fd(32) , send fd(31), pid(14360), cmd(4)
06-13 13:50:59.720+0900 W/AUL     (14394): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
06-13 13:50:59.730+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:50:59.730+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:50:59.730+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:50:59.730+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:50:59.740+0900 I/TIZEN_N_EFL_UTIL_WINDOW(14360): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 11
06-13 13:50:59.740+0900 E/APP_CORE(14360): appcore-efl.c: _capture_and_make_file(1619) > win[6000003] widget[720] height[1280]
06-13 13:50:59.740+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
06-13 13:50:59.740+0900 E/APP_CORE(14360): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [com.samsung.myfile-lite]
06-13 13:50:59.740+0900 I/CAPI_APPFW_APPLICATION(14360): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 13:50:59.740+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:50:59.740+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 14311
06-13 13:50:59.740+0900 W/AUL     (14394): launch.c: app_request_to_launchpad(396) > request cmd(4) to(14311)
06-13 13:50:59.740+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 4
06-13 13:50:59.740+0900 I/CAPI_CONTENT_MEDIA_CONTENT(14360): media_content.c: media_content_disconnect(940) > [32m[14360]ref count changed to: 0
06-13 13:50:59.750+0900 I/APP_CORE(14311): appcore-efl.c: __do_app(514) > [APP 14311] Event: TERMINATE State: PAUSED
06-13 13:50:59.760+0900 E/CLOUD_CONTENT_SYNC_CLIENT(14360): cs_client.c: cloud_content_sync_folder_unset_changed_cb(3749) > [0;31m* Critical * Invalid handle[0;m
06-13 13:50:59.760+0900 E/CLOUD_CONTENT_SYNC_CLIENT(14360): cs_client.c: cloud_content_sync_content_unset_changed_cb(3662) > [0;31m* Critical * Invalid handle[0;m
06-13 13:50:59.760+0900 W/MYFILES (14360): mf-cloud-service.c: mf_cloud_content_destroy_handle(61) > handle is NULL
06-13 13:50:59.760+0900 E/MYFILES (14360): mf-cloud-operation.c: mf_cloud_operation_src_list_free(147) > [31mmore is [0][0m
06-13 13:50:59.760+0900 E/EFL     (14360): <14360> e_dbus.c:640 e_dbus_shutdown() Init count not greater than 0 in shutdown.
06-13 13:50:59.760+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:50:59.760+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:50:59.760+0900 W/AUL_AMD (  607): amd_launch.c: __reply_handler(1083) > listen fd(32) , send fd(31), pid(14311), cmd(4)
06-13 13:50:59.760+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:50:59.760+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:50:59.760+0900 W/AUL     (14394): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
06-13 13:50:59.770+0900 I/TIZEN_N_EFL_UTIL_WINDOW(14311): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 16
06-13 13:50:59.770+0900 E/APP_CORE(14311): appcore-efl.c: _capture_and_make_file(1619) > win[3200003] widget[720] height[1280]
06-13 13:50:59.770+0900 E/TASK_MGR_LITE(14394): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 13:50:59.770+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
06-13 13:50:59.770+0900 E/APP_CORE(14311): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [com.samsung.setting]
06-13 13:50:59.770+0900 I/CAPI_APPFW_APPLICATION(14311): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 13:50:59.790+0900 E/TASK_MGR_LITE(14394): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
06-13 13:50:59.790+0900 E/APP_CORE(14394): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 13:50:59.800+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:50:59.800+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 13:50:59.810+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:50:59.810+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 13:50:59.810+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 13:50:59.810+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 13:50:59.850+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 13:50:59.880+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:50:59.890+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 13:50:59.890+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 13:50:59.890+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 13:50:59.920+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 13:50:59.930+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: MEM_FLUSH State: PAUSED
06-13 13:50:59.940+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 13:50:59.940+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 13:50:59.940+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:50:59.940+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:50:59.940+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:50:59.940+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 13:50:59.950+0900 I/MALI    (14394): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=14394   close drm_fd=30 
06-13 13:50:59.960+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=16446079
06-13 13:50:59.960+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=16446139
06-13 13:50:59.960+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 13:50:59.960+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 13:50:59.960+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 13:50:59.960+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 13:50:59.960+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 13:50:59.960+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 13:50:59.980+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 13:50:59.990+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:50:59.990+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 13:50:59.990+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 13:50:59.990+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 13:50:59.990+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 13:51:00.000+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 13:51:00.000+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 13:51:00.000+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 13:51:00.000+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 13:51:00.030+0900 I/MALI    (14360): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=14360   close drm_fd=30 
06-13 13:51:00.090+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 13:51:00.090+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 13:51:00.100+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 13:51:00.120+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-13 13:51:00.120+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 13:51:00.130+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 13:51:00.170+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 13:51:00.170+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 13:51:00.170+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:00.170+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:00.170+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:00.180+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 13:51:00.190+0900 I/MALI    (14311): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=14311   close drm_fd=30 
06-13 13:51:00.200+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:51:00.200+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 13:51:00.200+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 13:51:00.200+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 13:51:00.200+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 13:51:00.290+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 13:51:00.300+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 13:51:00.390+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14394 pgid = 14394
06-13 13:51:00.390+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(14394)
06-13 13:51:00.420+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:51:00.420+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:51:00.420+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:51:00.440+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 14394
06-13 13:51:00.440+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[14394] terminate event is forwarded
06-13 13:51:00.440+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14394
06-13 13:51:00.440+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 13:51:00.440+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 14394
06-13 13:51:00.440+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 14394, ]
06-13 13:51:00.440+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 13:51:00.440+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 13:51:00.440+0900 I/Tizen::App( 1175): (512) > Not registered pid(14394)
06-13 13:51:00.440+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 13:51:00.440+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 13:51:00.440+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1488
06-13 13:51:00.450+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 13:51:00.450+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 14394.
06-13 13:51:00.480+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14360 pgid = 14360
06-13 13:51:00.480+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(14360)
06-13 13:51:00.510+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:51:00.510+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:51:00.510+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:51:00.510+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 14360
06-13 13:51:00.510+0900 I/Tizen::App( 1175): (243) > App[com.samsung.myfile-lite] pid[14360] terminate event is forwarded
06-13 13:51:00.510+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 13:51:00.510+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.myfile-lite, 14360, ]
06-13 13:51:00.510+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 13:51:00.510+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.myfile-lite)
06-13 13:51:00.510+0900 I/Tizen::App( 1175): (512) > Not registered pid(14360)
06-13 13:51:00.510+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.myfile-lite]
06-13 13:51:00.520+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 13:51:00.520+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14360
06-13 13:51:00.520+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1490
06-13 13:51:00.520+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16446737
06-13 13:51:00.530+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 13:51:00.530+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.myfile-lite, 14360.
06-13 13:51:00.530+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(195) > ""
06-13 13:51:00.550+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 13:51:00.550+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 13:51:00.560+0900 E/UXT     (  665): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 1:51
06-13 13:51:00.560+0900 I/INDICATOR(  665): clock.c: getTimeFormatted(176) > "time format : 오후 1:51"
06-13 13:51:00.560+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 1:51"
06-13 13:51:00.560+0900 W/INDICATOR(  665): clock.c: indicator_clock_changed_cb(272) > 
06-13 13:51:00.560+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147131579 Time: <font_size=31> </font_size> <font_size=31> 오후 1:51</font_size></font>"
06-13 13:51:00.570+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 13:51:00.580+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 13:51:00.580+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 13:51:00.580+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 13:51:00.580+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16446791
06-13 13:51:00.600+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14311 pgid = 14311
06-13 13:51:00.600+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(14311)
06-13 13:51:00.631+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 13:51:00.631+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 13:51:00.631+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 13:51:00.631+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 14311
06-13 13:51:00.631+0900 I/Tizen::App( 1175): (243) > App[com.samsung.setting] pid[14311] terminate event is forwarded
06-13 13:51:00.631+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 13:51:00.631+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.setting, 14311, ]
06-13 13:51:00.631+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 13:51:00.631+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.setting)
06-13 13:51:00.631+0900 I/Tizen::App( 1175): (512) > Not registered pid(14311)
06-13 13:51:00.631+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.setting]
06-13 13:51:00.631+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 13:51:00.631+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14311
06-13 13:51:00.651+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 13:51:00.651+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.setting, 14311.
06-13 13:51:00.681+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1491
06-13 13:51:00.891+0900 I/UXT     (14448): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 13:51:00.891+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16447101
06-13 13:51:00.951+0900 E/TBM     (14448): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:51:00.951+0900 I/MALI    (14448): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=14448   open drm_fd=30 
06-13 13:51:00.961+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16447178
06-13 13:51:01.091+0900 E/EFL     (14448): edje<14448> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:51:01.091+0900 E/EFL     (14448): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:51:01.091+0900 E/EFL     (14448): edje<14448> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:51:01.091+0900 E/EFL     (14448): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:51:01.091+0900 E/EFL     (14448): edje<14448> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 13:51:01.091+0900 E/EFL     (14448): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 13:51:01.231+0900 W/cluster-view( 1167): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
06-13 13:51:01.351+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16447564
06-13 13:51:01.441+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16447652
06-13 13:51:01.441+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
06-13 13:51:01.451+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
06-13 13:51:01.451+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 1167
06-13 13:51:01.461+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 13:51:01.461+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:51:01.461+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:51:01.461+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 13:51:01.461+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:51:01.471+0900 I/abc     (14374): abc
06-13 13:51:01.471+0900 I/CAPI_APPFW_APPLICATION(14374): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:51:01.481+0900 I/CAPI_APPFW_APPLICATION(14374): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:51:01.501+0900 E/TBM     (14374): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:51:01.561+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 14374, appid: org.example.client
06-13 13:51:01.561+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:51:01.561+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(425) > request cmd(1) result(14374)
06-13 13:51:01.812+0900 W/CRASH_MANAGER(14476): worker.c: worker_job(1199) > 0614374636c69149732946
