S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 2069
Date: 2017-04-06 05:52:56+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 2069, uid 5000)

Register Information
r0   = 0xfffffffc, r1   = 0xb7b56f00
r2   = 0x00000400, r3   = 0x00000000
r4   = 0xb6f5c114, r5   = 0xb677e470
r6   = 0xb7c06510, r7   = 0x00000123
r8   = 0x80074ba7, r9   = 0xb5f15708
r10  = 0xb7c01828, fp   = 0xbe961ff4
ip   = 0x00000000, sp   = 0xbe961fc8
lr   = 0xb40ed4c0, pc   = 0xb677e4b4
cpsr = 0x800f0010

Memory Information
MemTotal:   987012 KB
MemFree:    218504 KB
Buffers:     38496 KB
Cached:     312592 KB
VmPeak:     133924 KB
VmSize:     133920 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28244 KB
VmRSS:       28244 KB
VmData:      45860 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35780 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 2069 TID = 2069
2069 2070 2162 2163 2172 

Maps Information
aee8e000 af68d000 rw-p [stack:2172]
b0f92000 b0fa3000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0fb3000 b0fb8000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b13ba000 b13c2000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13d4000 b1bd3000 rw-p [stack:2163]
b1bd3000 b1bd4000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1be4000 b1bf8000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c0c000 b1c0d000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c1d000 b1c20000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c31000 b1c32000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c42000 b1c44000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c54000 b1c56000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c66000 b1c76000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c86000 b1c92000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1ca4000 b24a3000 rw-p [stack:2162]
b27d4000 b27db000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27ee000 b27f4000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2804000 b2820000 r-xp /opt/usr/apps/org.example.client/bin/client
b2979000 b2a5c000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a93000 b2abb000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2acd000 b32cc000 rw-p [stack:2070]
b32cc000 b32ce000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32de000 b32e8000 r-xp /lib/libnss_files-2.20-2014.11.so
b32f9000 b3302000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3313000 b3324000 r-xp /lib/libnsl-2.20-2014.11.so
b3337000 b333d000 r-xp /lib/libnss_compat-2.20-2014.11.so
b334e000 b334f000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3377000 b337e000 r-xp /usr/lib/libminizip.so.1.0.0
b338e000 b3393000 r-xp /usr/lib/libstorage.so.0.1
b33a3000 b3402000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3418000 b342c000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b343c000 b3480000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3490000 b3498000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34a8000 b34d8000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34eb000 b35a4000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35b8000 b360b000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b361c000 b3637000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3647000 b3708000 r-xp /usr/lib/libprotobuf.so.9.0.1
b371b000 b372b000 r-xp /usr/lib/libefl-assist.so.0.1.0
b373b000 b3748000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3759000 b3760000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3770000 b37b1000 r-xp /usr/lib/libmdm.so.1.2.12
b37c1000 b37c9000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37d8000 b37e8000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3809000 b3869000 r-xp /usr/lib/libasound.so.2.0.0
b387b000 b387e000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b388e000 b3891000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38a1000 b38a6000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38b6000 b38b7000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38c7000 b38d2000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38e6000 b38ed000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38fd000 b3903000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3913000 b3918000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3928000 b3943000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3953000 b395a000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b396a000 b396d000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b397e000 b39ac000 r-xp /usr/lib/libidn.so.11.5.44
b39bc000 b39d2000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39e3000 b39ed000 r-xp /usr/lib/libcares.so.2.1.0
b39fd000 b3a07000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a17000 b3a19000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a29000 b3a2a000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a3a000 b3a3e000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a4f000 b3a77000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a88000 b3ab1000 r-xp /usr/lib/libturbojpeg.so
b3ad1000 b3ad7000 r-xp /usr/lib/libgif.so.4.1.6
b3ae7000 b3b2d000 r-xp /usr/lib/libcurl.so.4.3.0
b3b3e000 b3b5f000 r-xp /usr/lib/libexif.so.12.3.3
b3b7a000 b3b8f000 r-xp /usr/lib/libtts.so
b3ba0000 b3ba8000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bb8000 b3c7e000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c9e000 b3d96000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3db5000 b3e83000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e9a000 b3e9c000 r-xp /usr/lib/libboost_system.so.1.51.0
b3eac000 b3eb2000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ec2000 b3ee5000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ef6000 b3ef8000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f08000 b3f0a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f1b000 b3f20000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f37000 b3f39000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f49000 b3f50000 r-xp /usr/lib/libsensord-share.so
b3f60000 b3f78000 r-xp /usr/lib/libsensor.so.1.1.0
b3f89000 b3f8c000 r-xp /usr/lib/libXv.so.1.0.0
b3f9c000 b3fa1000 r-xp /usr/lib/libutilX.so.1.1.0
b3fb1000 b3fb6000 r-xp /usr/lib/libappcore-common.so.1.1
b3fc6000 b3fcd000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fe0000 b3fe4000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3ff5000 b40d3000 r-xp /usr/lib/libCOREGL.so.4.0
b40f3000 b40f6000 r-xp /usr/lib/libuuid.so.1.3.0
b4106000 b411d000 r-xp /usr/lib/libblkid.so.1.1.0
b412e000 b4130000 r-xp /usr/lib/libXau.so.6.0.0
b4140000 b4187000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4199000 b419f000 r-xp /usr/lib/libjson-c.so.2.0.1
b41b0000 b41b4000 r-xp /usr/lib/libogg.so.0.7.1
b41c4000 b41e6000 r-xp /usr/lib/libvorbis.so.0.4.3
b41f6000 b42da000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42f6000 b42f9000 r-xp /usr/lib/libEGL.so.1.4
b430a000 b4310000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4320000 b4322000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4332000 b433f000 r-xp /usr/lib/libGLESv2.so.2.0
b4350000 b43b2000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43c7000 b43df000 r-xp /usr/lib/libmount.so.1.1.0
b43f1000 b4405000 r-xp /usr/lib/libxcb.so.1.1.0
b4415000 b441c000 r-xp /lib/libcrypt-2.20-2014.11.so
b4454000 b4456000 r-xp /usr/lib/libiri.so
b4466000 b4471000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4482000 b44b8000 r-xp /usr/lib/libpulse.so.0.16.2
b44c9000 b450c000 r-xp /usr/lib/libsndfile.so.1.0.25
b4521000 b4536000 r-xp /lib/libexpat.so.1.5.2
b4548000 b4606000 r-xp /usr/lib/libcairo.so.2.11200.14
b461a000 b4622000 r-xp /usr/lib/libdrm.so.2.4.0
b4632000 b4635000 r-xp /usr/lib/libdri2.so.0.0.0
b4645000 b4693000 r-xp /usr/lib/libssl.so.1.0.0
b46a8000 b46b4000 r-xp /usr/lib/libeeze.so.1.13.0
b46c5000 b46ce000 r-xp /usr/lib/libethumb.so.1.13.0
b46de000 b46e1000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46f1000 b48a8000 r-xp /usr/lib/libcrypto.so.1.0.0
b5693000 b569c000 r-xp /usr/lib/libXi.so.6.1.0
b56ac000 b56ae000 r-xp /usr/lib/libXgesture.so.7.0.0
b56be000 b56c2000 r-xp /usr/lib/libXtst.so.6.1.0
b56d2000 b56d8000 r-xp /usr/lib/libXrender.so.1.3.0
b56e8000 b56ee000 r-xp /usr/lib/libXrandr.so.2.2.0
b56fe000 b5700000 r-xp /usr/lib/libXinerama.so.1.0.0
b5711000 b5714000 r-xp /usr/lib/libXfixes.so.3.1.0
b5724000 b572f000 r-xp /usr/lib/libXext.so.6.4.0
b573f000 b5741000 r-xp /usr/lib/libXdamage.so.1.1.0
b5751000 b5753000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5763000 b5845000 r-xp /usr/lib/libX11.so.6.3.0
b5859000 b5860000 r-xp /usr/lib/libXcursor.so.1.0.2
b5870000 b5888000 r-xp /usr/lib/libudev.so.1.6.0
b588a000 b588d000 r-xp /lib/libattr.so.1.1.0
b589d000 b58bd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58be000 b58c3000 r-xp /usr/lib/libffi.so.6.0.2
b58d4000 b58ec000 r-xp /lib/libz.so.1.2.8
b58fc000 b58fe000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b590e000 b59e3000 r-xp /usr/lib/libxml2.so.2.9.2
b59f8000 b5a93000 r-xp /usr/lib/libstdc++.so.6.0.20
b5aaf000 b5ab2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ac2000 b5adb000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aec000 b5afd000 r-xp /lib/libresolv-2.20-2014.11.so
b5b11000 b5b8b000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5ba0000 b5ba2000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bb2000 b5bb9000 r-xp /usr/lib/libembryo.so.1.13.0
b5bc9000 b5bd3000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5be4000 b5bfc000 r-xp /usr/lib/libpng12.so.0.50.0
b5c0d000 b5c30000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c51000 b5c65000 r-xp /usr/lib/libector.so.1.13.0
b5c76000 b5c8e000 r-xp /usr/lib/liblua-5.1.so
b5c9f000 b5cf6000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d0a000 b5d32000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d43000 b5d56000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d67000 b5da1000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5db2000 b5dc0000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dd0000 b5dd8000 r-xp /usr/lib/libtbm.so.1.0.0
b5de8000 b5df5000 r-xp /usr/lib/libeio.so.1.13.0
b5e05000 b5e07000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e17000 b5e1c000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e2c000 b5e43000 r-xp /usr/lib/libefreet.so.1.13.0
b5e55000 b5e75000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e85000 b5ea5000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ea7000 b5ead000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ebd000 b5ece000 r-xp /usr/lib/libemotion.so.1.13.0
b5edf000 b5ee6000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ef6000 b5f05000 r-xp /usr/lib/libeo.so.1.13.0
b5f16000 b5f28000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f39000 b5f3e000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f4e000 b5f67000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f77000 b5f94000 r-xp /usr/lib/libeet.so.1.13.0
b5fad000 b5ff5000 r-xp /usr/lib/libeina.so.1.13.0
b6006000 b6016000 r-xp /usr/lib/libefl.so.1.13.0
b6027000 b610c000 r-xp /usr/lib/libicuuc.so.51.1
b6129000 b6269000 r-xp /usr/lib/libicui18n.so.51.1
b6280000 b62b8000 r-xp /usr/lib/libecore_x.so.1.13.0
b62ca000 b62cd000 r-xp /lib/libcap.so.2.21
b62dd000 b6306000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6317000 b631e000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6330000 b6367000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6378000 b6463000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6476000 b64ef000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6501000 b6506000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6516000 b6520000 r-xp /usr/lib/libvconf.so.0.2.45
b6530000 b6532000 r-xp /usr/lib/libvasum.so.0.3.1
b6542000 b6544000 r-xp /usr/lib/libttrace.so.1.1
b6554000 b6557000 r-xp /usr/lib/libiniparser.so.0
b6567000 b658d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b659d000 b65a2000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65b3000 b65ca000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65db000 b6646000 r-xp /lib/libm-2.20-2014.11.so
b6657000 b665d000 r-xp /lib/librt-2.20-2014.11.so
b666e000 b667b000 r-xp /usr/lib/libunwind.so.8.0.1
b66b1000 b67d5000 r-xp /lib/libc-2.20-2014.11.so
b67ea000 b6803000 r-xp /lib/libgcc_s-4.9.so.1
b6813000 b68f5000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6906000 b6930000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6941000 b697d000 r-xp /usr/lib/libsystemd.so.0.4.0
b697f000 b6a02000 r-xp /usr/lib/libedje.so.1.13.0
b6a15000 b6a33000 r-xp /usr/lib/libecore.so.1.13.0
b6a53000 b6bda000 r-xp /usr/lib/libevas.so.1.13.0
b6c0f000 b6c23000 r-xp /lib/libpthread-2.20-2014.11.so
b6c37000 b6e6b000 r-xp /usr/lib/libelementary.so.1.13.0
b6e9a000 b6e9e000 r-xp /usr/lib/libsmack.so.1.0.0
b6eae000 b6eb5000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ec5000 b6ec7000 r-xp /usr/lib/libdlog.so.0.0.0
b6ed7000 b6eda000 r-xp /usr/lib/libbundle.so.0.1.22
b6eea000 b6eec000 r-xp /lib/libdl-2.20-2014.11.so
b6efd000 b6f15000 r-xp /usr/lib/libaul.so.0.1.0
b6f29000 b6f2e000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f3f000 b6f4c000 r-xp /usr/lib/liblptcp.so
b6f5e000 b6f62000 r-xp /usr/lib/libsys-assert.so
b6f73000 b6f93000 r-xp /lib/ld-2.20-2014.11.so
b6fa4000 b6fa9000 r-xp /usr/bin/launchpad-loader
b787e000 b7c5d000 rw-p [heap]
be942000 be963000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2069)
Call Stack Count: 4
 0: recv + 0x44 (0xb677e4b4) [/lib/libc.so.6] + 0xcd4b4
 1: recv + 0xfc (0xb6f42d50) [/usr/lib/liblptcp.so] + 0x3d50
 2: _ZN9AppSocket11receiveDataEv + 0x5a (0xb28144a7) [/opt/usr/apps/org.example.client/bin/client] + 0x104a7
 3: (0x400) (null)
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
:52:26.808+0900 E/STARTER (  741): )
04-06 05:52:26.818+0900 W/AUL     (  741): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
04-06 05:52:26.818+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-06 05:52:26.828+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
04-06 05:52:26.828+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:52:26.828+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 741
04-06 05:52:26.828+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:52:26.838+0900 E/RESOURCED(  665): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 05:52:26.838+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 05:52:26.838+0900 W/AUL_PAD ( 1536): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 05:52:26.838+0900 W/AUL_PAD ( 1536): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 05:52:26.858+0900 I/GXT_SIB (  434): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
04-06 05:52:26.868+0900 E/CAPI_APPFW_APPLICATION( 1542): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 05:52:26.868+0900 E/CAPI_APPFW_APPLICATION( 1542): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 05:52:26.868+0900 E/CAPI_APPFW_APPLICATION( 1542): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 05:52:26.868+0900 E/CAPI_APPFW_APPLICATION( 1542): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 05:52:26.868+0900 E/CAPI_APPFW_APPLICATION( 1542): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-06 05:52:26.868+0900 I/CAPI_APPFW_APPLICATION( 1542): app_main.c: ui_app_main(789) > app_efl_main
04-06 05:52:26.868+0900 I/CAPI_APPFW_APPLICATION( 1542): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 05:52:26.878+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6b936e9 in class 'Edje_Object'.
04-06 05:52:26.878+0900 E/UXT     (  434): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
04-06 05:52:26.938+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 1542, appid: com.samsung.task-mgr
04-06 05:52:26.938+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 05:52:26.938+0900 W/AUL     (  741): launch.c: app_request_to_launchpad(425) > request cmd(0) result(1542)
04-06 05:52:26.948+0900 E/RESOURCED(  665): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
04-06 05:52:26.978+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:52:26.998+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:52:27.008+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:52:27.028+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:52:27.048+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:52:27.058+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:52:27.068+0900 W/TASK_MGR_LITE( 1542): task-mgr-lite.c: create_win(197) > changeable ui enabled success
04-06 05:52:27.068+0900 E/EFL     (  853): ecore_x<853> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=304167
04-06 05:52:27.068+0900 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=304167
04-06 05:52:27.068+0900 W/STARTER (  741): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
04-06 05:52:27.068+0900 E/cluster-view(  869): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
04-06 05:52:27.068+0900 E/STARTER (  741): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
04-06 05:52:27.068+0900 E/STARTER (  741): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
04-06 05:52:27.068+0900 E/STARTER (  741): )
04-06 05:52:27.068+0900 I/SYSPOPUP(  866): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
04-06 05:52:27.078+0900 I/GXT_SIB ( 1542): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
04-06 05:52:27.098+0900 I/SYSPOPUP(  866): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
04-06 05:52:27.098+0900 E/VOLUME  (  866): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
04-06 05:52:27.098+0900 E/VOLUME  (  866): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
04-06 05:52:27.108+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: service_manager_subscribe(895) > [34m[2102]subscribtion: org.tizen.shop_agent[0m
04-06 05:52:27.108+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: service_manager_subscribe(915) > [34m[2102]Policy[0m
04-06 05:52:27.108+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: svcman_dbus_db_open(668) > [34m[2102]Service DB Open/Create[0m
04-06 05:52:27.108+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: svcman_dbus_db_open(726) > [34m[2102]Service DB Open Success[0m
04-06 05:52:27.108+0900 W/SERVICE_MANAGER_LIB( 2102): service-manager.c: service_manager_subscribe(940) > [33m[2102]org.tizen.shop_agent policy subscribed[0m
04-06 05:52:27.108+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: svcman_dbus_db_close(733) > [34m[2102]svcman_dbus_db_close[0m
04-06 05:52:27.108+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: service_manager_subscribe(946) > [34m[2102]Status[0m
04-06 05:52:27.108+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:52:27.108+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: svcman_dbus_db_open(668) > [34m[2102]Service DB Open/Create[0m
04-06 05:52:27.108+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:52:27.108+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: svcman_dbus_db_open(726) > [34m[2102]Service DB Open Success[0m
04-06 05:52:27.108+0900 W/SERVICE_MANAGER_LIB( 2102): service-manager.c: service_manager_subscribe(971) > [33m[2102]org.tizen.shop_agent status subscribed[0m
04-06 05:52:27.108+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: svcman_dbus_db_close(733) > [34m[2102]svcman_dbus_db_close[0m
04-06 05:52:27.108+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: service_manager_subscribe(977) > [34m[2102]Auth[0m
04-06 05:52:27.108+0900 W/SERVICE_MANAGER_LIB( 2102): service-manager.c: svcman_dbus_db_subscribed(761) > [33m[2102]DB handle is NULL[0m
04-06 05:52:27.108+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: svcman_dbus_db_open(668) > [34m[2102]Service DB Open/Create[0m
04-06 05:52:27.118+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: svcman_dbus_db_open(726) > [34m[2102]Service DB Open Success[0m
04-06 05:52:27.118+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:52:27.138+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:52:27.138+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: svcman_dbus_db_close(733) > [34m[2102]svcman_dbus_db_close[0m
04-06 05:52:27.138+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: service_manager_subscribe(1005) > [34m[2102]Active[0m
04-06 05:52:27.138+0900 W/SERVICE_MANAGER_LIB( 2102): service-manager.c: svcman_dbus_db_subscribed(761) > [33m[2102]DB handle is NULL[0m
04-06 05:52:27.138+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: svcman_dbus_db_open(668) > [34m[2102]Service DB Open/Create[0m
04-06 05:52:27.138+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 12
04-06 05:52:27.138+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: svcman_dbus_db_open(726) > [34m[2102]Service DB Open Success[0m
04-06 05:52:27.138+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:52:27.148+0900 I/Tizen::System( 1248): (259) > Active app [com.samsun], current [com.samsun] 
04-06 05:52:27.148+0900 I/Tizen::System( 1248): (273) > Current App[com.samsun] is already actived.
04-06 05:52:27.148+0900 E/RUA     ( 1542): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 15, ncols : 5
04-06 05:52:27.148+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 05:52:27.148+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:52:27.158+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-06 05:52:27.158+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:52:27.158+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: svcman_dbus_db_close(733) > [34m[2102]svcman_dbus_db_close[0m
04-06 05:52:27.158+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: service_manager_subscribe(1032) > [34m[2102]subscribtion done[0m
04-06 05:52:27.158+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: service_manager_register_listener2(468) > [34m[2102]service_manager_register_listener2[0m
04-06 05:52:27.168+0900 E/TASK_MGR_LITE( 1542): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsung-log-relay-mobile-service) in ai_tbl !!
04-06 05:52:27.168+0900 E/TASK_MGR_LITE( 1542): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
04-06 05:52:27.168+0900 E/TASK_MGR_LITE( 1542): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
04-06 05:52:27.168+0900 E/TASK_MGR_LITE( 1542): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
04-06 05:52:27.168+0900 E/TASK_MGR_LITE( 1542): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
04-06 05:52:27.168+0900 E/TASK_MGR_LITE( 1542): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
04-06 05:52:27.168+0900 E/TASK_MGR_LITE( 1542): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
04-06 05:52:27.168+0900 E/TASK_MGR_LITE( 1542): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
04-06 05:52:27.168+0900 E/TASK_MGR_LITE( 1542): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
04-06 05:52:27.168+0900 E/TASK_MGR_LITE( 1542): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
04-06 05:52:27.168+0900 E/TASK_MGR_LITE( 1542): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
04-06 05:52:27.168+0900 E/TASK_MGR_LITE( 1542): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
04-06 05:52:27.168+0900 E/TASK_MGR_LITE( 1542): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
04-06 05:52:27.168+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:52:27.178+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:52:27.198+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:52:27.198+0900 I/SERVICE_MANAGER_LIB( 2102): service-manager.c: service_manager_register_object(494) > [34m[2102]service_manager_register_object[0m
04-06 05:52:27.248+0900 I/APP_CORE( 1542): appcore-efl.c: __do_app(514) > [APP 1542] Event: RESET State: CREATED
04-06 05:52:27.248+0900 I/CAPI_APPFW_APPLICATION( 1542): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 05:52:27.258+0900 E/EFL     ( 1542): edje<1542> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:52:27.258+0900 E/EFL     ( 1542): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:52:27.258+0900 E/EFL     ( 1542): edje<1542> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:52:27.258+0900 E/EFL     ( 1542): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:52:27.258+0900 W/APP_CORE( 1542): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00003
04-06 05:52:27.258+0900 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.261
04-06 05:52:27.258+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 05:52:27.268+0900 I/SERVICE_ADAPTOR_CLIENT( 2102): service_adaptor_client.c: service_adaptor_connect(823) > Service Adaptor Client Connect (Push Debug version)
04-06 05:52:27.268+0900 I/SERVICE_ADAPTOR_CLIENT( 2102): service_adaptor_client.c: service_adaptor_connect(826) > [34m[2118]API Called <service_adaptor_connect>[0m
04-06 05:52:27.288+0900 I/SERVICE_ADAPTOR_CLIENT( 2102): service_adaptor_client.c: service_adaptor_connect(867) > [34m[2118]Proxy creation success[0m
04-06 05:52:27.288+0900 I/SERVICE_ADAPTOR( 1148): dbus-service-adaptor.c: service_adaptor_method_call(101) > [34m[2120]Client Connected Successful[0m
04-06 05:52:27.288+0900 I/SERVICE_ADAPTOR_CLIENT( 2102): service_adaptor_client.c: service_adaptor_connect(897) > [34m[2118]Connects success handle (0xb8be12b0) instance (0xb1000600)[0m
04-06 05:52:27.288+0900 I/SERVICE_ADAPTOR_CLIENT( 2102): service_adaptor_client.c: service_adaptor_external_request(1062) > [34m[2118]API Called <service_adaptor_external_request>[0m
04-06 05:52:27.288+0900 E/SERVICE_ADAPTOR( 1148): service-adaptor.c: service_adaptor_get_service_context(137) > [31m[2120]Invalid argument[0m
04-06 05:52:27.288+0900 I/SERVICE_ADAPTOR( 1148): dbus-auth-adaptor.c: auth_external_method_call(684) > [34m[2120]Try API without context((null))[0m
04-06 05:52:27.288+0900 I/AUTH_ADAPTOR( 1148): auth-adaptor.c: auth_adaptor_plugin_ref(629) > [34m[2120]plugin name: com.samsung.coreapps, ref_counter: 3[0m
04-06 05:52:27.288+0900 I/AUTH_ADAPTOR( 1148): auth-adaptor.c: auth_adaptor_external_request(1573) > [34m[2120][ENTER] plugin API call -)) -)) -)) -)) -)) -)) -)) -)) -)) -))[0m
04-06 05:52:27.298+0900 I/AUTH_PLUGIN_ESU( 1148): auth-plugin-esu-internal.c: esu_internal_get_imsi_sync_wrapper(1668) > [34m[2121]esu_check_account_exist imsi : (null), msisdn : (null)[0m
04-06 05:52:27.298+0900 E/AUTH_PLUGIN_ESU( 1148): auth-plugin-esu-internal.c: esu_internal_get_imsi_sync_wrapper(1673) > [31m[2121]Get imsi send request failed:(-214)[0m
04-06 05:52:27.298+0900 E/AUTH_PLUGIN_ESU( 1148): auth-plugin-esu.c: plugin_esu_get_imsi(1112) > [31m[2120]ERROR code 201[0m
04-06 05:52:27.298+0900 E/AUTH_PLUGIN_ESU( 1148): auth-plugin-esu.c: plugin_esu_get_imsi(1113) > [31m[2120]ERROR MSG ESU is not ready[0m
04-06 05:52:27.298+0900 I/AUTH_ADAPTOR( 1148): auth-adaptor.c: auth_adaptor_external_request(1577) > [34m[2120][EXIT] plugin API called (16) ((- ((- ((- ((- ((- ((- ((- ((- ((- ((-[0m
04-06 05:52:27.298+0900 E/AUTH_ADAPTOR( 1148): auth-adaptor.c: auth_adaptor_external_request(1577) > [31m[2120]plugin issued error (201) (ESU is not ready)[0m
04-06 05:52:27.308+0900 E/SERVICE_ADAPTOR_CLIENT( 2102): service_adaptor_client.c: service_adaptor_external_request(1095) > [31m[2118]Error occured (201)([PLUGIN_ERROR] URI(com.samsung.coreapps), MSG(ESU is not ready))[0m
04-06 05:52:27.308+0900 I/SERVICE_ADAPTOR_CLIENT( 2102): service_adaptor_client.c: service_adaptor_external_request(1103) > [34m[2118]API End <service_adaptor_external_request>: -49479678[0m
04-06 05:52:27.308+0900 I/SERVICE_ADAPTOR_CLIENT( 2102): service_adaptor_client.c: service_adaptor_set_imsi(979) > [34m[2118]API Called <service_adaptor_set_imsi>[0m
04-06 05:52:27.308+0900 I/SERVICE_ADAPTOR_CLIENT( 2102): service_adaptor_client.c: service_adaptor_set_imsi(996) > [34m[2118]API End <service_adaptor_set_imsi> : 0[0m
04-06 05:52:27.308+0900 I/SERVICE_ADAPTOR_CLIENT( 2102): service_adaptor_client_auth.c: service_adaptor_get_auth_plugin(46) > [34m[2118]API Called <service_adaptor_get_auth_plugin>[0m
04-06 05:52:27.308+0900 I/AUTH_ADAPTOR( 1148): auth-adaptor.c: auth_adaptor_plugin_ref(629) > [34m[2120]plugin name: com.samsung.coreapps, ref_counter: 4[0m
04-06 05:52:27.308+0900 I/AUTH_ADAPTOR( 1148): auth-adaptor.c: auth_adaptor_create_plugin_context(816) > [34m[2120][ENTER] plugin API call -)) -)) -)) -)) -)) -)) -)) -)) -)) -))[0m
04-06 05:52:27.318+0900 I/AUTH_PLUGIN_ESU( 1148): auth-plugin-esu-internal.c: esu_internal_check_version(1970) > [34m[2120]Easy Signup version: v0.1.1[0m
04-06 05:52:27.318+0900 I/AUTH_ADAPTOR( 1148): auth-adaptor.c: auth_adaptor_create_plugin_context(818) > [34m[2120][EXIT] plugin API called ((- ((- ((- ((- ((- ((- ((- ((- ((- ((-[0m
04-06 05:52:27.318+0900 I/AUTH_ADAPTOR( 1148): auth-adaptor.c: auth_adaptor_is_auth(1141) > [34m[2120][ENTER] plugin API call -)) -)) -)) -)) -)) -)) -)) -)) -)) -))[0m
04-06 05:52:27.318+0900 I/AUTH_PLUGIN_ESU( 1148): auth-plugin-esu-internal.c: esu_internal_is_auth_sync_wrapper(994) > [34m[2122]esu_check_account_exist imsi : (null), msisdn : (null)[0m
04-06 05:52:27.318+0900 E/AUTH_PLUGIN_ESU( 1148): auth-plugin-esu-internal.c: esu_internal_is_auth_sync_wrapper(1004) > [31m[2122]esu_internal_is_auth : esu_check_account_exist request failed:(-214)[0m
04-06 05:52:27.318+0900 E/AUTH_PLUGIN_ESU( 1148): auth-plugin-esu.c: plugin_esu_is_auth(492) > [31m[2120]ERROR code 201[0m
04-06 05:52:27.318+0900 E/AUTH_PLUGIN_ESU( 1148): auth-plugin-esu.c: plugin_esu_is_auth(493) > [31m[2120]ERROR MSG ESU is not ready[0m
04-06 05:52:27.318+0900 I/AUTH_ADAPTOR( 1148): auth-adaptor.c: auth_adaptor_is_auth(1143) > [34m[2120][EXIT] plugin API called (16) ((- ((- ((- ((- ((- ((- ((- ((- ((- ((-[0m
04-06 05:52:27.318+0900 E/AUTH_ADAPTOR( 1148): auth-adaptor.c: auth_adaptor_is_auth(1143) > [31m[2120]plugin issued error (201) (ESU is not ready)[0m
04-06 05:52:27.318+0900 E/SERVICE_ADAPTOR( 1148): dbus-auth-adaptor.c: auth_adaptor_method_call(125) > [31m[2120]Is_auth Function Internal error : 4[0m
04-06 05:52:27.318+0900 E/SERVICE_ADAPTOR( 1148): dbus-auth-adaptor.c: auth_adaptor_method_call(128) > [31m[2120][201] [PLUGIN_ERROR] URI(com.samsung.coreapps), MSG(ESU is not ready)[0m
04-06 05:52:27.318+0900 I/AUTH_ADAPTOR( 1148): auth-adaptor.c: auth_adaptor_destroy_plugin_context(856) > [34m[2120][ENTER] plugin API call -)) -)) -)) -)) -)) -)) -)) -)) -)) -))[0m
04-06 05:52:27.318+0900 I/AUTH_ADAPTOR( 1148): auth-adaptor.c: auth_adaptor_destroy_plugin_context(858) > [34m[2120][EXIT] plugin API called ((- ((- ((- ((- ((- ((- ((- ((- ((- ((-[0m
04-06 05:52:27.318+0900 I/SERVICE_ADAPTOR_CLIENT( 2102): service_adaptor_client_auth.c: service_adaptor_get_auth_plugin(89) > [34m[2118]API End <service_adaptor_get_auth_plugin> :  0[0m
04-06 05:52:27.318+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2102): system_settings.c: system_settings_get_value_string(543) > Enter [system_settings_get_value_string]
04-06 05:52:27.318+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2102): system_settings.c: system_settings_get_value(404) > Enter [system_settings_get_value]
04-06 05:52:27.318+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2102): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=13
04-06 05:52:27.318+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2102): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 12, key = 13, type = 0
04-06 05:52:27.318+0900 E/SERVICE_ADAPTOR_CLIENT( 2102): service_adaptor_client_shop.c: service_adaptor_get_item_list(54) > [31m[2118]Invalid Parameter[0m
04-06 05:52:27.318+0900 E/SERVICE_ADAPTOR_CLIENT( 2102): service_adaptor_client_shop.c: service_adaptor_get_item_list(55) > [31m[2118]Error occured b : (-22) (Invalid Parameter)[0m
04-06 05:52:27.378+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(1542) status(0)
04-06 05:52:27.388+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(1542) status(0)
04-06 05:52:27.388+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: PAUSE State: RUNNING
04-06 05:52:27.388+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:52:27.388+0900 E/cluster-home(  869): homescreen.cpp: OnPause(260) >  app pause
04-06 05:52:27.388+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(4)
04-06 05:52:27.388+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(869)
04-06 05:52:27.388+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: bg
04-06 05:52:27.388+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(1542) status(3)
04-06 05:52:27.388+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:52:27.388+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:52:27.388+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(1542)
04-06 05:52:27.388+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1542, appid: com.samsung.task-mgr, status: fg
04-06 05:52:27.398+0900 E/EFL     (  434): evas-gl_x11<434> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:52:27.398+0900 I/APP_CORE( 1542): appcore-efl.c: __do_app(514) > [APP 1542] Event: RESUME State: CREATED
04-06 05:52:27.408+0900 I/CAPI_WIDGET_APPLICATION( 1406): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 05:52:27.408+0900 I/CAPI_WIDGET_APPLICATION( 1406): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 05:52:27.408+0900 W/AUL     ( 1406): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1406, appid: com.samsung.weather-m-widget, status: bg
04-06 05:52:27.418+0900 I/APP_CORE( 1542): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:52:27.418+0900 I/APP_CORE( 1542): appcore-efl.c: __do_app(625) > [APP 1542] Initial Launching, call the resume_cb
04-06 05:52:27.418+0900 I/CAPI_APPFW_APPLICATION( 1542): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:52:27.698+0900 E/EFL     ( 1542): ecore_x<1542> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=304806
04-06 05:52:27.819+0900 E/EFL     ( 1542): ecore_x<1542> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=304927
04-06 05:52:27.979+0900 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.262
04-06 05:52:27.989+0900 I/Tizen::App( 1248): (499) > LaunchedApp(com.samsung.task-mgr)
04-06 05:52:27.989+0900 I/Tizen::App( 1248): (733) > Finished invoking application event listener for com.samsung.task-mgr, 1542.
04-06 05:52:28.119+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 05:52:28.119+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 05:52:28.119+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(1542)
04-06 05:52:28.119+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1542, appid: com.samsung.task-mgr, status: bg
04-06 05:52:28.119+0900 I/CAPI_APPFW_APPLICATION( 1542): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:52:28.119+0900 W/TASK_MGR_LITE( 1542): task-mgr-lite.c: _pause_app(406) > 
04-06 05:52:28.119+0900 I/CAPI_APPFW_APPLICATION( 1542): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-06 05:52:28.119+0900 E/TASK_MGR_LITE( 1542): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
04-06 05:52:28.119+0900 E/EFL     ( 1542): eo<1542> lib/eo/eo_ptr_indirection.x:295 _eo_obj_pointer_get() eo_id 0x800343a2's acvie is  NULL, entry: 0xb32e1d28, 0xb873ae68, 0
04-06 05:52:28.119+0900 E/EFL     ( 1542): eo<1542> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0x800343a2 is not pointing to a valid object. Maybe it has already been freed.
04-06 05:52:28.119+0900 E/EFL     ( 1542): eo<1542> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x800343a2) is an invalid ref.
04-06 05:52:28.129+0900 E/TASK_MGR_LITE( 1542): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
04-06 05:52:28.139+0900 E/APP_CORE( 1542): appcore.c: appcore_flush_memory(793) > Appcore not initialized
04-06 05:52:28.139+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:52:28.149+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(3)
04-06 05:52:28.149+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:52:28.149+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:52:28.149+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(869)
04-06 05:52:28.149+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: fg
04-06 05:52:28.179+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(0)
04-06 05:52:28.209+0900 I/MALI    ( 1542): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=1542   close drm_fd=25 
04-06 05:52:28.219+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:52:28.219+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: RESUME State: PAUSED
04-06 05:52:28.219+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:52:28.219+0900 E/cluster-home(  869): homescreen.cpp: OnResume(233) >  app resume
04-06 05:52:28.229+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:52:28.239+0900 E/weather-widget( 1406): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 05:52:28.239+0900 I/Tizen::System( 1248): (259) > Active app [com.samsun], current [com.samsun] 
04-06 05:52:28.239+0900 I/Tizen::System( 1248): (273) > Current App[com.samsun] is already actived.
04-06 05:52:28.259+0900 E/weather-widget( 1406): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 05:52:28.279+0900 E/weather-common( 1406): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 05:52:28.349+0900 I/CAPI_NETWORK_CONNECTION( 1406): connection.c: connection_create(409) > New handle created[0xb8b557c8]
04-06 05:52:28.349+0900 I/CAPI_NETWORK_CONNECTION( 1406): connection.c: connection_get_type(463) > Connected Network = 2
04-06 05:52:28.349+0900 I/CAPI_NETWORK_CONNECTION( 1406): connection.c: connection_destroy(427) > Destroy handle: 0xb8b557c8
04-06 05:52:28.349+0900 E/weather-common( 1406): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 05:52:28.349+0900 E/weather-widget( 1406): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 05:52:28.349+0900 I/CAPI_WIDGET_APPLICATION( 1406): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 05:52:28.349+0900 I/CAPI_WIDGET_APPLICATION( 1406): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 05:52:28.349+0900 W/AUL     ( 1406): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1406, appid: com.samsung.weather-m-widget, status: fg
04-06 05:52:28.529+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 1542 pgid = 1542
04-06 05:52:28.529+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(143) > dead_pid(1542)
04-06 05:52:28.569+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 05:52:28.569+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 05:52:28.569+0900 E/AUL_PAD ( 1536): launchpad.c: main(698) > error reading sigchld info
04-06 05:52:28.579+0900 I/ESD     (  901): esd_main.c: __esd_app_dead_handler(1773) > pid: 1542
04-06 05:52:28.579+0900 I/Tizen::App( 1248): (243) > App[com.samsung.task-mgr] pid[1542] terminate event is forwarded
04-06 05:52:28.579+0900 I/Tizen::System( 1248): (256) > osp.accessorymanager.service provider is found.
04-06 05:52:28.579+0900 I/Tizen::System( 1248): (196) > Accessory Owner is removed [com.samsung.task-mgr, 1542, ]
04-06 05:52:28.579+0900 I/Tizen::System( 1248): (256) > osp.system.service provider is found.
04-06 05:52:28.579+0900 I/Tizen::App( 1248): (506) > TerminatedApp(com.samsung.task-mgr)
04-06 05:52:28.579+0900 I/Tizen::App( 1248): (512) > Not registered pid(1542)
04-06 05:52:28.579+0900 I/Tizen::System( 1248): (246) > Terminated app [com.samsung.task-mgr]
04-06 05:52:28.579+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 05:52:28.579+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 1542
04-06 05:52:28.579+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 1542
04-06 05:52:28.579+0900 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.264
04-06 05:52:28.589+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 05:52:28.589+0900 I/Tizen::App( 1248): (782) > Finished invoking application event listener for com.samsung.task-mgr, 1542.
04-06 05:52:29.050+0900 I/UXT     ( 2131): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:52:29.100+0900 E/TBM     ( 2131): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:52:29.100+0900 I/MALI    ( 2131): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=2131   open drm_fd=30 
04-06 05:52:29.160+0900 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=306273
04-06 05:52:29.230+0900 E/EFL     ( 2131): edje<2131> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:52:29.230+0900 E/EFL     ( 2131): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:52:29.230+0900 E/EFL     ( 2131): edje<2131> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:52:29.230+0900 E/EFL     ( 2131): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:52:29.230+0900 E/EFL     ( 2131): edje<2131> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:52:29.230+0900 E/EFL     ( 2131): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:52:29.240+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 05:52:29.260+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 05:52:29.260+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: fg
04-06 05:52:29.290+0900 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=306405
04-06 05:52:29.300+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:29.310+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:29.550+0900 W/cluster-view(  869): custom-cluster-impl.cpp: OnCustomScrollComplete(8717) >  booster timer is still running on cluster-view, Stop boost timer!!!
04-06 05:52:29.620+0900 I/CAPI_WIDGET_APPLICATION( 1406): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 05:52:29.620+0900 I/CAPI_WIDGET_APPLICATION( 1406): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 05:52:29.620+0900 W/AUL     ( 1406): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1406, appid: com.samsung.weather-m-widget, status: bg
04-06 05:52:30.261+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:30.261+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:30.271+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:30.281+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:30.291+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:30.301+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:30.311+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:30.321+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:30.331+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:30.341+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:30.351+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:30.351+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:30.371+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:30.371+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:30.391+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:30.391+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:30.411+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:30.421+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:30.421+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:30.421+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:30.441+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:30.441+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:30.451+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:30.461+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:30.471+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:30.481+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:32.243+0900 E/RESOURCED(  665): procfs.c: proc_get_oom_score_adj(131) > fopen /proc/1621/oom_score_adj failed
04-06 05:52:33.134+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 05:52:37.008+0900 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=314115
04-06 05:52:37.078+0900 W/cluster-home(  869): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
04-06 05:52:37.078+0900 W/cluster-home(  869): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
04-06 05:52:37.088+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 05:52:37.088+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 05:52:37.088+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: bg
04-06 05:52:37.148+0900 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=314258
04-06 05:52:38.049+0900 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=315153
04-06 05:52:38.209+0900 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=315319
04-06 05:52:38.469+0900 W/cluster-view(  869): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
04-06 05:52:39.460+0900 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=316575
04-06 05:52:39.600+0900 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=316718
04-06 05:52:39.870+0900 W/cluster-view(  869): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
04-06 05:52:40.301+0900 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=317403
04-06 05:52:40.381+0900 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=317491
04-06 05:52:40.381+0900 W/AUL     (  869): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-06 05:52:40.381+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
04-06 05:52:40.381+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 869
04-06 05:52:40.391+0900 E/RESOURCED(  665): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-06 05:52:40.401+0900 E/RESOURCED(  665): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 05:52:40.401+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 05:52:40.401+0900 W/AUL_PAD ( 1536): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 05:52:40.401+0900 W/AUL_PAD ( 1536): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 05:52:40.411+0900 I/abc     ( 2069): abc
04-06 05:52:40.411+0900 I/CAPI_APPFW_APPLICATION( 2069): app_main.c: ui_app_main(789) > app_efl_main
04-06 05:52:40.411+0900 I/CAPI_APPFW_APPLICATION( 2069): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 05:52:40.441+0900 E/TBM     ( 2069): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:52:40.501+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 2069, appid: org.example.client
04-06 05:52:40.501+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 05:52:40.501+0900 W/AUL     (  869): launch.c: app_request_to_launchpad(425) > request cmd(1) result(2069)
04-06 05:52:40.691+0900 D/basicui ( 2069): successed to load edc file
04-06 05:52:40.721+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:52:40.721+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:52:40.741+0900 I/Tizen::System( 1248): (259) > Active app [org.exampl], current [com.samsun] 
04-06 05:52:40.741+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 05:52:40.751+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 05:52:40.751+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:52:40.781+0900 I/MY_LOG  ( 2069): change
04-06 05:52:40.821+0900 I/APP_CORE( 2069): appcore-efl.c: __do_app(514) > [APP 2069] Event: RESET State: CREATED
04-06 05:52:40.821+0900 I/CAPI_APPFW_APPLICATION( 2069): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 05:52:40.841+0900 E/EFL     ( 2069): edje<2069> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:52:40.841+0900 E/EFL     ( 2069): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:52:40.841+0900 E/EFL     ( 2069): edje<2069> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:52:40.841+0900 E/EFL     ( 2069): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:52:40.841+0900 E/EFL     ( 2069): edje<2069> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:52:40.841+0900 E/EFL     ( 2069): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:52:40.851+0900 W/APP_CORE( 2069): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000002
04-06 05:52:40.851+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 05:52:40.971+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: PAUSE State: RUNNING
04-06 05:52:40.971+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:52:40.971+0900 E/cluster-home(  869): homescreen.cpp: OnPause(260) >  app pause
04-06 05:52:40.971+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(4)
04-06 05:52:40.971+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(869)
04-06 05:52:40.971+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: bg
04-06 05:52:40.971+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(2069) status(3)
04-06 05:52:40.981+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(2069)
04-06 05:52:40.981+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 2069, appid: org.example.client, status: fg
04-06 05:52:40.981+0900 I/APP_CORE( 2069): appcore-efl.c: __do_app(514) > [APP 2069] Event: RESUME State: CREATED
04-06 05:52:41.001+0900 I/APP_CORE( 2069): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:52:41.001+0900 I/APP_CORE( 2069): appcore-efl.c: __do_app(625) > [APP 2069] Initial Launching, call the resume_cb
04-06 05:52:41.001+0900 I/CAPI_APPFW_APPLICATION( 2069): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:52:41.332+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(2069) status(0)
04-06 05:52:41.562+0900 I/Tizen::App( 1248): (499) > LaunchedApp(org.example.client)
04-06 05:52:41.562+0900 I/Tizen::App( 1248): (733) > Finished invoking application event listener for org.example.client, 2069.
04-06 05:52:41.562+0900 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.269
04-06 05:52:42.323+0900 I/UXT     ( 2168): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:52:44.885+0900 E/EFL     ( 2069): ecore_x<2069> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=321993
04-06 05:52:44.885+0900 I/MY_LOG  ( 2069): Button pressed
04-06 05:52:45.005+0900 E/EFL     ( 2069): ecore_x<2069> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=322103
04-06 05:52:45.005+0900 E/VCONF   ( 2069): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 05:52:45.005+0900 E/VCONF   ( 2069): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 05:52:45.005+0900 E/VCONF   ( 2069): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 05:52:45.005+0900 E/VCONF   ( 2069): vconf.c: vconf_get_bool(2729) > vconf_get_bool(2069) : db/ise/keysound error
04-06 05:52:45.005+0900 E/VCONF   ( 2069): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 05:52:45.005+0900 E/VCONF   ( 2069): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 05:52:45.055+0900 I/MY_LOG  ( 2069): Button unpressed
04-06 05:52:45.976+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: MEM_FLUSH State: PAUSED
04-06 05:52:56.006+0900 E/RESOURCED(  665): proc-monitor.c: proc_dbus_watchdog_handler(711) > Receive watchdog signal to pid: 2069(client)
04-06 05:52:56.006+0900 E/RESOURCED(  665): proc-monitor.c: proc_dbus_watchdog_handler(727) > just kill watchdog process when debug enabled pid: 2069(client)
04-06 05:52:56.006+0900 E/RESOURCED(  665): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
04-06 05:52:56.006+0900 E/RESOURCED(  665): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
04-06 05:52:56.006+0900 E/RESOURCED(  665): cgroup.c: place_pid_to_cgroup_by_fullpath(76) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
04-06 05:52:56.156+0900 W/CRASH_MANAGER( 2079): worker.c: worker_job(1199) > 0602069636c69149142557
