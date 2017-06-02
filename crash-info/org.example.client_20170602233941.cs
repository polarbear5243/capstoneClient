S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 24306
Date: 2017-06-02 23:39:41+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 24306, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00005ef2
r2   = 0x00000006, r3   = 0xb412e4c0
r4   = 0x00000002, r5   = 0xb412e000
r6   = 0xb682809c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f56708
r10  = 0xb9040088, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbefa8c24
lr   = 0xb671ef18, pc   = 0xb671db84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     49476 KB
Buffers:     83640 KB
Cached:     272308 KB
VmPeak:     135268 KB
VmSize:     133948 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28884 KB
VmRSS:       28168 KB
VmData:      46032 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35776 KB
VmPTE:          98 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 24306 TID = 24306
24306 24307 24582 24583 24591 

Maps Information
af22e000 afa2d000 rw-p [stack:24591]
b13e6000 b13ee000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1400000 b1bff000 rw-p [stack:24583]
b1bff000 b1c00000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c10000 b1c24000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c38000 b1c39000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c49000 b1c4c000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c5d000 b1c5e000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c6e000 b1c70000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c80000 b1c82000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c92000 b1ca2000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1cb2000 b1cbe000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cd0000 b24cf000 rw-p [stack:24582]
b2800000 b2807000 r-xp /usr/lib/libefl-extension.so.0.1.0
b281a000 b2820000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2830000 b2861000 r-xp /opt/usr/apps/org.example.client/bin/client
b29ba000 b2a9d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ad4000 b2afc000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b0e000 b330d000 rw-p [stack:24307]
b330d000 b330f000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b331f000 b3329000 r-xp /lib/libnss_files-2.20-2014.11.so
b333a000 b3343000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3354000 b3365000 r-xp /lib/libnsl-2.20-2014.11.so
b3378000 b337e000 r-xp /lib/libnss_compat-2.20-2014.11.so
b338f000 b3390000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33b8000 b33bf000 r-xp /usr/lib/libminizip.so.1.0.0
b33cf000 b33d4000 r-xp /usr/lib/libstorage.so.0.1
b33e4000 b3443000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3459000 b346d000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b347d000 b34c1000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34d1000 b34d9000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34e9000 b3519000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b352c000 b35e5000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35f9000 b364c000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b365d000 b3678000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3688000 b3749000 r-xp /usr/lib/libprotobuf.so.9.0.1
b375c000 b376c000 r-xp /usr/lib/libefl-assist.so.0.1.0
b377c000 b3789000 r-xp /usr/lib/libmdm-common.so.1.0.98
b379a000 b37a1000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b37b1000 b37f2000 r-xp /usr/lib/libmdm.so.1.2.12
b3802000 b380a000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3819000 b3829000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b384a000 b38aa000 r-xp /usr/lib/libasound.so.2.0.0
b38bc000 b38bf000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38cf000 b38d2000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38e2000 b38e7000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38f7000 b38f8000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3908000 b3913000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3927000 b392e000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b393e000 b3944000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3954000 b3959000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3969000 b3984000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3994000 b399b000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b39ab000 b39ae000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39bf000 b39ed000 r-xp /usr/lib/libidn.so.11.5.44
b39fd000 b3a13000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a24000 b3a2e000 r-xp /usr/lib/libcares.so.2.1.0
b3a3e000 b3a48000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a58000 b3a5a000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a6a000 b3a6b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a7b000 b3a7f000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a90000 b3ab8000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ac9000 b3af2000 r-xp /usr/lib/libturbojpeg.so
b3b12000 b3b18000 r-xp /usr/lib/libgif.so.4.1.6
b3b28000 b3b6e000 r-xp /usr/lib/libcurl.so.4.3.0
b3b7f000 b3ba0000 r-xp /usr/lib/libexif.so.12.3.3
b3bbb000 b3bd0000 r-xp /usr/lib/libtts.so
b3be1000 b3be9000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bf9000 b3cbf000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cdf000 b3dd7000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3df6000 b3ec4000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3edb000 b3edd000 r-xp /usr/lib/libboost_system.so.1.51.0
b3eed000 b3ef3000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3f03000 b3f26000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f37000 b3f39000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f49000 b3f4b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f5c000 b3f61000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f78000 b3f7a000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f8a000 b3f91000 r-xp /usr/lib/libsensord-share.so
b3fa1000 b3fb9000 r-xp /usr/lib/libsensor.so.1.1.0
b3fca000 b3fcd000 r-xp /usr/lib/libXv.so.1.0.0
b3fdd000 b3fe2000 r-xp /usr/lib/libutilX.so.1.1.0
b3ff2000 b3ff7000 r-xp /usr/lib/libappcore-common.so.1.1
b4007000 b400e000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b4021000 b4025000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4036000 b4114000 r-xp /usr/lib/libCOREGL.so.4.0
b4134000 b4137000 r-xp /usr/lib/libuuid.so.1.3.0
b4147000 b415e000 r-xp /usr/lib/libblkid.so.1.1.0
b416f000 b4171000 r-xp /usr/lib/libXau.so.6.0.0
b4181000 b41c8000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41da000 b41e0000 r-xp /usr/lib/libjson-c.so.2.0.1
b41f1000 b41f5000 r-xp /usr/lib/libogg.so.0.7.1
b4205000 b4227000 r-xp /usr/lib/libvorbis.so.0.4.3
b4237000 b431b000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4337000 b433a000 r-xp /usr/lib/libEGL.so.1.4
b434b000 b4351000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4361000 b4363000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4373000 b4380000 r-xp /usr/lib/libGLESv2.so.2.0
b4391000 b43f3000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4408000 b4420000 r-xp /usr/lib/libmount.so.1.1.0
b4432000 b4446000 r-xp /usr/lib/libxcb.so.1.1.0
b4456000 b445d000 r-xp /lib/libcrypt-2.20-2014.11.so
b4495000 b4497000 r-xp /usr/lib/libiri.so
b44a7000 b44b2000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44c3000 b44f9000 r-xp /usr/lib/libpulse.so.0.16.2
b450a000 b454d000 r-xp /usr/lib/libsndfile.so.1.0.25
b4562000 b4577000 r-xp /lib/libexpat.so.1.5.2
b4589000 b4647000 r-xp /usr/lib/libcairo.so.2.11200.14
b465b000 b4663000 r-xp /usr/lib/libdrm.so.2.4.0
b4673000 b4676000 r-xp /usr/lib/libdri2.so.0.0.0
b4686000 b46d4000 r-xp /usr/lib/libssl.so.1.0.0
b46e9000 b46f5000 r-xp /usr/lib/libeeze.so.1.13.0
b4706000 b470f000 r-xp /usr/lib/libethumb.so.1.13.0
b471f000 b4722000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4732000 b48e9000 r-xp /usr/lib/libcrypto.so.1.0.0
b56d4000 b56dd000 r-xp /usr/lib/libXi.so.6.1.0
b56ed000 b56ef000 r-xp /usr/lib/libXgesture.so.7.0.0
b56ff000 b5703000 r-xp /usr/lib/libXtst.so.6.1.0
b5713000 b5719000 r-xp /usr/lib/libXrender.so.1.3.0
b5729000 b572f000 r-xp /usr/lib/libXrandr.so.2.2.0
b573f000 b5741000 r-xp /usr/lib/libXinerama.so.1.0.0
b5752000 b5755000 r-xp /usr/lib/libXfixes.so.3.1.0
b5765000 b5770000 r-xp /usr/lib/libXext.so.6.4.0
b5780000 b5782000 r-xp /usr/lib/libXdamage.so.1.1.0
b5792000 b5794000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57a4000 b5886000 r-xp /usr/lib/libX11.so.6.3.0
b589a000 b58a1000 r-xp /usr/lib/libXcursor.so.1.0.2
b58b1000 b58c9000 r-xp /usr/lib/libudev.so.1.6.0
b58cb000 b58ce000 r-xp /lib/libattr.so.1.1.0
b58de000 b58fe000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58ff000 b5904000 r-xp /usr/lib/libffi.so.6.0.2
b5915000 b592d000 r-xp /lib/libz.so.1.2.8
b593d000 b593f000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b594f000 b5a24000 r-xp /usr/lib/libxml2.so.2.9.2
b5a39000 b5ad4000 r-xp /usr/lib/libstdc++.so.6.0.20
b5af0000 b5af3000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b03000 b5b1c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b2d000 b5b3e000 r-xp /lib/libresolv-2.20-2014.11.so
b5b52000 b5bcc000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5be1000 b5be3000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bf3000 b5bfa000 r-xp /usr/lib/libembryo.so.1.13.0
b5c0a000 b5c14000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c25000 b5c3d000 r-xp /usr/lib/libpng12.so.0.50.0
b5c4e000 b5c71000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c92000 b5ca6000 r-xp /usr/lib/libector.so.1.13.0
b5cb7000 b5ccf000 r-xp /usr/lib/liblua-5.1.so
b5ce0000 b5d37000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d4b000 b5d73000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d84000 b5d97000 r-xp /usr/lib/libfribidi.so.0.3.1
b5da8000 b5de2000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5df3000 b5e01000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e11000 b5e19000 r-xp /usr/lib/libtbm.so.1.0.0
b5e29000 b5e36000 r-xp /usr/lib/libeio.so.1.13.0
b5e46000 b5e48000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e58000 b5e5d000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e6d000 b5e84000 r-xp /usr/lib/libefreet.so.1.13.0
b5e96000 b5eb6000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ec6000 b5ee6000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ee8000 b5eee000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5efe000 b5f0f000 r-xp /usr/lib/libemotion.so.1.13.0
b5f20000 b5f27000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f37000 b5f46000 r-xp /usr/lib/libeo.so.1.13.0
b5f57000 b5f69000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f7a000 b5f7f000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f8f000 b5fa8000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fb8000 b5fd5000 r-xp /usr/lib/libeet.so.1.13.0
b5fee000 b6036000 r-xp /usr/lib/libeina.so.1.13.0
b6047000 b6057000 r-xp /usr/lib/libefl.so.1.13.0
b6068000 b614d000 r-xp /usr/lib/libicuuc.so.51.1
b616a000 b62aa000 r-xp /usr/lib/libicui18n.so.51.1
b62c1000 b62f9000 r-xp /usr/lib/libecore_x.so.1.13.0
b630b000 b630e000 r-xp /lib/libcap.so.2.21
b631e000 b6347000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6358000 b635f000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6371000 b63a8000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63b9000 b64a4000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64b7000 b6530000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6542000 b6547000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6557000 b6561000 r-xp /usr/lib/libvconf.so.0.2.45
b6571000 b6573000 r-xp /usr/lib/libvasum.so.0.3.1
b6583000 b6585000 r-xp /usr/lib/libttrace.so.1.1
b6595000 b6598000 r-xp /usr/lib/libiniparser.so.0
b65a8000 b65ce000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65de000 b65e3000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65f4000 b660b000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b661c000 b6687000 r-xp /lib/libm-2.20-2014.11.so
b6698000 b669e000 r-xp /lib/librt-2.20-2014.11.so
b66af000 b66bc000 r-xp /usr/lib/libunwind.so.8.0.1
b66f2000 b6816000 r-xp /lib/libc-2.20-2014.11.so
b682b000 b6844000 r-xp /lib/libgcc_s-4.9.so.1
b6854000 b6936000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6947000 b6971000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6982000 b69be000 r-xp /usr/lib/libsystemd.so.0.4.0
b69c0000 b6a43000 r-xp /usr/lib/libedje.so.1.13.0
b6a56000 b6a74000 r-xp /usr/lib/libecore.so.1.13.0
b6a94000 b6c1b000 r-xp /usr/lib/libevas.so.1.13.0
b6c50000 b6c64000 r-xp /lib/libpthread-2.20-2014.11.so
b6c78000 b6eac000 r-xp /usr/lib/libelementary.so.1.13.0
b6edb000 b6edf000 r-xp /usr/lib/libsmack.so.1.0.0
b6eef000 b6ef6000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f06000 b6f08000 r-xp /usr/lib/libdlog.so.0.0.0
b6f18000 b6f1b000 r-xp /usr/lib/libbundle.so.0.1.22
b6f2b000 b6f2d000 r-xp /lib/libdl-2.20-2014.11.so
b6f3e000 b6f56000 r-xp /usr/lib/libaul.so.0.1.0
b6f6a000 b6f6f000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f80000 b6f8d000 r-xp /usr/lib/liblptcp.so
b6f9f000 b6fa3000 r-xp /usr/lib/libsys-assert.so
b6fb4000 b6fd4000 r-xp /lib/ld-2.20-2014.11.so
b6fe5000 b6fea000 r-xp /usr/bin/launchpad-loader
b8c3d000 b9061000 rw-p [heap]
bef89000 befaa000 rw-p [stack]
End of Maps Information

Callstack Information (PID:24306)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb671db84) [/lib/libc.so.6] + 0x2bb84
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
+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.141+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
06-02 23:37:46.141+0900 I/Tizen::App( 1233): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
06-02 23:37:46.141+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
06-02 23:37:46.141+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-02 23:37:46.141+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-02 23:37:46.141+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
06-02 23:37:46.141+0900 E/PKGMGR_SERVER(24185): pkgmgr-server.c: sighandler(417) > child NORMAL exit [24239]
06-02 23:37:46.151+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
06-02 23:37:46.151+0900 E/HOME_APPS(  867): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
06-02 23:37:46.151+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
06-02 23:37:46.151+0900 I/Tizen::App( 1233): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
06-02 23:37:46.151+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
06-02 23:37:46.171+0900 I/Tizen::App( 1233): (416) > appName = [client]
06-02 23:37:46.171+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-02 23:37:46.171+0900 E/PKGMGR_INFO( 1233): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-02 23:37:46.171+0900 I/Tizen::App( 1233): (683) > Application count(1) in this package
06-02 23:37:46.171+0900 I/Tizen::App( 1233): (840) > Enter.
06-02 23:37:46.171+0900 I/Tizen::App( 1233): (703) > Exit.
06-02 23:37:46.171+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
06-02 23:37:46.171+0900 E/util-view(  867): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-02 23:37:46.181+0900 I/Tizen::App( 1233): (416) > appName = [client]
06-02 23:37:46.181+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-02 23:37:46.181+0900 I/Tizen::App( 1233): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
06-02 23:37:46.181+0900 I/Tizen::App( 1233): (131) > Enter
06-02 23:37:46.181+0900 I/Tizen::App( 1233): (137) > org.example.client does not have launch condition
06-02 23:37:46.181+0900 I/Tizen::App( 1233): (883) > Exit.
06-02 23:37:46.191+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-02 23:37:47.843+0900 E/PKGMGR_SERVER(24185): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-02 23:37:47.843+0900 E/PKGMGR_SERVER(24185): pkgmgr-server.c: main(2471) > package manager server terminated.
06-02 23:37:50.255+0900 W/AUL     (24293): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-02 23:37:50.255+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
06-02 23:37:50.265+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-02 23:37:50.275+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-02 23:37:50.275+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-02 23:37:50.275+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 24293
06-02 23:37:50.275+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-02 23:37:50.285+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 4
06-02 23:37:50.285+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-02 23:37:50.285+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
06-02 23:37:50.285+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-02 23:37:50.285+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
06-02 23:37:50.305+0900 I/abc     (23171): abc
06-02 23:37:50.305+0900 I/CAPI_APPFW_APPLICATION(23171): app_main.c: ui_app_main(789) > app_efl_main
06-02 23:37:50.305+0900 I/CAPI_APPFW_APPLICATION(23171): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-02 23:37:50.335+0900 E/TBM     (23171): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-02 23:37:50.385+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 23171, appid: org.example.client
06-02 23:37:50.385+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-02 23:37:50.405+0900 W/AUL     (24293): launch.c: app_request_to_launchpad(425) > request cmd(0) result(23171)
06-02 23:37:50.635+0900 I/APP_CORE(23171): appcore-efl.c: __do_app(514) > [APP 23171] Event: RESET State: CREATED
06-02 23:37:50.635+0900 I/CAPI_APPFW_APPLICATION(23171): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-02 23:37:50.655+0900 E/EFL     (23171): edje<23171> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 23:37:50.655+0900 E/EFL     (23171): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 23:37:50.665+0900 E/EFL     (23171): edje<23171> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 23:37:50.665+0900 E/EFL     (23171): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 23:37:50.665+0900 E/EFL     (23171): edje<23171> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 23:37:50.665+0900 E/EFL     (23171): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 23:37:50.675+0900 W/APP_CORE(23171): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800002
06-02 23:37:50.675+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 23:37:50.675+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 23:37:50.675+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-02 23:37:50.686+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
06-02 23:37:50.686+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 23:37:50.696+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 23:37:50.696+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 23:37:50.796+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-02 23:37:50.796+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-02 23:37:50.796+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-02 23:37:50.796+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-02 23:37:50.796+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-02 23:37:50.796+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-02 23:37:50.796+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(23171) status(3)
06-02 23:37:50.806+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 23:37:50.806+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 23:37:50.806+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(23171)
06-02 23:37:50.806+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 23171, appid: org.example.client, status: fg
06-02 23:37:50.806+0900 I/APP_CORE(23171): appcore-efl.c: __do_app(514) > [APP 23171] Event: RESUME State: CREATED
06-02 23:37:50.816+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-02 23:37:50.816+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-02 23:37:50.816+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-02 23:37:50.816+0900 I/APP_CORE(23171): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-02 23:37:50.816+0900 I/APP_CORE(23171): appcore-efl.c: __do_app(625) > [APP 23171] Initial Launching, call the resume_cb
06-02 23:37:50.816+0900 I/CAPI_APPFW_APPLICATION(23171): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 23:37:51.166+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(23171) status(0)
06-02 23:37:51.436+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
06-02 23:37:51.436+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 23171.
06-02 23:37:51.456+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2746
06-02 23:37:52.017+0900 E/EFL     (23171): ecore_x<23171> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=962869186
06-02 23:37:52.117+0900 E/EFL     (23171): ecore_x<23171> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=962869285
06-02 23:37:52.237+0900 I/UXT     (24306): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-02 23:37:52.407+0900 E/EFL     (23171): ecore_x<23171> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=962869575
06-02 23:37:52.407+0900 I/MY_LOG  (23171): Button pressed
06-02 23:37:52.507+0900 E/EFL     (23171): ecore_x<23171> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=962869663
06-02 23:37:52.507+0900 E/VCONF   (23171): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-02 23:37:52.507+0900 E/VCONF   (23171): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-02 23:37:52.507+0900 E/VCONF   (23171): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-02 23:37:52.507+0900 E/VCONF   (23171): vconf.c: vconf_get_bool(2729) > vconf_get_bool(23171) : db/ise/keysound error
06-02 23:37:52.507+0900 E/VCONF   (23171): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-02 23:37:52.507+0900 E/VCONF   (23171): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-02 23:37:52.567+0900 I/MY_LOG  (23171): Button unpressed
06-02 23:37:53.668+0900 E/EFL     (23171): ecore_x<23171> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=962870830
06-02 23:37:53.668+0900 I/MY_LOG  (23171): Button pressed
06-02 23:37:53.769+0900 E/EFL     (23171): ecore_x<23171> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=962870929
06-02 23:37:53.769+0900 I/MY_LOG  (23171): Button unpressed
06-02 23:37:53.809+0900 D/basicui (23171): successed to load edc file
06-02 23:37:53.829+0900 E/EFL     (23171): elementary<23171> elm_layout.c:991 _elm_layout_elm_container_content_set() could not swallow 0x8007bfe1 into part 'swallow_content'
06-02 23:37:55.750+0900 E/EFL     (23171): ecore_x<23171> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=962872909
06-02 23:37:55.750+0900 I/MY_LOG  (23171): Button pressed
06-02 23:37:55.811+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-02 23:37:55.831+0900 E/EFL     (23171): ecore_x<23171> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=962872997
06-02 23:37:55.841+0900 I/MY_LOG  (23171): Button unpressed
06-02 23:37:55.981+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 23171 pgid = 23171
06-02 23:37:55.981+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(23171)
06-02 23:37:55.991+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 23:37:56.001+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-02 23:37:56.001+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 23:37:56.001+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 23:37:56.001+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-02 23:37:56.001+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-02 23:37:56.051+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-02 23:37:56.051+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-02 23:37:56.051+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
06-02 23:37:56.051+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[23171] terminate event is forwarded
06-02 23:37:56.051+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
06-02 23:37:56.051+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 23171, ]
06-02 23:37:56.051+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
06-02 23:37:56.051+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
06-02 23:37:56.051+0900 I/Tizen::App( 1233): (512) > Not registered pid(23171)
06-02 23:37:56.051+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
06-02 23:37:56.051+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 23:37:56.051+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 23171
06-02 23:37:56.061+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 23171
06-02 23:37:56.061+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 23171
06-02 23:37:56.061+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2750
06-02 23:37:56.071+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-02 23:37:56.081+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-02 23:37:56.081+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 23:37:56.081+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-02 23:37:56.081+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 23:37:56.081+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.example.client, 23171.
06-02 23:37:56.081+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 23:37:56.121+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-02 23:37:56.131+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
06-02 23:37:56.131+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 23:37:56.151+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
06-02 23:37:56.171+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-02 23:37:56.171+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 23:37:56.181+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-02 23:37:56.181+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 23:37:56.181+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 23:37:56.191+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 23:37:56.201+0900 W/CRASH_MANAGER(24312): worker.c: worker_job(1199) > 0623171636c691496414275
06-02 23:37:56.201+0900 E/weather-common( 1310): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
06-02 23:37:56.241+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_create(409) > New handle created[0xb829d800]
06-02 23:37:56.241+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_get_type(463) > Connected Network = 2
06-02 23:37:56.241+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_destroy(427) > Destroy handle: 0xb829d800
06-02 23:37:56.241+0900 E/weather-common( 1310): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
06-02 23:37:56.241+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
06-02 23:37:56.241+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-02 23:37:56.241+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-02 23:37:56.241+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: fg
06-02 23:38:00.155+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-02 23:38:00.155+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 11:38
06-02 23:38:00.155+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 11:38"
06-02 23:38:00.155+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 11:38"
06-02 23:38:00.155+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-02 23:38:00.155+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146679354 Time: <font_size=31> </font_size> <font_size=31> 오후 11:38</font_size></font>"
06-02 23:38:27.091+0900 E/PKGMGR_SERVER(24402): pkgmgr-server.c: main(2414) > package manager server start
06-02 23:38:27.141+0900 E/PKGMGR  (24400): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
06-02 23:38:27.181+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 14
06-02 23:38:27.181+0900 W/AUL_AMD (  612): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-02 23:38:27.191+0900 E/PKGMGR_SERVER(24402): pkgmgr-server.c: sighandler(417) > child NORMAL exit [24405]
06-02 23:38:29.583+0900 W/AUL     (24457): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-02 23:38:29.593+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
06-02 23:38:29.593+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-02 23:38:29.603+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-02 23:38:29.603+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-02 23:38:29.603+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 24457
06-02 23:38:29.603+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-02 23:38:29.613+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 4
06-02 23:38:29.613+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-02 23:38:29.613+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-4)
06-02 23:38:29.734+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 24459, appid: org.example.client
06-02 23:38:29.734+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-02 23:38:29.744+0900 W/AUL     (24457): launch.c: app_request_to_launchpad(425) > request cmd(0) result(24459)
06-02 23:38:29.844+0900 E/PKGMGR_SERVER(24402): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-02 23:38:29.844+0900 E/PKGMGR_SERVER(24402): pkgmgr-server.c: main(2471) > package manager server terminated.
06-02 23:38:30.725+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 23:38:30.725+0900 W/AUL_AMD (  612): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-02 23:38:34.298+0900 I/abc     (24459): abc
06-02 23:38:34.308+0900 I/CAPI_APPFW_APPLICATION(24459): app_main.c: ui_app_main(789) > app_efl_main
06-02 23:38:34.738+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(24459)
06-02 23:38:34.738+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 24459, appid: org.example.client, status: bg
06-02 23:38:35.509+0900 I/CAPI_APPFW_APPLICATION(24459): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-02 23:38:37.811+0900 E/TBM     (24459): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-02 23:38:38.953+0900 I/APP_CORE(24459): appcore-efl.c: __do_app(514) > [APP 24459] Event: RESET State: CREATED
06-02 23:38:38.953+0900 I/CAPI_APPFW_APPLICATION(24459): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-02 23:38:38.983+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 23:38:38.983+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 23:38:38.983+0900 W/APP_CORE(24459): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800002
06-02 23:38:38.983+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-02 23:38:39.003+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
06-02 23:38:39.003+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 23:38:39.003+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 23:38:39.013+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 23:38:39.243+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-02 23:38:39.243+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-02 23:38:39.243+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-02 23:38:39.243+0900 I/APP_CORE(24459): appcore-efl.c: __do_app(514) > [APP 24459] Event: RESUME State: CREATED
06-02 23:38:39.243+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-02 23:38:39.243+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-02 23:38:39.243+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-02 23:38:39.263+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(24459) status(3)
06-02 23:38:39.263+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 23:38:39.263+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 23:38:39.263+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(24459)
06-02 23:38:39.263+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 24459, appid: org.example.client, status: fg
06-02 23:38:39.263+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-02 23:38:39.263+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-02 23:38:39.263+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-02 23:38:39.273+0900 I/APP_CORE(24459): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-02 23:38:39.273+0900 I/APP_CORE(24459): appcore-efl.c: __do_app(625) > [APP 24459] Initial Launching, call the resume_cb
06-02 23:38:39.273+0900 I/CAPI_APPFW_APPLICATION(24459): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 23:38:39.613+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(24459) status(0)
06-02 23:38:41.435+0900 I/MY_LOG  (24459): Button pressed
06-02 23:38:41.565+0900 E/VCONF   (24459): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-02 23:38:41.565+0900 E/VCONF   (24459): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-02 23:38:41.565+0900 E/VCONF   (24459): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-02 23:38:41.565+0900 E/VCONF   (24459): vconf.c: vconf_get_bool(2729) > vconf_get_bool(24459) : db/ise/keysound error
06-02 23:38:41.565+0900 E/VCONF   (24459): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-02 23:38:41.565+0900 E/VCONF   (24459): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-02 23:38:41.615+0900 I/MY_LOG  (24459): Button unpressed
06-02 23:38:42.846+0900 I/MY_LOG  (24459): Button pressed
06-02 23:38:42.977+0900 I/MY_LOG  (24459): Button unpressed
06-02 23:38:43.017+0900 D/basicui (24459): successed to load edc file
06-02 23:38:44.248+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-02 23:38:44.348+0900 I/MY_LOG  (24459): Button pressed
06-02 23:38:44.448+0900 I/MY_LOG  (24459): Button unpressed
06-02 23:39:00.163+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-02 23:39:00.163+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 11:39
06-02 23:39:00.163+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 11:39"
06-02 23:39:00.163+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 11:39"
06-02 23:39:00.163+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-02 23:39:00.163+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146712605 Time: <font_size=31> </font_size> <font_size=31> 오후 11:39</font_size></font>"
06-02 23:39:27.370+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 23:39:27.380+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-02 23:39:27.380+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 23:39:27.380+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 23:39:27.380+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-02 23:39:27.380+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-02 23:39:27.430+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 23:39:27.450+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-02 23:39:27.450+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 23:39:27.450+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-02 23:39:27.460+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-02 23:39:27.460+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-02 23:39:27.460+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 23:39:27.470+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-02 23:39:27.480+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-02 23:39:27.480+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 23:39:27.480+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 23:39:27.490+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
06-02 23:39:27.510+0900 E/weather-common( 1310): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
06-02 23:39:27.510+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
06-02 23:39:27.510+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 23:39:27.530+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_create(409) > New handle created[0xb7fa4670]
06-02 23:39:27.530+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_get_type(463) > Connected Network = 2
06-02 23:39:27.530+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_destroy(427) > Destroy handle: 0xb7fa4670
06-02 23:39:27.530+0900 E/weather-common( 1310): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
06-02 23:39:27.530+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
06-02 23:39:27.530+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-02 23:39:27.530+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-02 23:39:27.530+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: fg
06-02 23:39:27.540+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 23:39:32.595+0900 E/PKGMGR_SERVER(24521): pkgmgr-server.c: main(2414) > package manager server start
06-02 23:39:32.655+0900 E/PKGMGR  (24519): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
06-02 23:39:32.685+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 14
06-02 23:39:32.685+0900 E/AUL_AMD (  612): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 24459
06-02 23:39:32.695+0900 W/AUL_AMD (  612): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-02 23:39:32.705+0900 E/PKGMGR_SERVER(24521): pkgmgr-server.c: sighandler(417) > child NORMAL exit [24524]
06-02 23:39:34.837+0900 E/PKGMGR_SERVER(24521): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-02 23:39:34.837+0900 E/PKGMGR_SERVER(24521): pkgmgr-server.c: main(2471) > package manager server terminated.
06-02 23:39:35.007+0900 W/AUL     (24575): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-02 23:39:35.007+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
06-02 23:39:35.017+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-02 23:39:35.027+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-02 23:39:35.027+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-02 23:39:35.027+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 24575
06-02 23:39:35.027+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-02 23:39:35.037+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 4
06-02 23:39:35.037+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-02 23:39:35.037+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
06-02 23:39:35.037+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-02 23:39:35.037+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
06-02 23:39:35.047+0900 I/abc     (24306): abc
06-02 23:39:35.057+0900 I/CAPI_APPFW_APPLICATION(24306): app_main.c: ui_app_main(789) > app_efl_main
06-02 23:39:35.057+0900 I/CAPI_APPFW_APPLICATION(24306): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-02 23:39:35.087+0900 E/TBM     (24306): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-02 23:39:35.137+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 24306, appid: org.example.client
06-02 23:39:35.137+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-02 23:39:35.147+0900 W/AUL     (24575): launch.c: app_request_to_launchpad(425) > request cmd(0) result(24306)
06-02 23:39:35.358+0900 I/APP_CORE(24306): appcore-efl.c: __do_app(514) > [APP 24306] Event: RESET State: CREATED
06-02 23:39:35.358+0900 I/CAPI_APPFW_APPLICATION(24306): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-02 23:39:35.368+0900 E/EFL     (24306): edje<24306> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 23:39:35.368+0900 E/EFL     (24306): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 23:39:35.378+0900 E/EFL     (24306): edje<24306> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 23:39:35.378+0900 E/EFL     (24306): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 23:39:35.378+0900 E/EFL     (24306): edje<24306> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 23:39:35.378+0900 E/EFL     (24306): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 23:39:35.388+0900 W/APP_CORE(24306): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3600002
06-02 23:39:35.388+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 23:39:35.388+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 23:39:35.388+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-02 23:39:35.408+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
06-02 23:39:35.408+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 23:39:35.408+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 23:39:35.418+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 23:39:35.498+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-02 23:39:35.498+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-02 23:39:35.498+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-02 23:39:35.498+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-02 23:39:35.498+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-02 23:39:35.498+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-02 23:39:35.508+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(24306) status(3)
06-02 23:39:35.508+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 23:39:35.508+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 23:39:35.508+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(24306)
06-02 23:39:35.508+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 24306, appid: org.example.client, status: fg
06-02 23:39:35.508+0900 I/APP_CORE(24306): appcore-efl.c: __do_app(514) > [APP 24306] Event: RESUME State: CREATED
06-02 23:39:35.518+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-02 23:39:35.518+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-02 23:39:35.518+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-02 23:39:35.528+0900 I/APP_CORE(24306): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-02 23:39:35.528+0900 I/APP_CORE(24306): appcore-efl.c: __do_app(625) > [APP 24306] Initial Launching, call the resume_cb
06-02 23:39:35.528+0900 I/CAPI_APPFW_APPLICATION(24306): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 23:39:35.868+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(24306) status(0)
06-02 23:39:36.188+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
06-02 23:39:36.188+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 24306.
06-02 23:39:36.198+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2760
06-02 23:39:36.959+0900 I/UXT     (24588): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-02 23:39:39.011+0900 E/EFL     (24306): ecore_x<24306> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=962976170
06-02 23:39:39.011+0900 I/MY_LOG  (24306): Button pressed
06-02 23:39:39.091+0900 E/EFL     (24306): ecore_x<24306> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=962976247
06-02 23:39:39.091+0900 E/VCONF   (24306): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-02 23:39:39.091+0900 E/VCONF   (24306): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-02 23:39:39.091+0900 E/VCONF   (24306): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-02 23:39:39.091+0900 E/VCONF   (24306): vconf.c: vconf_get_bool(2729) > vconf_get_bool(24306) : db/ise/keysound error
06-02 23:39:39.091+0900 E/VCONF   (24306): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-02 23:39:39.091+0900 E/VCONF   (24306): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-02 23:39:39.151+0900 I/MY_LOG  (24306): Button unpressed
06-02 23:39:40.092+0900 E/EFL     (24306): ecore_x<24306> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=962977247
06-02 23:39:40.092+0900 I/MY_LOG  (24306): Button pressed
06-02 23:39:40.142+0900 E/EFL     (24306): ecore_x<24306> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=962977302
06-02 23:39:40.142+0900 I/MY_LOG  (24306): Button unpressed
06-02 23:39:40.192+0900 D/basicui (24306): successed to load edc file
06-02 23:39:40.212+0900 E/EFL     (24306): elementary<24306> elm_layout.c:991 _elm_layout_elm_container_content_set() could not swallow 0x8007afd9 into part 'swallow_content'
06-02 23:39:40.513+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-02 23:39:41.594+0900 E/EFL     (24306): ecore_x<24306> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=962978754
06-02 23:39:41.594+0900 I/MY_LOG  (24306): Button pressed
06-02 23:39:41.674+0900 E/EFL     (24306): ecore_x<24306> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=962978831
06-02 23:39:41.674+0900 I/MY_LOG  (24306): Button unpressed
06-02 23:39:41.834+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 23:39:41.844+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-02 23:39:41.844+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 23:39:41.844+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 23:39:41.844+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-02 23:39:41.844+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-02 23:39:41.844+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 24306 pgid = 24306
06-02 23:39:41.844+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(24306)
06-02 23:39:41.884+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-02 23:39:41.914+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-02 23:39:41.914+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-02 23:39:41.914+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
06-02 23:39:41.914+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-02 23:39:41.914+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 23:39:41.914+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-02 23:39:41.914+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 23:39:41.914+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[24306] terminate event is forwarded
06-02 23:39:41.914+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
06-02 23:39:41.914+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 24306, ]
06-02 23:39:41.914+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
06-02 23:39:41.914+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
06-02 23:39:41.914+0900 I/Tizen::App( 1233): (512) > Not registered pid(24306)
06-02 23:39:41.914+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
06-02 23:39:41.914+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 23:39:41.914+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 24306
06-02 23:39:41.924+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 24306
06-02 23:39:41.924+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 24306
06-02 23:39:41.924+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2764
06-02 23:39:41.944+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 23:39:41.944+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.example.client, 24306.
06-02 23:39:41.954+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-02 23:39:41.954+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 23:39:41.954+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-02 23:39:41.954+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-02 23:39:41.954+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 23:39:41.974+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 23:39:41.984+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
06-02 23:39:41.984+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 23:39:42.004+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
06-02 23:39:42.034+0900 E/weather-common( 1310): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
06-02 23:39:42.034+0900 W/CRASH_MANAGER(24593): worker.c: worker_job(1199) > 0624306636c69149641438
