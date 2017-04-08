S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 2168
Date: 2017-04-06 05:53:10+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 2168, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000878
r2   = 0x00000006, r3   = 0xb41374c0
r4   = 0x00000002, r5   = 0xb4137000
r6   = 0xb683109c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f5f708
r10  = 0xb82afa40, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbec51c1c
lr   = 0xb6727f18, pc   = 0xb6726b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:    216660 KB
Buffers:     38676 KB
Cached:     312632 KB
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
PID = 2168 TID = 2168
2168 2170 2228 2229 2237 

Maps Information
af22e000 afa2d000 rw-p [stack:2237]
b0fdc000 b0fed000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0ffd000 b1002000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1404000 b140c000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b141e000 b1c1d000 rw-p [stack:2229]
b1c1d000 b1c1e000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c2e000 b1c42000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c56000 b1c57000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c67000 b1c6a000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c7b000 b1c7c000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c8c000 b1c8e000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c9e000 b1ca0000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1cb0000 b1cc0000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1cd0000 b1cdc000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cee000 b24ed000 rw-p [stack:2228]
b281e000 b2825000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2838000 b283e000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b284e000 b286a000 r-xp /opt/usr/apps/org.example.client/bin/client
b29c3000 b2aa6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2add000 b2b05000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b17000 b3316000 rw-p [stack:2170]
b3316000 b3318000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3328000 b3332000 r-xp /lib/libnss_files-2.20-2014.11.so
b3343000 b334c000 r-xp /lib/libnss_nis-2.20-2014.11.so
b335d000 b336e000 r-xp /lib/libnsl-2.20-2014.11.so
b3381000 b3387000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3398000 b3399000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33c1000 b33c8000 r-xp /usr/lib/libminizip.so.1.0.0
b33d8000 b33dd000 r-xp /usr/lib/libstorage.so.0.1
b33ed000 b344c000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3462000 b3476000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3486000 b34ca000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34da000 b34e2000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34f2000 b3522000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3535000 b35ee000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3602000 b3655000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3666000 b3681000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3691000 b3752000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3765000 b3775000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3785000 b3792000 r-xp /usr/lib/libmdm-common.so.1.0.98
b37a3000 b37aa000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b37ba000 b37fb000 r-xp /usr/lib/libmdm.so.1.2.12
b380b000 b3813000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3822000 b3832000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3853000 b38b3000 r-xp /usr/lib/libasound.so.2.0.0
b38c5000 b38c8000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38d8000 b38db000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38eb000 b38f0000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3900000 b3901000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3911000 b391c000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3930000 b3937000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3947000 b394d000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b395d000 b3962000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3972000 b398d000 r-xp /usr/lib/libmmfsound.so.0.1.0
b399d000 b39a4000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b39b4000 b39b7000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39c8000 b39f6000 r-xp /usr/lib/libidn.so.11.5.44
b3a06000 b3a1c000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a2d000 b3a37000 r-xp /usr/lib/libcares.so.2.1.0
b3a47000 b3a51000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a61000 b3a63000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a73000 b3a74000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a84000 b3a88000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a99000 b3ac1000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ad2000 b3afb000 r-xp /usr/lib/libturbojpeg.so
b3b1b000 b3b21000 r-xp /usr/lib/libgif.so.4.1.6
b3b31000 b3b77000 r-xp /usr/lib/libcurl.so.4.3.0
b3b88000 b3ba9000 r-xp /usr/lib/libexif.so.12.3.3
b3bc4000 b3bd9000 r-xp /usr/lib/libtts.so
b3bea000 b3bf2000 r-xp /usr/lib/libfeedback.so.0.1.4
b3c02000 b3cc8000 r-xp /usr/lib/libdali-core.so.0.0.0
b3ce8000 b3de0000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3dff000 b3ecd000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ee4000 b3ee6000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ef6000 b3efc000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3f0c000 b3f2f000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f40000 b3f42000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f52000 b3f54000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f65000 b3f6a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f81000 b3f83000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f93000 b3f9a000 r-xp /usr/lib/libsensord-share.so
b3faa000 b3fc2000 r-xp /usr/lib/libsensor.so.1.1.0
b3fd3000 b3fd6000 r-xp /usr/lib/libXv.so.1.0.0
b3fe6000 b3feb000 r-xp /usr/lib/libutilX.so.1.1.0
b3ffb000 b4000000 r-xp /usr/lib/libappcore-common.so.1.1
b4010000 b4017000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b402a000 b402e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b403f000 b411d000 r-xp /usr/lib/libCOREGL.so.4.0
b413d000 b4140000 r-xp /usr/lib/libuuid.so.1.3.0
b4150000 b4167000 r-xp /usr/lib/libblkid.so.1.1.0
b4178000 b417a000 r-xp /usr/lib/libXau.so.6.0.0
b418a000 b41d1000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41e3000 b41e9000 r-xp /usr/lib/libjson-c.so.2.0.1
b41fa000 b41fe000 r-xp /usr/lib/libogg.so.0.7.1
b420e000 b4230000 r-xp /usr/lib/libvorbis.so.0.4.3
b4240000 b4324000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4340000 b4343000 r-xp /usr/lib/libEGL.so.1.4
b4354000 b435a000 r-xp /usr/lib/libxcb-render.so.0.0.0
b436a000 b436c000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b437c000 b4389000 r-xp /usr/lib/libGLESv2.so.2.0
b439a000 b43fc000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4411000 b4429000 r-xp /usr/lib/libmount.so.1.1.0
b443b000 b444f000 r-xp /usr/lib/libxcb.so.1.1.0
b445f000 b4466000 r-xp /lib/libcrypt-2.20-2014.11.so
b449e000 b44a0000 r-xp /usr/lib/libiri.so
b44b0000 b44bb000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44cc000 b4502000 r-xp /usr/lib/libpulse.so.0.16.2
b4513000 b4556000 r-xp /usr/lib/libsndfile.so.1.0.25
b456b000 b4580000 r-xp /lib/libexpat.so.1.5.2
b4592000 b4650000 r-xp /usr/lib/libcairo.so.2.11200.14
b4664000 b466c000 r-xp /usr/lib/libdrm.so.2.4.0
b467c000 b467f000 r-xp /usr/lib/libdri2.so.0.0.0
b468f000 b46dd000 r-xp /usr/lib/libssl.so.1.0.0
b46f2000 b46fe000 r-xp /usr/lib/libeeze.so.1.13.0
b470f000 b4718000 r-xp /usr/lib/libethumb.so.1.13.0
b4728000 b472b000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b473b000 b48f2000 r-xp /usr/lib/libcrypto.so.1.0.0
b56dd000 b56e6000 r-xp /usr/lib/libXi.so.6.1.0
b56f6000 b56f8000 r-xp /usr/lib/libXgesture.so.7.0.0
b5708000 b570c000 r-xp /usr/lib/libXtst.so.6.1.0
b571c000 b5722000 r-xp /usr/lib/libXrender.so.1.3.0
b5732000 b5738000 r-xp /usr/lib/libXrandr.so.2.2.0
b5748000 b574a000 r-xp /usr/lib/libXinerama.so.1.0.0
b575b000 b575e000 r-xp /usr/lib/libXfixes.so.3.1.0
b576e000 b5779000 r-xp /usr/lib/libXext.so.6.4.0
b5789000 b578b000 r-xp /usr/lib/libXdamage.so.1.1.0
b579b000 b579d000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57ad000 b588f000 r-xp /usr/lib/libX11.so.6.3.0
b58a3000 b58aa000 r-xp /usr/lib/libXcursor.so.1.0.2
b58ba000 b58d2000 r-xp /usr/lib/libudev.so.1.6.0
b58d4000 b58d7000 r-xp /lib/libattr.so.1.1.0
b58e7000 b5907000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5908000 b590d000 r-xp /usr/lib/libffi.so.6.0.2
b591e000 b5936000 r-xp /lib/libz.so.1.2.8
b5946000 b5948000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5958000 b5a2d000 r-xp /usr/lib/libxml2.so.2.9.2
b5a42000 b5add000 r-xp /usr/lib/libstdc++.so.6.0.20
b5af9000 b5afc000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b0c000 b5b25000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b36000 b5b47000 r-xp /lib/libresolv-2.20-2014.11.so
b5b5b000 b5bd5000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bea000 b5bec000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bfc000 b5c03000 r-xp /usr/lib/libembryo.so.1.13.0
b5c13000 b5c1d000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c2e000 b5c46000 r-xp /usr/lib/libpng12.so.0.50.0
b5c57000 b5c7a000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c9b000 b5caf000 r-xp /usr/lib/libector.so.1.13.0
b5cc0000 b5cd8000 r-xp /usr/lib/liblua-5.1.so
b5ce9000 b5d40000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d54000 b5d7c000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d8d000 b5da0000 r-xp /usr/lib/libfribidi.so.0.3.1
b5db1000 b5deb000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dfc000 b5e0a000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e1a000 b5e22000 r-xp /usr/lib/libtbm.so.1.0.0
b5e32000 b5e3f000 r-xp /usr/lib/libeio.so.1.13.0
b5e4f000 b5e51000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e61000 b5e66000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e76000 b5e8d000 r-xp /usr/lib/libefreet.so.1.13.0
b5e9f000 b5ebf000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ecf000 b5eef000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ef1000 b5ef7000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f07000 b5f18000 r-xp /usr/lib/libemotion.so.1.13.0
b5f29000 b5f30000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f40000 b5f4f000 r-xp /usr/lib/libeo.so.1.13.0
b5f60000 b5f72000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f83000 b5f88000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f98000 b5fb1000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fc1000 b5fde000 r-xp /usr/lib/libeet.so.1.13.0
b5ff7000 b603f000 r-xp /usr/lib/libeina.so.1.13.0
b6050000 b6060000 r-xp /usr/lib/libefl.so.1.13.0
b6071000 b6156000 r-xp /usr/lib/libicuuc.so.51.1
b6173000 b62b3000 r-xp /usr/lib/libicui18n.so.51.1
b62ca000 b6302000 r-xp /usr/lib/libecore_x.so.1.13.0
b6314000 b6317000 r-xp /lib/libcap.so.2.21
b6327000 b6350000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6361000 b6368000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b637a000 b63b1000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63c2000 b64ad000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64c0000 b6539000 r-xp /usr/lib/libsqlite3.so.0.8.6
b654b000 b6550000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6560000 b656a000 r-xp /usr/lib/libvconf.so.0.2.45
b657a000 b657c000 r-xp /usr/lib/libvasum.so.0.3.1
b658c000 b658e000 r-xp /usr/lib/libttrace.so.1.1
b659e000 b65a1000 r-xp /usr/lib/libiniparser.so.0
b65b1000 b65d7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65e7000 b65ec000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65fd000 b6614000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6625000 b6690000 r-xp /lib/libm-2.20-2014.11.so
b66a1000 b66a7000 r-xp /lib/librt-2.20-2014.11.so
b66b8000 b66c5000 r-xp /usr/lib/libunwind.so.8.0.1
b66fb000 b681f000 r-xp /lib/libc-2.20-2014.11.so
b6834000 b684d000 r-xp /lib/libgcc_s-4.9.so.1
b685d000 b693f000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6950000 b697a000 r-xp /usr/lib/libdbus-1.so.3.8.12
b698b000 b69c7000 r-xp /usr/lib/libsystemd.so.0.4.0
b69c9000 b6a4c000 r-xp /usr/lib/libedje.so.1.13.0
b6a5f000 b6a7d000 r-xp /usr/lib/libecore.so.1.13.0
b6a9d000 b6c24000 r-xp /usr/lib/libevas.so.1.13.0
b6c59000 b6c6d000 r-xp /lib/libpthread-2.20-2014.11.so
b6c81000 b6eb5000 r-xp /usr/lib/libelementary.so.1.13.0
b6ee4000 b6ee8000 r-xp /usr/lib/libsmack.so.1.0.0
b6ef8000 b6eff000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f0f000 b6f11000 r-xp /usr/lib/libdlog.so.0.0.0
b6f21000 b6f24000 r-xp /usr/lib/libbundle.so.0.1.22
b6f34000 b6f36000 r-xp /lib/libdl-2.20-2014.11.so
b6f47000 b6f5f000 r-xp /usr/lib/libaul.so.0.1.0
b6f73000 b6f78000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f89000 b6f96000 r-xp /usr/lib/liblptcp.so
b6fa8000 b6fac000 r-xp /usr/lib/libsys-assert.so
b6fbd000 b6fdd000 r-xp /lib/ld-2.20-2014.11.so
b6fee000 b6ff3000 r-xp /usr/bin/launchpad-loader
b7f2c000 b830b000 rw-p [heap]
bec32000 bec53000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2168)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6726b84) [/lib/libc.so.6] + 0x2bb84
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
ugin API called (16) ((- ((- ((- ((- ((- ((- ((- ((- ((- ((-[0m
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
04-06 05:52:56.156+0900 W/CRASH_MANAGER( 2079): worker.c: worker_job(1199) > 0602069636c691491425576
04-06 05:52:56.176+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:52:56.196+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(3)
04-06 05:52:56.196+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:52:56.196+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:52:56.196+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(869)
04-06 05:52:56.196+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: fg
04-06 05:52:56.216+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 2069 pgid = 2069
04-06 05:52:56.216+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(143) > dead_pid(2069)
04-06 05:52:56.226+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(0)
04-06 05:52:56.236+0900 E/EFL     (  663): <663> lib/ecore_ipc/ecore_ipc.c:804 ecore_ipc_client_send() safety check failed: !ecore_con_client_connected_get(cl->client) is true
04-06 05:52:56.256+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: RESUME State: PAUSED
04-06 05:52:56.256+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:52:56.256+0900 E/cluster-home(  869): homescreen.cpp: OnResume(233) >  app resume
04-06 05:52:56.256+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:52:56.266+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 05:52:56.266+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 05:52:56.266+0900 E/AUL_PAD ( 1536): launchpad.c: main(698) > error reading sigchld info
04-06 05:52:56.276+0900 I/ESD     (  901): esd_main.c: __esd_app_dead_handler(1773) > pid: 2069
04-06 05:52:56.276+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 2069
04-06 05:52:56.276+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 2069
04-06 05:52:56.286+0900 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.273
04-06 05:52:56.296+0900 I/Tizen::System( 1248): (259) > Active app [com.samsun], current [org.exampl] 
04-06 05:52:56.296+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 05:52:56.306+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 05:52:56.306+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 05:52:56.306+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: fg
04-06 05:52:56.306+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 05:52:56.306+0900 I/Tizen::App( 1248): (243) > App[org.example.client] pid[2069] terminate event is forwarded
04-06 05:52:56.306+0900 I/Tizen::System( 1248): (256) > osp.accessorymanager.service provider is found.
04-06 05:52:56.306+0900 I/Tizen::System( 1248): (196) > Accessory Owner is removed [org.example.client, 2069, ]
04-06 05:52:56.306+0900 I/Tizen::System( 1248): (256) > osp.system.service provider is found.
04-06 05:52:56.306+0900 I/Tizen::App( 1248): (506) > TerminatedApp(org.example.client)
04-06 05:52:56.306+0900 I/Tizen::App( 1248): (512) > Not registered pid(2069)
04-06 05:52:56.306+0900 I/Tizen::System( 1248): (246) > Terminated app [org.example.client]
04-06 05:52:56.306+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 05:52:56.316+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:56.316+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:56.326+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 05:52:56.326+0900 I/Tizen::App( 1248): (782) > Finished invoking application event listener for org.example.client, 2069.
04-06 05:52:56.336+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 05:52:56.336+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:52:56.346+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 05:52:56.346+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 05:52:56.346+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:52:57.307+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:57.317+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:57.327+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:57.327+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:57.347+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:57.347+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:57.367+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:57.367+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:57.387+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:57.387+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:57.407+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:57.407+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:57.417+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:57.427+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:57.437+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:57.437+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:57.458+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:57.458+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:57.478+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:57.478+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:57.498+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:57.498+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:57.508+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:57.518+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:52:57.528+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-06 05:52:57.528+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-06 05:53:00.450+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-06 05:53:00.460+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 5:53
04-06 05:53:00.460+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 5:53"
04-06 05:53:00.460+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 5:53"
04-06 05:53:00.460+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-06 05:53:00.460+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146876251 Time: <font_size=31> </font_size> <font_size=31> 오전 5:53</font_size></font>"
04-06 05:53:05.395+0900 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=342499
04-06 05:53:05.485+0900 E/EFL     (  869): ecore_x<869> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=342598
04-06 05:53:05.495+0900 W/AUL     (  869): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-06 05:53:05.495+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
04-06 05:53:05.495+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 869
04-06 05:53:05.505+0900 E/RESOURCED(  665): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-06 05:53:05.505+0900 E/RESOURCED(  665): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 05:53:05.505+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 05:53:05.505+0900 W/AUL_PAD ( 1536): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 05:53:05.505+0900 W/AUL_PAD ( 1536): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 05:53:05.525+0900 I/abc     ( 2168): abc
04-06 05:53:05.525+0900 I/CAPI_APPFW_APPLICATION( 2168): app_main.c: ui_app_main(789) > app_efl_main
04-06 05:53:05.525+0900 I/CAPI_APPFW_APPLICATION( 2168): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 05:53:05.545+0900 E/TBM     ( 2168): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:53:05.605+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 2168, appid: org.example.client
04-06 05:53:05.605+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 05:53:05.615+0900 W/AUL     (  869): launch.c: app_request_to_launchpad(425) > request cmd(1) result(2168)
04-06 05:53:05.806+0900 D/basicui ( 2168): successed to load edc file
04-06 05:53:05.836+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:53:05.836+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:53:05.856+0900 I/Tizen::System( 1248): (259) > Active app [org.exampl], current [com.samsun] 
04-06 05:53:05.856+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-06 05:53:05.866+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:53:05.866+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-06 05:53:05.896+0900 I/MY_LOG  ( 2168): change
04-06 05:53:05.946+0900 I/APP_CORE( 2168): appcore-efl.c: __do_app(514) > [APP 2168] Event: RESET State: CREATED
04-06 05:53:05.946+0900 I/CAPI_APPFW_APPLICATION( 2168): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 05:53:05.956+0900 E/EFL     ( 2168): edje<2168> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:53:05.956+0900 E/EFL     ( 2168): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:53:05.966+0900 E/EFL     ( 2168): edje<2168> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:53:05.966+0900 E/EFL     ( 2168): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:53:05.966+0900 E/EFL     ( 2168): edje<2168> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:53:05.966+0900 E/EFL     ( 2168): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:53:05.976+0900 W/APP_CORE( 2168): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6800002
04-06 05:53:05.976+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 05:53:06.006+0900 E/RESOURCED(  665): procfs.c: proc_get_oom_score_adj(131) > fopen /proc/2069/oom_score_adj failed
04-06 05:53:06.086+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: PAUSE State: RUNNING
04-06 05:53:06.086+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:53:06.086+0900 I/APP_CORE( 2168): appcore-efl.c: __do_app(514) > [APP 2168] Event: RESUME State: CREATED
04-06 05:53:06.086+0900 E/cluster-home(  869): homescreen.cpp: OnPause(260) >  app pause
04-06 05:53:06.086+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(4)
04-06 05:53:06.086+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(869)
04-06 05:53:06.086+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: bg
04-06 05:53:06.096+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(2168) status(3)
04-06 05:53:06.096+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(2168)
04-06 05:53:06.096+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 2168, appid: org.example.client, status: fg
04-06 05:53:06.096+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 05:53:06.096+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 05:53:06.096+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: bg
04-06 05:53:06.106+0900 I/APP_CORE( 2168): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:53:06.106+0900 I/APP_CORE( 2168): appcore-efl.c: __do_app(625) > [APP 2168] Initial Launching, call the resume_cb
04-06 05:53:06.106+0900 I/CAPI_APPFW_APPLICATION( 2168): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:53:06.446+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(2168) status(0)
04-06 05:53:06.656+0900 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.274
04-06 05:53:06.666+0900 I/Tizen::App( 1248): (499) > LaunchedApp(org.example.client)
04-06 05:53:06.666+0900 I/Tizen::App( 1248): (733) > Finished invoking application event listener for org.example.client, 2168.
04-06 05:53:07.447+0900 I/UXT     ( 2234): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:53:09.930+0900 E/EFL     ( 2168): ecore_x<2168> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=347041
04-06 05:53:09.930+0900 I/MY_LOG  ( 2168): Button pressed
04-06 05:53:10.020+0900 E/EFL     ( 2168): ecore_x<2168> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=347130
04-06 05:53:10.030+0900 E/VCONF   ( 2168): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 05:53:10.030+0900 E/VCONF   ( 2168): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 05:53:10.030+0900 E/VCONF   ( 2168): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 05:53:10.030+0900 E/VCONF   ( 2168): vconf.c: vconf_get_bool(2729) > vconf_get_bool(2168) : db/ise/keysound error
04-06 05:53:10.030+0900 E/VCONF   ( 2168): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 05:53:10.030+0900 E/VCONF   ( 2168): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 05:53:10.090+0900 I/MY_LOG  ( 2168): Button unpressed
04-06 05:53:10.230+0900 W/CRASH_MANAGER( 2079): worker.c: worker_job(1199) > 0602168636c69149142559
