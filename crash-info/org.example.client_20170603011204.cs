S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 25676
Date: 2017-06-03 01:12:04+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 25676, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x0000644c
r2   = 0x00000006, r3   = 0xb40994c0
r4   = 0x00000002, r5   = 0xb4099000
r6   = 0xb679309c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5ec1708
r10  = 0xb754d328, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbecbfd64
lr   = 0xb6689f18, pc   = 0xb6688b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     55296 KB
Buffers:     83916 KB
Cached:     271708 KB
VmPeak:     136164 KB
VmSize:     134868 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       30328 KB
VmRSS:       29576 KB
VmData:      46716 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35864 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 25676 TID = 25676
25676 25677 25739 25744 25750 

Maps Information
af1ec000 af9eb000 rw-p [stack:25750]
b0648000 b0659000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0669000 b066e000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1351000 b1359000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b136b000 b1b6a000 rw-p [stack:25744]
b1b6a000 b1b6b000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b7b000 b1b8f000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1ba3000 b1ba4000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bb4000 b1bb7000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bc8000 b1bc9000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bd9000 b1bdb000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1beb000 b1bed000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bfd000 b1c0d000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c1d000 b1c29000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c3b000 b243a000 rw-p [stack:25739]
b276b000 b2772000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2785000 b278b000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b279b000 b27cc000 r-xp /opt/usr/apps/org.example.client/bin/client
b2925000 b2a08000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a3f000 b2a67000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a79000 b3278000 rw-p [stack:25677]
b3278000 b327a000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b328a000 b3294000 r-xp /lib/libnss_files-2.20-2014.11.so
b32a5000 b32ae000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32bf000 b32d0000 r-xp /lib/libnsl-2.20-2014.11.so
b32e3000 b32e9000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32fa000 b32fb000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3323000 b332a000 r-xp /usr/lib/libminizip.so.1.0.0
b333a000 b333f000 r-xp /usr/lib/libstorage.so.0.1
b334f000 b33ae000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33c4000 b33d8000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33e8000 b342c000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b343c000 b3444000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3454000 b3484000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3497000 b3550000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3564000 b35b7000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35c8000 b35e3000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35f3000 b36b4000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36c7000 b36d7000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36e7000 b36f4000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3705000 b370c000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b371c000 b375d000 r-xp /usr/lib/libmdm.so.1.2.12
b376d000 b3775000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3784000 b3794000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37b5000 b3815000 r-xp /usr/lib/libasound.so.2.0.0
b3827000 b382a000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b383a000 b383d000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b384d000 b3852000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3862000 b3863000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3873000 b387e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3892000 b3899000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38a9000 b38af000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38bf000 b38c4000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38d4000 b38ef000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38ff000 b3906000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3916000 b3919000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b392a000 b3958000 r-xp /usr/lib/libidn.so.11.5.44
b3968000 b397e000 r-xp /usr/lib/libnghttp2.so.5.4.0
b398f000 b3999000 r-xp /usr/lib/libcares.so.2.1.0
b39a9000 b39b3000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39c3000 b39c5000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39d5000 b39d6000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39e6000 b39ea000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39fb000 b3a23000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a34000 b3a5d000 r-xp /usr/lib/libturbojpeg.so
b3a7d000 b3a83000 r-xp /usr/lib/libgif.so.4.1.6
b3a93000 b3ad9000 r-xp /usr/lib/libcurl.so.4.3.0
b3aea000 b3b0b000 r-xp /usr/lib/libexif.so.12.3.3
b3b26000 b3b3b000 r-xp /usr/lib/libtts.so
b3b4c000 b3b54000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b64000 b3c2a000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c4a000 b3d42000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d61000 b3e2f000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e46000 b3e48000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e58000 b3e5e000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e6e000 b3e91000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ea2000 b3ea4000 r-xp /usr/lib/libappsvc.so.0.1.0
b3eb4000 b3eb6000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ec7000 b3ecc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ee3000 b3ee5000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ef5000 b3efc000 r-xp /usr/lib/libsensord-share.so
b3f0c000 b3f24000 r-xp /usr/lib/libsensor.so.1.1.0
b3f35000 b3f38000 r-xp /usr/lib/libXv.so.1.0.0
b3f48000 b3f4d000 r-xp /usr/lib/libutilX.so.1.1.0
b3f5d000 b3f62000 r-xp /usr/lib/libappcore-common.so.1.1
b3f72000 b3f79000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f8c000 b3f90000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fa1000 b407f000 r-xp /usr/lib/libCOREGL.so.4.0
b409f000 b40a2000 r-xp /usr/lib/libuuid.so.1.3.0
b40b2000 b40c9000 r-xp /usr/lib/libblkid.so.1.1.0
b40da000 b40dc000 r-xp /usr/lib/libXau.so.6.0.0
b40ec000 b4133000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4145000 b414b000 r-xp /usr/lib/libjson-c.so.2.0.1
b415c000 b4160000 r-xp /usr/lib/libogg.so.0.7.1
b4170000 b4192000 r-xp /usr/lib/libvorbis.so.0.4.3
b41a2000 b4286000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42a2000 b42a5000 r-xp /usr/lib/libEGL.so.1.4
b42b6000 b42bc000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42cc000 b42ce000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42de000 b42eb000 r-xp /usr/lib/libGLESv2.so.2.0
b42fc000 b435e000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4373000 b438b000 r-xp /usr/lib/libmount.so.1.1.0
b439d000 b43b1000 r-xp /usr/lib/libxcb.so.1.1.0
b43c1000 b43c8000 r-xp /lib/libcrypt-2.20-2014.11.so
b4400000 b4402000 r-xp /usr/lib/libiri.so
b4412000 b441d000 r-xp /usr/lib/libgpg-error.so.0.15.0
b442e000 b4464000 r-xp /usr/lib/libpulse.so.0.16.2
b4475000 b44b8000 r-xp /usr/lib/libsndfile.so.1.0.25
b44cd000 b44e2000 r-xp /lib/libexpat.so.1.5.2
b44f4000 b45b2000 r-xp /usr/lib/libcairo.so.2.11200.14
b45c6000 b45ce000 r-xp /usr/lib/libdrm.so.2.4.0
b45de000 b45e1000 r-xp /usr/lib/libdri2.so.0.0.0
b45f1000 b463f000 r-xp /usr/lib/libssl.so.1.0.0
b4654000 b4660000 r-xp /usr/lib/libeeze.so.1.13.0
b4671000 b467a000 r-xp /usr/lib/libethumb.so.1.13.0
b468a000 b468d000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b469d000 b4854000 r-xp /usr/lib/libcrypto.so.1.0.0
b563f000 b5648000 r-xp /usr/lib/libXi.so.6.1.0
b5658000 b565a000 r-xp /usr/lib/libXgesture.so.7.0.0
b566a000 b566e000 r-xp /usr/lib/libXtst.so.6.1.0
b567e000 b5684000 r-xp /usr/lib/libXrender.so.1.3.0
b5694000 b569a000 r-xp /usr/lib/libXrandr.so.2.2.0
b56aa000 b56ac000 r-xp /usr/lib/libXinerama.so.1.0.0
b56bd000 b56c0000 r-xp /usr/lib/libXfixes.so.3.1.0
b56d0000 b56db000 r-xp /usr/lib/libXext.so.6.4.0
b56eb000 b56ed000 r-xp /usr/lib/libXdamage.so.1.1.0
b56fd000 b56ff000 r-xp /usr/lib/libXcomposite.so.1.0.0
b570f000 b57f1000 r-xp /usr/lib/libX11.so.6.3.0
b5805000 b580c000 r-xp /usr/lib/libXcursor.so.1.0.2
b581c000 b5834000 r-xp /usr/lib/libudev.so.1.6.0
b5836000 b5839000 r-xp /lib/libattr.so.1.1.0
b5849000 b5869000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b586a000 b586f000 r-xp /usr/lib/libffi.so.6.0.2
b5880000 b5898000 r-xp /lib/libz.so.1.2.8
b58a8000 b58aa000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58ba000 b598f000 r-xp /usr/lib/libxml2.so.2.9.2
b59a4000 b5a3f000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a5b000 b5a5e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a6e000 b5a87000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a98000 b5aa9000 r-xp /lib/libresolv-2.20-2014.11.so
b5abd000 b5b37000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b4c000 b5b4e000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b5e000 b5b65000 r-xp /usr/lib/libembryo.so.1.13.0
b5b75000 b5b7f000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b90000 b5ba8000 r-xp /usr/lib/libpng12.so.0.50.0
b5bb9000 b5bdc000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bfd000 b5c11000 r-xp /usr/lib/libector.so.1.13.0
b5c22000 b5c3a000 r-xp /usr/lib/liblua-5.1.so
b5c4b000 b5ca2000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cb6000 b5cde000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cef000 b5d02000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d13000 b5d4d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d5e000 b5d6c000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d7c000 b5d84000 r-xp /usr/lib/libtbm.so.1.0.0
b5d94000 b5da1000 r-xp /usr/lib/libeio.so.1.13.0
b5db1000 b5db3000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dc3000 b5dc8000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dd8000 b5def000 r-xp /usr/lib/libefreet.so.1.13.0
b5e01000 b5e21000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e31000 b5e51000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e53000 b5e59000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e69000 b5e7a000 r-xp /usr/lib/libemotion.so.1.13.0
b5e8b000 b5e92000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ea2000 b5eb1000 r-xp /usr/lib/libeo.so.1.13.0
b5ec2000 b5ed4000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ee5000 b5eea000 r-xp /usr/lib/libecore_file.so.1.13.0
b5efa000 b5f13000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f23000 b5f40000 r-xp /usr/lib/libeet.so.1.13.0
b5f59000 b5fa1000 r-xp /usr/lib/libeina.so.1.13.0
b5fb2000 b5fc2000 r-xp /usr/lib/libefl.so.1.13.0
b5fd3000 b60b8000 r-xp /usr/lib/libicuuc.so.51.1
b60d5000 b6215000 r-xp /usr/lib/libicui18n.so.51.1
b622c000 b6264000 r-xp /usr/lib/libecore_x.so.1.13.0
b6276000 b6279000 r-xp /lib/libcap.so.2.21
b6289000 b62b2000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62c3000 b62ca000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62dc000 b6313000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6324000 b640f000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6422000 b649b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64ad000 b64b2000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64c2000 b64cc000 r-xp /usr/lib/libvconf.so.0.2.45
b64dc000 b64de000 r-xp /usr/lib/libvasum.so.0.3.1
b64ee000 b64f0000 r-xp /usr/lib/libttrace.so.1.1
b6500000 b6503000 r-xp /usr/lib/libiniparser.so.0
b6513000 b6539000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6549000 b654e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b655f000 b6576000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6587000 b65f2000 r-xp /lib/libm-2.20-2014.11.so
b6603000 b6609000 r-xp /lib/librt-2.20-2014.11.so
b661a000 b6627000 r-xp /usr/lib/libunwind.so.8.0.1
b665d000 b6781000 r-xp /lib/libc-2.20-2014.11.so
b6796000 b67af000 r-xp /lib/libgcc_s-4.9.so.1
b67bf000 b68a1000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68b2000 b68dc000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68ed000 b6929000 r-xp /usr/lib/libsystemd.so.0.4.0
b692b000 b69ae000 r-xp /usr/lib/libedje.so.1.13.0
b69c1000 b69df000 r-xp /usr/lib/libecore.so.1.13.0
b69ff000 b6b86000 r-xp /usr/lib/libevas.so.1.13.0
b6bbb000 b6bcf000 r-xp /lib/libpthread-2.20-2014.11.so
b6be3000 b6e17000 r-xp /usr/lib/libelementary.so.1.13.0
b6e46000 b6e4a000 r-xp /usr/lib/libsmack.so.1.0.0
b6e5a000 b6e61000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e71000 b6e73000 r-xp /usr/lib/libdlog.so.0.0.0
b6e83000 b6e86000 r-xp /usr/lib/libbundle.so.0.1.22
b6e96000 b6e98000 r-xp /lib/libdl-2.20-2014.11.so
b6ea9000 b6ec1000 r-xp /usr/lib/libaul.so.0.1.0
b6ed5000 b6eda000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eeb000 b6ef8000 r-xp /usr/lib/liblptcp.so
b6f0a000 b6f0e000 r-xp /usr/lib/libsys-assert.so
b6f1f000 b6f3f000 r-xp /lib/ld-2.20-2014.11.so
b6f50000 b6f55000 r-xp /usr/bin/launchpad-loader
b7146000 b760f000 rw-p [heap]
beca0000 becc1000 rw-p [stack]
beca0000 becc1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:25676)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6688b84) [/lib/libc.so.6] + 0x2bb84
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
nfo, ret: -1
06-03 01:04:31.069+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 804
06-03 01:04:31.069+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-03 01:04:31.079+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 01:04:31.109+0900 I/GXT_SIB (  335): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-03 01:04:31.109+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6c906e9 in class 'Edje_Object'.
06-03 01:04:31.109+0900 E/UXT     (  335): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
06-03 01:04:31.119+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 01:04:31.119+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 01:04:31.119+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 01:04:31.139+0900 E/CAPI_APPFW_APPLICATION(25650): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-03 01:04:31.139+0900 E/CAPI_APPFW_APPLICATION(25650): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-03 01:04:31.139+0900 E/CAPI_APPFW_APPLICATION(25650): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-03 01:04:31.139+0900 E/CAPI_APPFW_APPLICATION(25650): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-03 01:04:31.139+0900 E/CAPI_APPFW_APPLICATION(25650): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-03 01:04:31.139+0900 I/CAPI_APPFW_APPLICATION(25650): app_main.c: ui_app_main(789) > app_efl_main
06-03 01:04:31.139+0900 I/CAPI_APPFW_APPLICATION(25650): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 01:04:31.209+0900 W/TASK_MGR_LITE(25650): task-mgr-lite.c: create_win(197) > changeable ui enabled success
06-03 01:04:31.209+0900 I/GXT_SIB (25650): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-03 01:04:31.219+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 25650, appid: com.samsung.task-mgr
06-03 01:04:31.219+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 01:04:31.219+0900 W/AUL     (  804): launch.c: app_request_to_launchpad(425) > request cmd(0) result(25650)
06-03 01:04:31.229+0900 E/RESOURCED(  678): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-03 01:04:31.269+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:04:31.269+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:04:31.289+0900 E/EFL     (  335): evas-gl_x11<335> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-03 01:04:31.299+0900 E/EFL     (  335): evas-gl_x11<335> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-03 01:04:31.299+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 12
06-03 01:04:31.309+0900 E/RUA     (25650): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 20, ncols : 5
06-03 01:04:31.309+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
06-03 01:04:31.309+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 14
06-03 01:04:31.309+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-03 01:04:31.309+0900 W/AUL_AMD (  612): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 25314
06-03 01:04:31.309+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 12
06-03 01:04:31.319+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-03 01:04:31.319+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-03 01:04:31.319+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-03 01:04:31.319+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-03 01:04:31.319+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-03 01:04:31.319+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-03 01:04:31.319+0900 E/EFL     (  335): evas-gl_x11<335> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-03 01:04:31.319+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-03 01:04:31.319+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 01:04:31.329+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-03 01:04:31.329+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.system-syspopup) in ai_tbl !!
06-03 01:04:31.329+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-03 01:04:31.329+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-03 01:04:31.329+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-03 01:04:31.329+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-03 01:04:31.329+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-03 01:04:31.329+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-03 01:04:31.329+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsung-log-relay-mobile-service) in ai_tbl !!
06-03 01:04:31.329+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-03 01:04:31.329+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-03 01:04:31.329+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-03 01:04:31.329+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-03 01:04:31.329+0900 E/EFL     (  335): evas-gl_x11<335> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-03 01:04:31.329+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-03 01:04:31.329+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 01:04:31.329+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:04:31.339+0900 E/EFL     (  335): evas-gl_x11<335> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-03 01:04:31.349+0900 E/EFL     (  335): evas-gl_x11<335> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-03 01:04:31.369+0900 E/EFL     (  335): evas-gl_x11<335> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-03 01:04:31.379+0900 E/EFL     (  335): evas-gl_x11<335> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-03 01:04:31.389+0900 I/APP_CORE(25650): appcore-efl.c: __do_app(514) > [APP 25650] Event: RESET State: CREATED
06-03 01:04:31.389+0900 I/CAPI_APPFW_APPLICATION(25650): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 01:04:31.389+0900 E/EFL     (25650): edje<25650> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:04:31.389+0900 E/EFL     (25650): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:04:31.389+0900 E/EFL     (25650): edje<25650> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:04:31.389+0900 E/EFL     (25650): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:04:31.389+0900 W/APP_CORE(25650): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800003
06-03 01:04:31.389+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 01:04:31.399+0900 E/EFL     (  335): evas-gl_x11<335> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-03 01:04:31.409+0900 E/EFL     (  335): evas-gl_x11<335> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-03 01:04:31.419+0900 E/EFL     (  850): ecore_x<850> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=968068580
06-03 01:04:31.419+0900 E/EFL     (25314): ecore_x<25314> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=968068580
06-03 01:04:31.419+0900 W/STARTER (  804): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-03 01:04:31.419+0900 E/STARTER (  804): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-03 01:04:31.419+0900 E/STARTER (  804): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-03 01:04:31.419+0900 E/STARTER (  804): )
06-03 01:04:31.419+0900 I/SYSPOPUP(  865): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-03 01:04:31.419+0900 I/SYSPOPUP(  865): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-03 01:04:31.419+0900 E/VOLUME  (  865): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-03 01:04:31.419+0900 E/VOLUME  (  865): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-03 01:04:31.429+0900 E/EFL     (  335): evas-gl_x11<335> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-03 01:04:31.449+0900 E/EFL     (  335): evas-gl_x11<335> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-03 01:04:31.499+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(25650) status(0)
06-03 01:04:31.499+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(25650) status(0)
06-03 01:04:31.509+0900 I/APP_CORE(25314): appcore-efl.c: __do_app(514) > [APP 25314] Event: PAUSE State: RUNNING
06-03 01:04:31.509+0900 I/CAPI_APPFW_APPLICATION(25314): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 01:04:31.509+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(25314) status(4)
06-03 01:04:31.509+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(25314)
06-03 01:04:31.509+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 25314, appid: org.example.client, status: bg
06-03 01:04:31.509+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(25650) status(3)
06-03 01:04:31.509+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:04:31.509+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:04:31.509+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(25650)
06-03 01:04:31.509+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 25650, appid: com.samsung.task-mgr, status: fg
06-03 01:04:31.519+0900 I/APP_CORE(25650): appcore-efl.c: __do_app(514) > [APP 25650] Event: RESUME State: CREATED
06-03 01:04:31.529+0900 E/EFL     (  335): evas-gl_x11<335> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-03 01:04:31.529+0900 I/TIZEN_N_EFL_UTIL_WINDOW(25314): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 21
06-03 01:04:31.529+0900 E/APP_CORE(25314): appcore-efl.c: _capture_and_make_file(1619) > win[3600002] widget[720] height[1280]
06-03 01:04:31.529+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 33
06-03 01:04:31.540+0900 I/APP_CORE(25650): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 01:04:31.540+0900 I/APP_CORE(25650): appcore-efl.c: __do_app(625) > [APP 25650] Initial Launching, call the resume_cb
06-03 01:04:31.540+0900 I/CAPI_APPFW_APPLICATION(25650): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:04:31.920+0900 E/EFL     (25650): ecore_x<25650> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=968069083
06-03 01:04:32.030+0900 E/EFL     (25650): ecore_x<25650> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=968069194
06-03 01:04:32.310+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2823
06-03 01:04:32.320+0900 I/Tizen::App( 1233): (499) > LaunchedApp(com.samsung.task-mgr)
06-03 01:04:32.320+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for com.samsung.task-mgr, 25650.
06-03 01:04:32.350+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 01:04:32.350+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(1201) > app status : 5
06-03 01:04:32.350+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(25650)
06-03 01:04:32.350+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 25650, appid: com.samsung.task-mgr, status: bg
06-03 01:04:32.360+0900 I/CAPI_APPFW_APPLICATION(25650): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 01:04:32.360+0900 W/TASK_MGR_LITE(25650): task-mgr-lite.c: _pause_app(406) > 
06-03 01:04:32.360+0900 I/CAPI_APPFW_APPLICATION(25650): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-03 01:04:32.370+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 14
06-03 01:04:32.370+0900 W/AUL_AMD (  612): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 25314
06-03 01:04:32.370+0900 W/AUL     (25650): launch.c: app_request_to_launchpad(396) > request cmd(4) to(25314)
06-03 01:04:32.370+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 4
06-03 01:04:32.370+0900 W/AUL_AMD (  612): amd_launch.c: __reply_handler(1083) > listen fd(38) , send fd(37), pid(25314), cmd(4)
06-03 01:04:32.370+0900 W/AUL     (25650): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
06-03 01:04:32.370+0900 I/APP_CORE(25314): appcore-efl.c: __do_app(514) > [APP 25314] Event: TERMINATE State: PAUSED
06-03 01:04:32.370+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 01:04:32.370+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(1201) > app status : 5
06-03 01:04:32.380+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 01:04:32.380+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(1201) > app status : 5
06-03 01:04:32.390+0900 E/TASK_MGR_LITE(25650): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-03 01:04:32.390+0900 I/TIZEN_N_EFL_UTIL_WINDOW(25314): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 12
06-03 01:04:32.390+0900 E/APP_CORE(25314): appcore-efl.c: _capture_and_make_file(1619) > win[3600002] widget[720] height[1280]
06-03 01:04:32.390+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 33
06-03 01:04:32.390+0900 E/APP_CORE(25314): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.client]
06-03 01:04:32.400+0900 E/TASK_MGR_LITE(25650): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
06-03 01:04:32.410+0900 I/CAPI_APPFW_APPLICATION(25314): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-03 01:04:32.410+0900 E/APP_CORE(25650): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-03 01:04:32.430+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:04:32.430+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-03 01:04:32.430+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:04:32.430+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:04:32.430+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-03 01:04:32.430+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-03 01:04:32.450+0900 I/MALI    (25650): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=25650   close drm_fd=30 
06-03 01:04:32.480+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-03 01:04:32.520+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-03 01:04:32.520+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:04:32.520+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-03 01:04:32.520+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:04:32.550+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 01:04:32.550+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:04:32.561+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [com.samsun] 
06-03 01:04:32.561+0900 I/Tizen::System( 1233): (273) > Current App[com.samsun] is already actived.
06-03 01:04:32.591+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
06-03 01:04:32.631+0900 E/weather-common( 1310): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
06-03 01:04:32.641+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_create(409) > New handle created[0xb8253a10]
06-03 01:04:32.641+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_get_type(463) > Connected Network = 2
06-03 01:04:32.641+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_destroy(427) > Destroy handle: 0xb8253a10
06-03 01:04:32.651+0900 E/weather-common( 1310): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
06-03 01:04:32.661+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
06-03 01:04:32.661+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 01:04:32.661+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 01:04:32.661+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: fg
06-03 01:04:32.791+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 25650 pgid = 25650
06-03 01:04:32.791+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(25650)
06-03 01:04:32.831+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 01:04:32.831+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 01:04:32.831+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
06-03 01:04:32.831+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 25650
06-03 01:04:32.831+0900 I/Tizen::App( 1233): (243) > App[com.samsung.task-mgr] pid[25650] terminate event is forwarded
06-03 01:04:32.831+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
06-03 01:04:32.831+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [com.samsung.task-mgr, 25650, ]
06-03 01:04:32.831+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
06-03 01:04:32.831+0900 I/Tizen::App( 1233): (506) > TerminatedApp(com.samsung.task-mgr)
06-03 01:04:32.831+0900 I/Tizen::App( 1233): (512) > Not registered pid(25650)
06-03 01:04:32.831+0900 I/Tizen::System( 1233): (246) > Terminated app [com.samsung.task-mgr]
06-03 01:04:32.841+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-03 01:04:32.841+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 25650
06-03 01:04:32.841+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 25650
06-03 01:04:32.861+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-03 01:04:32.861+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for com.samsung.task-mgr, 25650.
06-03 01:04:33.051+0900 E/VCONF   (25314): vconf-kdb.c: _vconf_kdb_del_notify(468) > Error: inotify_add_watch() [/opt/var/kdb/db/ise+keysound]: Permission denied
06-03 01:04:33.051+0900 E/VCONF   (25314): vconf.c: vconf_ignore_key_changed(3218) > vconf_ignore_key_changed() failed: key(db/ise/keysound)
06-03 01:04:33.091+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 25314 pgid = 25314
06-03 01:04:33.091+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(25314)
06-03 01:04:33.121+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 01:04:33.121+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 01:04:33.121+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
06-03 01:04:33.131+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[25314] terminate event is forwarded
06-03 01:04:33.131+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
06-03 01:04:33.131+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 25314, ]
06-03 01:04:33.131+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
06-03 01:04:33.131+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
06-03 01:04:33.131+0900 I/Tizen::App( 1233): (512) > Not registered pid(25314)
06-03 01:04:33.131+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
06-03 01:04:33.131+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-03 01:04:33.131+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 25314
06-03 01:04:33.131+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 25314
06-03 01:04:33.131+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2825
06-03 01:04:33.141+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-03 01:04:33.141+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.example.client, 25314.
06-03 01:04:33.351+0900 E/EFL     (  867): ecore_x<867> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=968070510
06-03 01:04:33.411+0900 E/EFL     (  867): ecore_x<867> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=968070576
06-03 01:04:33.421+0900 W/AUL     (  867): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
06-03 01:04:33.421+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 01:04:33.421+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 867
06-03 01:04:33.431+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 4
06-03 01:04:33.431+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 01:04:33.431+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 01:04:33.431+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 01:04:33.431+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 01:04:33.451+0900 I/abc     (25676): abc
06-03 01:04:33.451+0900 I/CAPI_APPFW_APPLICATION(25676): app_main.c: ui_app_main(789) > app_efl_main
06-03 01:04:33.451+0900 I/CAPI_APPFW_APPLICATION(25676): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 01:04:33.491+0900 E/TBM     (25676): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 01:04:33.541+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 25676, appid: org.example.client
06-03 01:04:33.541+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 01:04:33.541+0900 W/AUL     (  867): launch.c: app_request_to_launchpad(425) > request cmd(1) result(25676)
06-03 01:04:33.642+0900 I/UXT     (25724): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 01:04:33.682+0900 E/TBM     (25724): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 01:04:33.682+0900 I/MALI    (25724): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=25724   open drm_fd=30 
06-03 01:04:33.812+0900 E/EFL     (25724): edje<25724> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:04:33.812+0900 E/EFL     (25724): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:04:33.812+0900 E/EFL     (25724): edje<25724> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:04:33.812+0900 E/EFL     (25724): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:04:33.812+0900 E/EFL     (25724): edje<25724> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:04:33.812+0900 E/EFL     (25724): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:04:33.822+0900 I/APP_CORE(25676): appcore-efl.c: __do_app(514) > [APP 25676] Event: RESET State: CREATED
06-03 01:04:33.822+0900 I/CAPI_APPFW_APPLICATION(25676): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 01:04:33.832+0900 E/EFL     (25676): edje<25676> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:04:33.832+0900 E/EFL     (25676): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:04:33.842+0900 E/EFL     (25676): edje<25676> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:04:33.842+0900 E/EFL     (25676): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:04:33.842+0900 E/EFL     (25676): edje<25676> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:04:33.842+0900 E/EFL     (25676): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:04:33.852+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:04:33.852+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:04:33.862+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:04:33.882+0900 W/APP_CORE(25676): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
06-03 01:04:33.882+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 01:04:33.882+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
06-03 01:04:33.882+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-03 01:04:33.892+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-03 01:04:33.982+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-03 01:04:33.982+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 01:04:33.982+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-03 01:04:33.982+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-03 01:04:33.982+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-03 01:04:33.982+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-03 01:04:33.992+0900 I/APP_CORE(25676): appcore-efl.c: __do_app(514) > [APP 25676] Event: RESUME State: CREATED
06-03 01:04:33.992+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(25676) status(3)
06-03 01:04:33.992+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(25676)
06-03 01:04:33.992+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 25676, appid: org.example.client, status: fg
06-03 01:04:34.002+0900 I/APP_CORE(25676): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 01:04:34.002+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 01:04:34.002+0900 I/APP_CORE(25676): appcore-efl.c: __do_app(625) > [APP 25676] Initial Launching, call the resume_cb
06-03 01:04:34.002+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 01:04:34.002+0900 I/CAPI_APPFW_APPLICATION(25676): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:04:34.002+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-03 01:04:34.352+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(25676) status(0)
06-03 01:04:34.592+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2828
06-03 01:04:34.613+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
06-03 01:04:34.613+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 25676.
06-03 01:04:35.033+0900 E/EFL     (25676): ecore_x<25676> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=968072193
06-03 01:04:35.113+0900 E/EFL     (25676): ecore_x<25676> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=968072270
06-03 01:04:35.433+0900 I/UXT     (25747): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 01:04:35.483+0900 E/EFL     (25676): ecore_x<25676> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=968072638
06-03 01:04:35.483+0900 I/MY_LOG  (25676): Button pressed
06-03 01:04:35.553+0900 E/EFL     (25676): ecore_x<25676> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=968072715
06-03 01:04:35.553+0900 E/VCONF   (25676): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-03 01:04:35.553+0900 E/VCONF   (25676): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-03 01:04:35.553+0900 E/VCONF   (25676): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-03 01:04:35.553+0900 E/VCONF   (25676): vconf.c: vconf_get_bool(2729) > vconf_get_bool(25676) : db/ise/keysound error
06-03 01:04:35.553+0900 E/VCONF   (25676): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-03 01:04:35.553+0900 E/VCONF   (25676): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-03 01:04:35.593+0900 I/MY_LOG  (25676): Button unpressed
06-03 01:04:37.365+0900 W/AUL_AMD (  612): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-03 01:04:37.375+0900 W/AUL_AMD (  612): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-03 01:04:37.385+0900 W/AUL_AMD (  612): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-03 01:04:38.987+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-03 01:04:41.769+0900 E/AUL_AMD (  612): amd_launch.c: _amd_proc_find_proc_info(1914) > proc info not found
06-03 01:05:00.808+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-03 01:05:00.808+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:05
06-03 01:05:00.808+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오전 1:05"
06-03 01:05:00.808+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:05"
06-03 01:05:00.808+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-03 01:05:00.808+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146409992 Time: <font_size=31> </font_size> <font_size=31> 오전 1:05</font_size></font>"
06-03 01:06:00.867+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-03 01:06:00.867+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:06
06-03 01:06:00.867+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오전 1:06"
06-03 01:06:00.867+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:06"
06-03 01:06:00.867+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-03 01:06:00.867+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146407940 Time: <font_size=31> </font_size> <font_size=31> 오전 1:06</font_size></font>"
06-03 01:07:00.915+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-03 01:07:00.915+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:07
06-03 01:07:00.915+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오전 1:07"
06-03 01:07:00.915+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:07"
06-03 01:07:00.915+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-03 01:07:00.915+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146407423 Time: <font_size=31> </font_size> <font_size=31> 오전 1:07</font_size></font>"
06-03 01:08:00.974+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-03 01:08:00.974+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:08
06-03 01:08:00.974+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오전 1:08"
06-03 01:08:00.974+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:08"
06-03 01:08:00.974+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-03 01:08:00.974+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146404859 Time: <font_size=31> </font_size> <font_size=31> 오전 1:08</font_size></font>"
06-03 01:08:12.235+0900 E/EFL     (25676): ecore_x<25676> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=968289393
06-03 01:08:12.235+0900 I/MY_LOG  (25676): Button pressed
06-03 01:08:12.275+0900 E/EFL     (25676): ecore_x<25676> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=968289448
06-03 01:08:12.285+0900 I/MY_LOG  (25676): Button unpressed
06-03 01:08:12.325+0900 D/basicui (25676): successed to load edc file
06-03 01:08:13.736+0900 E/EFL     (25676): ecore_x<25676> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=968290900
06-03 01:08:13.736+0900 I/MY_LOG  (25676): Button pressed
06-03 01:08:13.826+0900 E/EFL     (25676): ecore_x<25676> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=968290988
06-03 01:08:13.826+0900 I/MY_LOG  (25676): Button unpressed
06-03 01:08:13.846+0900 E/EFL     (25676): elementary<25676> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
06-03 01:08:14.477+0900 E/EFL     (25676): ecore_x<25676> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=968291643
06-03 01:08:14.477+0900 I/MY_LOG  (25676): Button pressed
06-03 01:08:14.547+0900 E/EFL     (25676): ecore_x<25676> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=968291708
06-03 01:08:14.547+0900 I/MY_LOG  (25676): Button unpressed
06-03 01:08:14.577+0900 D/basicui (25676): successed to load edc file
06-03 01:08:14.587+0900 E/EFL     (25676): elementary<25676> elm_layout.c:991 _elm_layout_elm_container_content_set() could not swallow 0x80102e1c into part 'swallow_content'
06-03 01:08:16.459+0900 E/EFL     (25676): ecore_x<25676> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=968293624
06-03 01:08:16.459+0900 I/MY_LOG  (25676): Button pressed
06-03 01:08:16.529+0900 E/EFL     (25676): ecore_x<25676> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=968293691
06-03 01:08:16.529+0900 I/MY_LOG  (25676): Button unpressed
06-03 01:08:24.907+0900 E/EFL     (25676): ecore_x<25676> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=968302074
06-03 01:08:24.907+0900 I/MY_LOG  (25676): Button pressed
06-03 01:08:24.987+0900 E/EFL     (25676): ecore_x<25676> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=968302151
06-03 01:08:24.987+0900 I/MY_LOG  (25676): Button unpressed
06-03 01:09:01.012+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-03 01:09:01.012+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:09
06-03 01:09:01.012+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오전 1:09"
06-03 01:09:01.012+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:09"
06-03 01:09:01.012+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-03 01:09:01.012+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146376151 Time: <font_size=31> </font_size> <font_size=31> 오전 1:09</font_size></font>"
06-03 01:10:00.030+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-03 01:10:00.030+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:10
06-03 01:10:00.030+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오전 1:10"
06-03 01:10:00.030+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:10"
06-03 01:10:00.030+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-03 01:10:00.030+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146866643 Time: <font_size=31> </font_size> <font_size=31> 오전 1:10</font_size></font>"
06-03 01:11:00.089+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-03 01:11:00.089+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:11
06-03 01:11:00.089+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오전 1:11"
06-03 01:11:00.089+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:11"
06-03 01:11:00.089+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-03 01:11:00.089+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146433999 Time: <font_size=31> </font_size> <font_size=31> 오전 1:11</font_size></font>"
06-03 01:12:00.137+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-03 01:12:00.137+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:12
06-03 01:12:00.137+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오전 1:12"
06-03 01:12:00.137+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:12"
06-03 01:12:00.137+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-03 01:12:00.137+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146437067 Time: <font_size=31> </font_size> <font_size=31> 오전 1:12</font_size></font>"
06-03 01:12:04.221+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:12:04.231+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 25676 pgid = 25676
06-03 01:12:04.231+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(25676)
06-03 01:12:04.271+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-03 01:12:04.271+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:12:04.271+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:12:04.271+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-03 01:12:04.271+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-03 01:12:04.281+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-03 01:12:04.311+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 01:12:04.311+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 01:12:04.311+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
06-03 01:12:04.311+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 25676
06-03 01:12:04.311+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[25676] terminate event is forwarded
06-03 01:12:04.311+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
06-03 01:12:04.311+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 25676, ]
06-03 01:12:04.311+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
06-03 01:12:04.311+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
06-03 01:12:04.311+0900 I/Tizen::App( 1233): (512) > Not registered pid(25676)
06-03 01:12:04.311+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
06-03 01:12:04.311+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-03 01:12:04.321+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 25676
06-03 01:12:04.321+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 25676
06-03 01:12:04.321+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-03 01:12:04.321+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:12:04.321+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-03 01:12:04.321+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:12:04.321+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2832
06-03 01:12:04.341+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 01:12:04.381+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
06-03 01:12:04.401+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-03 01:12:04.401+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 01:12:04.401+0900 E/weather-common( 1310): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
06-03 01:12:04.401+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-03 01:12:04.401+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 01:12:04.411+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:12:04.441+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-03 01:12:04.441+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.example.client, 25676.
06-03 01:12:04.441+0900 W/CRASH_MANAGER(25787): worker.c: worker_job(1199) > 0625676636c69149641992
