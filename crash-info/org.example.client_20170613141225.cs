S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 19587
Date: 2017-06-13 14:12:25+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 19587, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00004c83
r2   = 0x00000006, r3   = 0xb407e4c0
r4   = 0x00000002, r5   = 0xb407e000
r6   = 0xb677809c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb7797b18
r10  = 0xbef3b498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbef3b0dc
lr   = 0xb666ef18, pc   = 0xb666db84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     46196 KB
Buffers:     65476 KB
Cached:     240232 KB
VmPeak:      90468 KB
VmSize:      90464 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19620 KB
VmRSS:       19620 KB
VmData:      22012 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35772 KB
VmPTE:          70 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 19587 TID = 19587
19587 19595 19605 

Maps Information
b1b47000 b1b4f000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b60000 b1b61000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b71000 b1b85000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b99000 b1b9a000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1baa000 b1bad000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bbe000 b1bbf000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bcf000 b1bd1000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1be1000 b1be3000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bf3000 b1c03000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c13000 b1c1f000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c31000 b2430000 rw-p [stack:19605]
b2761000 b2768000 r-xp /usr/lib/libefl-extension.so.0.1.0
b277b000 b2781000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2791000 b27c1000 r-xp /opt/usr/apps/org.example.client/bin/client
b290a000 b29ed000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a24000 b2a4c000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a5e000 b325d000 rw-p [stack:19595]
b325d000 b325f000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b326f000 b3279000 r-xp /lib/libnss_files-2.20-2014.11.so
b328a000 b3293000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32a4000 b32b5000 r-xp /lib/libnsl-2.20-2014.11.so
b32c8000 b32ce000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32df000 b32e0000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3308000 b330f000 r-xp /usr/lib/libminizip.so.1.0.0
b331f000 b3324000 r-xp /usr/lib/libstorage.so.0.1
b3334000 b3393000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33a9000 b33bd000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33cd000 b3411000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3421000 b3429000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3439000 b3469000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b347c000 b3535000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3549000 b359c000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35ad000 b35c8000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35d8000 b3699000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36ac000 b36bc000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36cc000 b36d9000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36ea000 b36f1000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3701000 b3742000 r-xp /usr/lib/libmdm.so.1.2.12
b3752000 b375a000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3769000 b3779000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b379a000 b37fa000 r-xp /usr/lib/libasound.so.2.0.0
b380c000 b380f000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b381f000 b3822000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3832000 b3837000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3847000 b3848000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3858000 b3863000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3877000 b387e000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b388e000 b3894000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38a4000 b38a9000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38b9000 b38d4000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38e4000 b38eb000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38fb000 b38fe000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b390f000 b393d000 r-xp /usr/lib/libidn.so.11.5.44
b394d000 b3963000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3974000 b397e000 r-xp /usr/lib/libcares.so.2.1.0
b398e000 b3998000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39a8000 b39aa000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39ba000 b39bb000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39cb000 b39cf000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39e0000 b3a08000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a19000 b3a42000 r-xp /usr/lib/libturbojpeg.so
b3a62000 b3a68000 r-xp /usr/lib/libgif.so.4.1.6
b3a78000 b3abe000 r-xp /usr/lib/libcurl.so.4.3.0
b3acf000 b3af0000 r-xp /usr/lib/libexif.so.12.3.3
b3b0b000 b3b20000 r-xp /usr/lib/libtts.so
b3b31000 b3b39000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b49000 b3c0f000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c2f000 b3d27000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d46000 b3e14000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e2b000 b3e2d000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e3d000 b3e43000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e53000 b3e76000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e87000 b3e89000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e99000 b3e9b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3eac000 b3eb1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ec8000 b3eca000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3eda000 b3ee1000 r-xp /usr/lib/libsensord-share.so
b3ef1000 b3f09000 r-xp /usr/lib/libsensor.so.1.1.0
b3f1a000 b3f1d000 r-xp /usr/lib/libXv.so.1.0.0
b3f2d000 b3f32000 r-xp /usr/lib/libutilX.so.1.1.0
b3f42000 b3f47000 r-xp /usr/lib/libappcore-common.so.1.1
b3f57000 b3f5e000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f71000 b3f75000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f86000 b4064000 r-xp /usr/lib/libCOREGL.so.4.0
b4084000 b4087000 r-xp /usr/lib/libuuid.so.1.3.0
b4097000 b40ae000 r-xp /usr/lib/libblkid.so.1.1.0
b40bf000 b40c1000 r-xp /usr/lib/libXau.so.6.0.0
b40d1000 b4118000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b412a000 b4130000 r-xp /usr/lib/libjson-c.so.2.0.1
b4141000 b4145000 r-xp /usr/lib/libogg.so.0.7.1
b4155000 b4177000 r-xp /usr/lib/libvorbis.so.0.4.3
b4187000 b426b000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4287000 b428a000 r-xp /usr/lib/libEGL.so.1.4
b429b000 b42a1000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42b1000 b42b3000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42c3000 b42d0000 r-xp /usr/lib/libGLESv2.so.2.0
b42e1000 b4343000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4358000 b4370000 r-xp /usr/lib/libmount.so.1.1.0
b4382000 b4396000 r-xp /usr/lib/libxcb.so.1.1.0
b43a6000 b43ad000 r-xp /lib/libcrypt-2.20-2014.11.so
b43e5000 b43e7000 r-xp /usr/lib/libiri.so
b43f7000 b4402000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4413000 b4449000 r-xp /usr/lib/libpulse.so.0.16.2
b445a000 b449d000 r-xp /usr/lib/libsndfile.so.1.0.25
b44b2000 b44c7000 r-xp /lib/libexpat.so.1.5.2
b44d9000 b4597000 r-xp /usr/lib/libcairo.so.2.11200.14
b45ab000 b45b3000 r-xp /usr/lib/libdrm.so.2.4.0
b45c3000 b45c6000 r-xp /usr/lib/libdri2.so.0.0.0
b45d6000 b4624000 r-xp /usr/lib/libssl.so.1.0.0
b4639000 b4645000 r-xp /usr/lib/libeeze.so.1.13.0
b4656000 b465f000 r-xp /usr/lib/libethumb.so.1.13.0
b466f000 b4672000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4682000 b4839000 r-xp /usr/lib/libcrypto.so.1.0.0
b5624000 b562d000 r-xp /usr/lib/libXi.so.6.1.0
b563d000 b563f000 r-xp /usr/lib/libXgesture.so.7.0.0
b564f000 b5653000 r-xp /usr/lib/libXtst.so.6.1.0
b5663000 b5669000 r-xp /usr/lib/libXrender.so.1.3.0
b5679000 b567f000 r-xp /usr/lib/libXrandr.so.2.2.0
b568f000 b5691000 r-xp /usr/lib/libXinerama.so.1.0.0
b56a2000 b56a5000 r-xp /usr/lib/libXfixes.so.3.1.0
b56b5000 b56c0000 r-xp /usr/lib/libXext.so.6.4.0
b56d0000 b56d2000 r-xp /usr/lib/libXdamage.so.1.1.0
b56e2000 b56e4000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56f4000 b57d6000 r-xp /usr/lib/libX11.so.6.3.0
b57ea000 b57f1000 r-xp /usr/lib/libXcursor.so.1.0.2
b5801000 b5819000 r-xp /usr/lib/libudev.so.1.6.0
b581b000 b581e000 r-xp /lib/libattr.so.1.1.0
b582e000 b584e000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b584f000 b5854000 r-xp /usr/lib/libffi.so.6.0.2
b5865000 b587d000 r-xp /lib/libz.so.1.2.8
b588d000 b588f000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b589f000 b5974000 r-xp /usr/lib/libxml2.so.2.9.2
b5989000 b5a24000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a40000 b5a43000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a53000 b5a6c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a7d000 b5a8e000 r-xp /lib/libresolv-2.20-2014.11.so
b5aa2000 b5b1c000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b31000 b5b33000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b43000 b5b4a000 r-xp /usr/lib/libembryo.so.1.13.0
b5b5a000 b5b64000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b75000 b5b8d000 r-xp /usr/lib/libpng12.so.0.50.0
b5b9e000 b5bc1000 r-xp /usr/lib/libjpeg.so.8.0.2
b5be2000 b5bf6000 r-xp /usr/lib/libector.so.1.13.0
b5c07000 b5c1f000 r-xp /usr/lib/liblua-5.1.so
b5c30000 b5c87000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c9b000 b5cc3000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cd4000 b5ce7000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cf8000 b5d32000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d43000 b5d51000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d61000 b5d69000 r-xp /usr/lib/libtbm.so.1.0.0
b5d79000 b5d86000 r-xp /usr/lib/libeio.so.1.13.0
b5d96000 b5d98000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5da8000 b5dad000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dbd000 b5dd4000 r-xp /usr/lib/libefreet.so.1.13.0
b5de6000 b5e06000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e16000 b5e36000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e38000 b5e3e000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e4e000 b5e5f000 r-xp /usr/lib/libemotion.so.1.13.0
b5e70000 b5e77000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e87000 b5e96000 r-xp /usr/lib/libeo.so.1.13.0
b5ea7000 b5eb9000 r-xp /usr/lib/libecore_input.so.1.13.0
b5eca000 b5ecf000 r-xp /usr/lib/libecore_file.so.1.13.0
b5edf000 b5ef8000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f08000 b5f25000 r-xp /usr/lib/libeet.so.1.13.0
b5f3e000 b5f86000 r-xp /usr/lib/libeina.so.1.13.0
b5f97000 b5fa7000 r-xp /usr/lib/libefl.so.1.13.0
b5fb8000 b609d000 r-xp /usr/lib/libicuuc.so.51.1
b60ba000 b61fa000 r-xp /usr/lib/libicui18n.so.51.1
b6211000 b6249000 r-xp /usr/lib/libecore_x.so.1.13.0
b625b000 b625e000 r-xp /lib/libcap.so.2.21
b626e000 b6297000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62a8000 b62af000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62c1000 b62f8000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6309000 b63f4000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6407000 b6480000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6492000 b6497000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64a7000 b64b1000 r-xp /usr/lib/libvconf.so.0.2.45
b64c1000 b64c3000 r-xp /usr/lib/libvasum.so.0.3.1
b64d3000 b64d5000 r-xp /usr/lib/libttrace.so.1.1
b64e5000 b64e8000 r-xp /usr/lib/libiniparser.so.0
b64f8000 b651e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b652e000 b6533000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6544000 b655b000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b656c000 b65d7000 r-xp /lib/libm-2.20-2014.11.so
b65e8000 b65ee000 r-xp /lib/librt-2.20-2014.11.so
b65ff000 b660c000 r-xp /usr/lib/libunwind.so.8.0.1
b6642000 b6766000 r-xp /lib/libc-2.20-2014.11.so
b677b000 b6794000 r-xp /lib/libgcc_s-4.9.so.1
b67a4000 b6886000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6897000 b68c1000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68d2000 b690e000 r-xp /usr/lib/libsystemd.so.0.4.0
b6910000 b6993000 r-xp /usr/lib/libedje.so.1.13.0
b69a6000 b69c4000 r-xp /usr/lib/libecore.so.1.13.0
b69e4000 b6b6b000 r-xp /usr/lib/libevas.so.1.13.0
b6ba0000 b6bb4000 r-xp /lib/libpthread-2.20-2014.11.so
b6bc8000 b6dfc000 r-xp /usr/lib/libelementary.so.1.13.0
b6e2b000 b6e2f000 r-xp /usr/lib/libsmack.so.1.0.0
b6e3f000 b6e46000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e56000 b6e58000 r-xp /usr/lib/libdlog.so.0.0.0
b6e68000 b6e6b000 r-xp /usr/lib/libbundle.so.0.1.22
b6e7b000 b6e7d000 r-xp /lib/libdl-2.20-2014.11.so
b6e8e000 b6ea6000 r-xp /usr/lib/libaul.so.0.1.0
b6eba000 b6ebf000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ed0000 b6edd000 r-xp /usr/lib/liblptcp.so
b6eef000 b6ef3000 r-xp /usr/lib/libsys-assert.so
b6f04000 b6f24000 r-xp /lib/ld-2.20-2014.11.so
b6f35000 b6f3a000 r-xp /usr/bin/launchpad-loader
b7731000 b7976000 rw-p [heap]
bef1b000 bef3c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19587)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb666db84) [/lib/libc.so.6] + 0x2bb84
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
 amd_request.c: __request_handler(906) > __request_handler: 35
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
06-13 14:12:22.501+0900 W/CRASH_MANAGER(19486): worker.c: worker_job(1199) > 0619559636c691497330742
06-13 14:12:23.272+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17729486
06-13 14:12:23.272+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 14:12:23.272+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17729486
06-13 14:12:23.272+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 14:12:23.272+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 14:12:23.402+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 19559 pgid = 19559
06-13 14:12:23.402+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(19559)
06-13 14:12:23.412+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 19559.
06-13 14:12:23.412+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1934
06-13 14:12:23.442+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:12:23.442+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:12:23.442+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:12:23.442+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 19559
06-13 14:12:23.442+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 19559.
06-13 14:12:23.442+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 19559
06-13 14:12:23.442+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 19559
06-13 14:12:23.442+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1935
06-13 14:12:23.582+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:12:23.582+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:12:23.582+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:12:23.582+0900 E/STARTER (  721): )
06-13 14:12:23.582+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:12:23.582+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:12:23.582+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:12:23.592+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
06-13 14:12:23.592+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:12:23.602+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 14:12:23.602+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:12:23.602+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 14:12:23.602+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:12:23.612+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:12:23.612+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:12:23.612+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:12:23.612+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:12:23.632+0900 E/CAPI_APPFW_APPLICATION(19545): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:12:23.632+0900 E/CAPI_APPFW_APPLICATION(19545): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:12:23.632+0900 E/CAPI_APPFW_APPLICATION(19545): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:12:23.632+0900 E/CAPI_APPFW_APPLICATION(19545): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:12:23.632+0900 E/CAPI_APPFW_APPLICATION(19545): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:12:23.632+0900 I/CAPI_APPFW_APPLICATION(19545): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:12:23.632+0900 I/CAPI_APPFW_APPLICATION(19545): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:12:23.722+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 19545, appid: com.samsung.task-mgr
06-13 14:12:23.722+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:12:23.722+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(19545)
06-13 14:12:23.722+0900 E/RESOURCED(  667): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-13 14:12:23.742+0900 W/TASK_MGR_LITE(19545): task-mgr-lite.c: create_win(197) > changeable ui enabled success
06-13 14:12:23.752+0900 I/GXT_SIB (19545): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:12:23.792+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:12:23.792+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:12:23.852+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 14:12:23.852+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:12:23.852+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:12:23.852+0900 E/RUA     (19545): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 24, ncols : 5
06-13 14:12:23.852+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 14:12:23.852+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:12:23.862+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:12:23.862+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 14:12:23.882+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 14:12:23.943+0900 I/APP_CORE(19545): appcore-efl.c: __do_app(514) > [APP 19545] Event: RESET State: CREATED
06-13 14:12:23.943+0900 I/CAPI_APPFW_APPLICATION(19545): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 14:12:23.943+0900 E/EFL     (19545): edje<19545> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:12:23.943+0900 E/EFL     (19545): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:12:23.943+0900 E/EFL     (19545): edje<19545> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:12:23.943+0900 E/EFL     (19545): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:12:23.953+0900 W/APP_CORE(19545): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3200003
06-13 14:12:23.953+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
06-13 14:12:24.073+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: PAUSE State: RUNNING
06-13 14:12:24.073+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:12:24.073+0900 E/cluster-home( 1167): homescreen.cpp: OnPause(260) >  app pause
06-13 14:12:24.083+0900 I/APP_CORE(19545): appcore-efl.c: __do_app(514) > [APP 19545] Event: RESUME State: CREATED
06-13 14:12:24.083+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(4)
06-13 14:12:24.083+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(1167)
06-13 14:12:24.083+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: bg
06-13 14:12:24.093+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(19545) status(3)
06-13 14:12:24.093+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:12:24.093+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:12:24.093+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(19545)
06-13 14:12:24.093+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 19545, appid: com.samsung.task-mgr, status: fg
06-13 14:12:24.103+0900 I/APP_CORE(19545): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-13 14:12:24.103+0900 I/APP_CORE(19545): appcore-efl.c: __do_app(625) > [APP 19545] Initial Launching, call the resume_cb
06-13 14:12:24.103+0900 I/CAPI_APPFW_APPLICATION(19545): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:12:24.383+0900 I/UXT     (19587): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:12:24.423+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 14:12:24.423+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17730633
06-13 14:12:24.423+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17730633
06-13 14:12:24.423+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 14:12:24.423+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:12:24.423+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:12:24.423+0900 E/STARTER (  721): )
06-13 14:12:24.423+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:12:24.433+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:12:24.433+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:12:24.433+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:12:24.433+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(19545) status(0)
06-13 14:12:24.673+0900 E/EFL     (19545): ecore_x<19545> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17730886
06-13 14:12:24.753+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1939
06-13 14:12:24.763+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 14:12:24.763+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 19545.
06-13 14:12:24.773+0900 E/EFL     (19545): ecore_x<19545> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17730984
06-13 14:12:24.873+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:12:25.214+0900 E/EFL     (19545): ecore_x<19545> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17731427
06-13 14:12:25.224+0900 E/TASK_MGR_LITE(19545): recent_app_viewer.c: on_item_mouse_move(863) > mouse hasn't been pressed!
06-13 14:12:25.284+0900 E/EFL     (19545): ecore_x<19545> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17731493
06-13 14:12:25.284+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:12:25.294+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:12:25.294+0900 W/AUL     (19545): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 14:12:25.294+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:12:25.294+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 19545
06-13 14:12:25.304+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 7
06-13 14:12:25.304+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:12:25.304+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:12:25.304+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:12:25.314+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:12:25.324+0900 I/abc     (19587): abc
06-13 14:12:25.324+0900 I/CAPI_APPFW_APPLICATION(19587): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:12:25.324+0900 I/CAPI_APPFW_APPLICATION(19587): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:12:25.354+0900 E/TBM     (19587): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:12:25.414+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 19587, appid: org.example.client
06-13 14:12:25.414+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:12:25.424+0900 W/AUL     (19545): launch.c: app_request_to_launchpad(425) > request cmd(0) result(19587)
06-13 14:12:25.574+0900 I/UXT     (19597): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:12:25.614+0900 E/TBM     (19597): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:12:25.614+0900 I/MALI    (19597): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=19597   open drm_fd=29 
06-13 14:12:25.684+0900 E/EFL     (  607): ecore_x<607> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17731891
06-13 14:12:25.734+0900 E/EFL     (19597): edje<19597> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:12:25.734+0900 E/EFL     (19597): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:12:25.734+0900 E/EFL     (19597): edje<19597> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:12:25.734+0900 E/EFL     (19597): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:12:25.734+0900 E/EFL     (19597): edje<19597> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:12:25.734+0900 E/EFL     (19597): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:12:25.824+0900 E/EFL     (  607): ecore_x<607> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17732034
06-13 14:12:26.255+0900 E/EFL     (  607): ecore_x<607> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17732463
06-13 14:12:26.375+0900 E/EFL     (  607): ecore_x<607> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17732584
06-13 14:12:26.435+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 19587 pgid = 19587
06-13 14:12:26.435+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(19587)
06-13 14:12:26.435+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 19587.
06-13 14:12:26.445+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1942
06-13 14:12:26.475+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:12:26.475+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:12:26.475+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:12:26.475+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 19587
06-13 14:12:26.475+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 19587.
06-13 14:12:26.475+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 19587
06-13 14:12:26.475+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 19587
06-13 14:12:26.475+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1943
06-13 14:12:26.755+0900 E/EFL     (19545): ecore_x<19545> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17732963
06-13 14:12:26.855+0900 E/EFL     (19545): ecore_x<19545> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17733062
06-13 14:12:26.955+0900 E/EFL     (19545): ecore_x<19545> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17733162
06-13 14:12:27.056+0900 E/EFL     (19545): ecore_x<19545> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17733261
06-13 14:12:27.156+0900 E/EFL     (19545): ecore_x<19545> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17733360
06-13 14:12:27.166+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:12:27.166+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:12:27.166+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(19545)
06-13 14:12:27.166+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 19545, appid: com.samsung.task-mgr, status: bg
06-13 14:12:27.166+0900 I/CAPI_APPFW_APPLICATION(19545): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:12:27.166+0900 W/TASK_MGR_LITE(19545): task-mgr-lite.c: _pause_app(406) > 
06-13 14:12:27.166+0900 I/CAPI_APPFW_APPLICATION(19545): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:12:27.176+0900 E/TASK_MGR_LITE(19545): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 14:12:27.186+0900 E/TASK_MGR_LITE(19545): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
06-13 14:12:27.196+0900 E/APP_CORE(19545): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 14:12:27.196+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:12:27.196+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:12:27.196+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:12:27.196+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:12:27.196+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:12:27.196+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:12:27.226+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 14:12:27.236+0900 I/MALI    (19545): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=19545   close drm_fd=30 
06-13 14:12:27.266+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:12:27.266+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:12:27.266+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:12:27.266+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:12:27.316+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:12:27.316+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:12:27.316+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: fg
06-13 14:12:27.326+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:27.336+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:27.346+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:12:27.356+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:12:27.356+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:12:27.616+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 19545 pgid = 19545
06-13 14:12:27.616+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(19545)
06-13 14:12:27.656+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:12:27.656+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:12:27.656+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:12:27.656+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 19545
06-13 14:12:27.656+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[19545] terminate event is forwarded
06-13 14:12:27.656+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:12:27.656+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 19545, ]
06-13 14:12:27.656+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:12:27.656+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 14:12:27.656+0900 I/Tizen::App( 1175): (512) > Not registered pid(19545)
06-13 14:12:27.656+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 14:12:27.656+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:12:27.656+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 19545
06-13 14:12:27.656+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 19545
06-13 14:12:27.666+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1946
06-13 14:12:27.676+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:12:27.676+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 19545.
06-13 14:12:27.696+0900 I/UXT     (19617): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:12:28.327+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:28.327+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:28.347+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:28.347+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:28.367+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:28.367+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:28.387+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:28.387+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:28.407+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:28.407+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:28.417+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:28.427+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:28.437+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:28.447+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:28.457+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:28.457+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:28.477+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:28.477+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:28.497+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:28.497+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:28.517+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:28.517+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:28.517+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:28.517+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:28.537+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:12:28.537+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:12:29.648+0900 W/CRASH_MANAGER(19486): worker.c: worker_job(1199) > 0619587636c69149733074
