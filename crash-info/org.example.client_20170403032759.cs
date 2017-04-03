S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 2112
Date: 2017-04-03 03:27:59+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 2112, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000840
r2   = 0x00000006, r3   = 0xb410e4c0
r4   = 0x00000002, r5   = 0xb410e000
r6   = 0xb680809c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb78f5b00
r10  = 0xbeda5498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbeda4c74
lr   = 0xb66fef18, pc   = 0xb66fdb84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:    231900 KB
Buffers:     35728 KB
Cached:     312288 KB
VmPeak:      90296 KB
VmSize:      90292 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19468 KB
VmRSS:       19468 KB
VmData:      21908 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35652 KB
VmPTE:          70 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 2112 TID = 2112
2112 2114 3808 

Maps Information
b1be6000 b1bee000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1bff000 b1c00000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c10000 b1c24000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c38000 b1c39000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c49000 b1c4c000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c5d000 b1c5e000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c6e000 b1c70000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c80000 b1c82000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c92000 b1ca2000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1cb2000 b1cbe000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cd0000 b24cf000 rw-p [stack:3808]
b2800000 b2807000 r-xp /usr/lib/libefl-extension.so.0.1.0
b281a000 b2820000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2830000 b2842000 r-xp /opt/usr/apps/org.example.client/bin/client
b299a000 b2a7d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ab4000 b2adc000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2aee000 b32ed000 rw-p [stack:2114]
b32ed000 b32ef000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32ff000 b3309000 r-xp /lib/libnss_files-2.20-2014.11.so
b331a000 b3323000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3334000 b3345000 r-xp /lib/libnsl-2.20-2014.11.so
b3358000 b335e000 r-xp /lib/libnss_compat-2.20-2014.11.so
b336f000 b3370000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3398000 b339f000 r-xp /usr/lib/libminizip.so.1.0.0
b33af000 b33b4000 r-xp /usr/lib/libstorage.so.0.1
b33c4000 b3423000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3439000 b344d000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b345d000 b34a1000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34b1000 b34b9000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34c9000 b34f9000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b350c000 b35c5000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35d9000 b362c000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b363d000 b3658000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3668000 b3729000 r-xp /usr/lib/libprotobuf.so.9.0.1
b373c000 b374c000 r-xp /usr/lib/libefl-assist.so.0.1.0
b375c000 b3769000 r-xp /usr/lib/libmdm-common.so.1.0.98
b377a000 b3781000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3791000 b37d2000 r-xp /usr/lib/libmdm.so.1.2.12
b37e2000 b37ea000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37f9000 b3809000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b382a000 b388a000 r-xp /usr/lib/libasound.so.2.0.0
b389c000 b389f000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38af000 b38b2000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38c2000 b38c7000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38d7000 b38d8000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38e8000 b38f3000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3907000 b390e000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b391e000 b3924000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3934000 b3939000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3949000 b3964000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3974000 b397b000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b398b000 b398e000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b399f000 b39cd000 r-xp /usr/lib/libidn.so.11.5.44
b39dd000 b39f3000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a04000 b3a0e000 r-xp /usr/lib/libcares.so.2.1.0
b3a1e000 b3a28000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a38000 b3a3a000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a4a000 b3a4b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a5b000 b3a5f000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a70000 b3a98000 r-xp /usr/lib/libui-extension.so.0.1.0
b3aa9000 b3ad2000 r-xp /usr/lib/libturbojpeg.so
b3af2000 b3af8000 r-xp /usr/lib/libgif.so.4.1.6
b3b08000 b3b4e000 r-xp /usr/lib/libcurl.so.4.3.0
b3b5f000 b3b80000 r-xp /usr/lib/libexif.so.12.3.3
b3b9b000 b3bb0000 r-xp /usr/lib/libtts.so
b3bc1000 b3bc9000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bd9000 b3c9f000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cbf000 b3db7000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3dd6000 b3ea4000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ebb000 b3ebd000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ecd000 b3ed3000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ee3000 b3f06000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f17000 b3f19000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f29000 b3f2b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f3c000 b3f41000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f58000 b3f5a000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f6a000 b3f71000 r-xp /usr/lib/libsensord-share.so
b3f81000 b3f99000 r-xp /usr/lib/libsensor.so.1.1.0
b3faa000 b3fad000 r-xp /usr/lib/libXv.so.1.0.0
b3fbd000 b3fc2000 r-xp /usr/lib/libutilX.so.1.1.0
b3fd2000 b3fd7000 r-xp /usr/lib/libappcore-common.so.1.1
b3fe7000 b3fee000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b4001000 b4005000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4016000 b40f4000 r-xp /usr/lib/libCOREGL.so.4.0
b4114000 b4117000 r-xp /usr/lib/libuuid.so.1.3.0
b4127000 b413e000 r-xp /usr/lib/libblkid.so.1.1.0
b414f000 b4151000 r-xp /usr/lib/libXau.so.6.0.0
b4161000 b41a8000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41ba000 b41c0000 r-xp /usr/lib/libjson-c.so.2.0.1
b41d1000 b41d5000 r-xp /usr/lib/libogg.so.0.7.1
b41e5000 b4207000 r-xp /usr/lib/libvorbis.so.0.4.3
b4217000 b42fb000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4317000 b431a000 r-xp /usr/lib/libEGL.so.1.4
b432b000 b4331000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4341000 b4343000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4353000 b4360000 r-xp /usr/lib/libGLESv2.so.2.0
b4371000 b43d3000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43e8000 b4400000 r-xp /usr/lib/libmount.so.1.1.0
b4412000 b4426000 r-xp /usr/lib/libxcb.so.1.1.0
b4436000 b443d000 r-xp /lib/libcrypt-2.20-2014.11.so
b4475000 b4477000 r-xp /usr/lib/libiri.so
b4487000 b4492000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44a3000 b44d9000 r-xp /usr/lib/libpulse.so.0.16.2
b44ea000 b452d000 r-xp /usr/lib/libsndfile.so.1.0.25
b4542000 b4557000 r-xp /lib/libexpat.so.1.5.2
b4569000 b4627000 r-xp /usr/lib/libcairo.so.2.11200.14
b463b000 b4643000 r-xp /usr/lib/libdrm.so.2.4.0
b4653000 b4656000 r-xp /usr/lib/libdri2.so.0.0.0
b4666000 b46b4000 r-xp /usr/lib/libssl.so.1.0.0
b46c9000 b46d5000 r-xp /usr/lib/libeeze.so.1.13.0
b46e6000 b46ef000 r-xp /usr/lib/libethumb.so.1.13.0
b46ff000 b4702000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4712000 b48c9000 r-xp /usr/lib/libcrypto.so.1.0.0
b56b4000 b56bd000 r-xp /usr/lib/libXi.so.6.1.0
b56cd000 b56cf000 r-xp /usr/lib/libXgesture.so.7.0.0
b56df000 b56e3000 r-xp /usr/lib/libXtst.so.6.1.0
b56f3000 b56f9000 r-xp /usr/lib/libXrender.so.1.3.0
b5709000 b570f000 r-xp /usr/lib/libXrandr.so.2.2.0
b571f000 b5721000 r-xp /usr/lib/libXinerama.so.1.0.0
b5732000 b5735000 r-xp /usr/lib/libXfixes.so.3.1.0
b5745000 b5750000 r-xp /usr/lib/libXext.so.6.4.0
b5760000 b5762000 r-xp /usr/lib/libXdamage.so.1.1.0
b5772000 b5774000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5784000 b5866000 r-xp /usr/lib/libX11.so.6.3.0
b587a000 b5881000 r-xp /usr/lib/libXcursor.so.1.0.2
b5891000 b58a9000 r-xp /usr/lib/libudev.so.1.6.0
b58ab000 b58ae000 r-xp /lib/libattr.so.1.1.0
b58be000 b58de000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58df000 b58e4000 r-xp /usr/lib/libffi.so.6.0.2
b58f5000 b590d000 r-xp /lib/libz.so.1.2.8
b591d000 b591f000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b592f000 b5a04000 r-xp /usr/lib/libxml2.so.2.9.2
b5a19000 b5ab4000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ad0000 b5ad3000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ae3000 b5afc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b0d000 b5b1e000 r-xp /lib/libresolv-2.20-2014.11.so
b5b32000 b5bac000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bc1000 b5bc3000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bd3000 b5bda000 r-xp /usr/lib/libembryo.so.1.13.0
b5bea000 b5bf4000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c05000 b5c1d000 r-xp /usr/lib/libpng12.so.0.50.0
b5c2e000 b5c51000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c72000 b5c86000 r-xp /usr/lib/libector.so.1.13.0
b5c97000 b5caf000 r-xp /usr/lib/liblua-5.1.so
b5cc0000 b5d17000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d2b000 b5d53000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d64000 b5d77000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d88000 b5dc2000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dd3000 b5de1000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5df1000 b5df9000 r-xp /usr/lib/libtbm.so.1.0.0
b5e09000 b5e16000 r-xp /usr/lib/libeio.so.1.13.0
b5e26000 b5e28000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e38000 b5e3d000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e4d000 b5e64000 r-xp /usr/lib/libefreet.so.1.13.0
b5e76000 b5e96000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ea6000 b5ec6000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ec8000 b5ece000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ede000 b5eef000 r-xp /usr/lib/libemotion.so.1.13.0
b5f00000 b5f07000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f17000 b5f26000 r-xp /usr/lib/libeo.so.1.13.0
b5f37000 b5f49000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f5a000 b5f5f000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f6f000 b5f88000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f98000 b5fb5000 r-xp /usr/lib/libeet.so.1.13.0
b5fce000 b6016000 r-xp /usr/lib/libeina.so.1.13.0
b6027000 b6037000 r-xp /usr/lib/libefl.so.1.13.0
b6048000 b612d000 r-xp /usr/lib/libicuuc.so.51.1
b614a000 b628a000 r-xp /usr/lib/libicui18n.so.51.1
b62a1000 b62d9000 r-xp /usr/lib/libecore_x.so.1.13.0
b62eb000 b62ee000 r-xp /lib/libcap.so.2.21
b62fe000 b6327000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6338000 b633f000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6351000 b6388000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6399000 b6484000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6497000 b6510000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6522000 b6527000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6537000 b6541000 r-xp /usr/lib/libvconf.so.0.2.45
b6551000 b6553000 r-xp /usr/lib/libvasum.so.0.3.1
b6563000 b6565000 r-xp /usr/lib/libttrace.so.1.1
b6575000 b6578000 r-xp /usr/lib/libiniparser.so.0
b6588000 b65ae000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65be000 b65c3000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65d4000 b65eb000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65fc000 b6667000 r-xp /lib/libm-2.20-2014.11.so
b6678000 b667e000 r-xp /lib/librt-2.20-2014.11.so
b668f000 b669c000 r-xp /usr/lib/libunwind.so.8.0.1
b66d2000 b67f6000 r-xp /lib/libc-2.20-2014.11.so
b680b000 b6824000 r-xp /lib/libgcc_s-4.9.so.1
b6834000 b6916000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6927000 b6951000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6962000 b699e000 r-xp /usr/lib/libsystemd.so.0.4.0
b69a0000 b6a23000 r-xp /usr/lib/libedje.so.1.13.0
b6a36000 b6a54000 r-xp /usr/lib/libecore.so.1.13.0
b6a74000 b6bfb000 r-xp /usr/lib/libevas.so.1.13.0
b6c30000 b6c44000 r-xp /lib/libpthread-2.20-2014.11.so
b6c58000 b6e8c000 r-xp /usr/lib/libelementary.so.1.13.0
b6ebb000 b6ebf000 r-xp /usr/lib/libsmack.so.1.0.0
b6ecf000 b6ed6000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ee6000 b6ee8000 r-xp /usr/lib/libdlog.so.0.0.0
b6ef8000 b6efb000 r-xp /usr/lib/libbundle.so.0.1.22
b6f0b000 b6f0d000 r-xp /lib/libdl-2.20-2014.11.so
b6f1e000 b6f36000 r-xp /usr/lib/libaul.so.0.1.0
b6f4a000 b6f4f000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f60000 b6f6d000 r-xp /usr/lib/liblptcp.so
b6f7f000 b6f83000 r-xp /usr/lib/libsys-assert.so
b6f94000 b6fb4000 r-xp /lib/ld-2.20-2014.11.so
b6fc5000 b6fca000 r-xp /usr/bin/launchpad-loader
b78b4000 b7adf000 rw-p [heap]
bed85000 beda6000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2112)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66fdb84) [/lib/libc.so.6] + 0x2bb84
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
900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-03 03:25:12.724+0900 I/Tizen::App( 1231): (78) > Installation is Completed. [Package = org.example.client]
04-03 03:25:12.724+0900 I/Tizen::App( 1231): (671) > Enter. package(org.example.client), installationResult(0)
04-03 03:25:12.754+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-03 03:25:12.784+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-03 03:25:12.784+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-03 03:25:12.784+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-03 03:25:12.784+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-03 03:25:12.784+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-03 03:25:12.794+0900 I/Tizen::App( 1231): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-03 03:25:12.814+0900 I/Tizen::App( 1231): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-03 03:25:12.814+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-03 03:25:12.814+0900 E/HOME_APPS(  858): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-03 03:25:12.824+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-03 03:25:12.824+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-03 03:25:12.824+0900 E/PKGMGR_SERVER( 3294): pkgmgr-server.c: sighandler(417) > child NORMAL exit [3347]
04-03 03:25:12.824+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-03 03:25:12.834+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-03 03:25:12.834+0900 E/PKGMGR_INFO( 1231): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-03 03:25:12.834+0900 I/Tizen::App( 1231): (683) > Application count(1) in this package
04-03 03:25:12.834+0900 I/Tizen::App( 1231): (840) > Enter.
04-03 03:25:12.834+0900 I/Tizen::App( 1231): (703) > Exit.
04-03 03:25:12.834+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-03 03:25:12.844+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-03 03:25:12.844+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-03 03:25:12.844+0900 I/Tizen::App( 1231): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-03 03:25:12.844+0900 I/Tizen::App( 1231): (131) > Enter
04-03 03:25:12.844+0900 I/Tizen::App( 1231): (137) > org.example.client does not have launch condition
04-03 03:25:12.844+0900 I/Tizen::App( 1231): (883) > Exit.
04-03 03:25:12.864+0900 E/util-view(  858): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-03 03:25:12.884+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-03 03:25:13.004+0900 E/PKGMGR_SERVER( 3294): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-03 03:25:13.004+0900 E/PKGMGR_SERVER( 3294): pkgmgr-server.c: main(2471) > package manager server terminated.
04-03 03:25:17.148+0900 W/AUL     ( 3405): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-03 03:25:17.148+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-03 03:25:17.158+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-03 03:25:17.168+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-03 03:25:17.168+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-03 03:25:17.168+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 3405
04-03 03:25:17.168+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-03 03:25:17.168+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-03 03:25:17.178+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-03 03:25:17.178+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-4)
04-03 03:25:17.299+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 3407, appid: org.example.client
04-03 03:25:17.299+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-03 03:25:17.299+0900 W/AUL     ( 3405): launch.c: app_request_to_launchpad(425) > request cmd(0) result(3407)
04-03 03:25:18.300+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-03 03:25:18.300+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-03 03:25:22.303+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(3407)
04-03 03:25:22.303+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 3407, appid: org.example.client, status: bg
04-03 03:25:27.499+0900 I/abc     ( 3407): abc
04-03 03:25:27.509+0900 I/CAPI_APPFW_APPLICATION( 3407): app_main.c: ui_app_main(789) > app_efl_main
04-03 03:25:28.670+0900 I/CAPI_APPFW_APPLICATION( 3407): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-03 03:25:30.852+0900 E/TBM     ( 3407): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-03 03:26:00.120+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-03 03:26:00.120+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:26
04-03 03:26:00.120+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 3:26"
04-03 03:26:00.120+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:26"
04-03 03:26:00.120+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-03 03:26:00.120+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146859322 Time: <font_size=31> </font_size> <font_size=31> 오전 3:26</font_size></font>"
04-03 03:26:48.117+0900 E/PKGMGR_SERVER( 3475): pkgmgr-server.c: main(2414) > package manager server start
04-03 03:26:48.167+0900 E/PKGMGR  ( 3473): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-03 03:26:48.197+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-03 03:26:48.197+0900 E/AUL_AMD (  610): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 3407
04-03 03:26:48.207+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-03 03:26:48.217+0900 E/PKGMGR_SERVER( 3475): pkgmgr-server.c: sighandler(417) > child NORMAL exit [3478]
04-03 03:26:49.999+0900 E/PKGMGR_SERVER( 3475): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-03 03:26:49.999+0900 E/PKGMGR_SERVER( 3475): pkgmgr-server.c: main(2471) > package manager server terminated.
04-03 03:26:52.041+0900 E/PKGMGR  ( 3563): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-03 03:26:52.111+0900 E/PKGMGR_SERVER( 3565): pkgmgr-server.c: main(2414) > package manager server start
04-03 03:26:52.161+0900 E/PKGMGR_SERVER( 3565): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-03 03:26:52.171+0900 E/PKGMGR_SERVER( 3565): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-03 03:26:52.171+0900 E/PKGMGR  ( 3563): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[35630002]
04-03 03:26:52.321+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-03 03:26:52.321+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-03 03:26:52.331+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-03 03:26:52.331+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-03 03:26:52.331+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-03 03:26:52.331+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-03 03:26:52.471+0900 W/CERT_SVC_VCORE( 3568): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-03 03:26:52.541+0900 E/rpm-installer( 3568): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-03 03:26:52.541+0900 E/rpm-installer( 3568): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-03 03:26:52.592+0900 E/PKGMGR_PARSER( 3568): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-03 03:26:52.612+0900 I/PRIVACY-MANAGER-CLIENT( 3568): SocketClient.cpp: SocketClient(37) > Client created
04-03 03:26:52.612+0900 I/PRIVACY-MANAGER-CLIENT( 3568): SocketClient.cpp: connect(62) > Client connected
04-03 03:26:52.612+0900 I/PRIVACY-MANAGER-SERVER(  915): SocketService.cpp: mainloop(230) > Got incoming connection
04-03 03:26:52.612+0900 I/PRIVACY-MANAGER-CLIENT( 3568): SocketClient.cpp: disconnect(72) > Client disconnected
04-03 03:26:52.622+0900 E/PKGMGR_CERT( 3568): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-03 03:26:52.622+0900 E/PKGMGR_CERT( 3568): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-03 03:26:52.632+0900 E/PKGMGR_CERT( 3568): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-03 03:26:52.662+0900 E/rpm-installer( 3568): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-03 03:26:52.662+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-03 03:26:52.662+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
04-03 03:26:52.662+0900 E/ESD     (  893): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-03 03:26:52.672+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-03 03:26:52.672+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-03 03:26:52.672+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-03 03:26:54.003+0900 E/PKGMGR_SERVER( 3565): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-03 03:26:54.313+0900 E/PKGMGR_SERVER( 3565): pkgmgr-server.c: sighandler(417) > child NORMAL exit [3568]
04-03 03:26:55.314+0900 E/PKGMGR  ( 3617): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-03 03:26:55.344+0900 E/PKGMGR_SERVER( 3565): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-03 03:26:55.354+0900 E/PKGMGR_INFO( 3565): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-03 03:26:55.364+0900 E/rpm-installer( 3565): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-03 03:26:55.374+0900 E/PKGMGR_SERVER( 3565): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-03 03:26:55.374+0900 E/PKGMGR  ( 3617): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[36170002]
04-03 03:26:55.504+0900 E/PKGMGR_INSTALLER( 3619): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-03 03:26:55.504+0900 E/rpm-installer( 3619): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-03 03:26:55.524+0900 E/rpm-installer( 3619): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-03 03:26:55.524+0900 E/rpm-installer( 3619): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-03 03:26:55.524+0900 E/rpm-installer( 3619): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-03 03:26:55.524+0900 E/rpm-installer( 3619): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-03 03:26:55.524+0900 E/rpm-installer( 3619): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-03 03:26:55.574+0900 W/CERT_SVC_VCORE( 3619): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-03 03:26:55.614+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-03 03:26:55.614+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
04-03 03:26:55.625+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-03 03:26:55.625+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-03 03:26:55.625+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-03 03:26:55.795+0900 E/rpm-installer( 3619): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-03 03:26:55.795+0900 E/rpm-installer( 3619): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-03 03:26:55.795+0900 E/rpm-installer( 3619): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-03 03:26:55.795+0900 E/rpm-installer( 3619): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-03 03:26:55.795+0900 E/rpm-installer( 3619): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-03 03:26:55.795+0900 E/rpm-installer( 3619): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-03 03:26:55.805+0900 E/PKGMGR_PARSER( 3619): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-03 03:26:55.805+0900 E/PKGMGR_PARSER( 3619): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-03 03:26:55.845+0900 I/PRIVACY-MANAGER-CLIENT( 3619): SocketClient.cpp: SocketClient(37) > Client created
04-03 03:26:56.005+0900 E/PKGMGR_SERVER( 3565): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-03 03:26:56.045+0900 E/PKGMGR_PARSER( 3619): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-03 03:26:56.065+0900 E/PKGMGR_CERT( 3619): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-03 03:26:56.065+0900 E/PKGMGR_CERT( 3619): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 108
04-03 03:26:56.065+0900 E/PKGMGR_CERT( 3619): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 108
04-03 03:26:56.065+0900 E/PKGMGR_CERT( 3619): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 2
04-03 03:26:56.065+0900 E/PKGMGR_CERT( 3619): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 3
04-03 03:26:56.075+0900 E/PKGMGR_CERT( 3619): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 3
04-03 03:26:56.075+0900 E/PKGMGR_CERT( 3619): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 2
04-03 03:26:56.075+0900 E/PKGMGR_CERT( 3619): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-03 03:26:56.085+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-03 03:26:56.085+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [60]
04-03 03:26:56.085+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
04-03 03:26:56.095+0900 E/rpm-installer( 3619): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-03 03:26:56.115+0900 E/rpm-installer( 3619): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-03 03:26:56.125+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-03 03:26:56.125+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [100]
04-03 03:26:56.125+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-03 03:26:56.866+0900 E/RESOURCED(  664): procfs.c: proc_get_oom_score_adj(131) > fopen /proc/1222/oom_score_adj failed
04-03 03:26:56.866+0900 E/RESOURCED(  664): proc-main.c: resourced_proc_status_change(867) > Empty pid or process not exists. 1222
04-03 03:26:57.997+0900 E/PKGMGR_SERVER( 3565): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-03 03:26:58.027+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-03 03:26:58.027+0900 I/Tizen::App( 1231): (78) > Installation is Completed. [Package = org.example.client]
04-03 03:26:58.027+0900 I/Tizen::App( 1231): (671) > Enter. package(org.example.client), installationResult(0)
04-03 03:26:58.027+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-03 03:26:58.027+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-03 03:26:58.027+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-03 03:26:58.037+0900 I/Tizen::App( 1231): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-03 03:26:58.047+0900 I/Tizen::App( 1231): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-03 03:26:58.067+0900 E/PKGMGR_SERVER( 3565): pkgmgr-server.c: sighandler(417) > child NORMAL exit [3619]
04-03 03:26:58.077+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-03 03:26:58.097+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-03 03:26:58.097+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-03 03:26:58.097+0900 E/PKGMGR_INFO( 1231): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-03 03:26:58.097+0900 I/Tizen::App( 1231): (683) > Application count(1) in this package
04-03 03:26:58.097+0900 I/Tizen::App( 1231): (840) > Enter.
04-03 03:26:58.107+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-03 03:26:58.107+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-03 03:26:58.107+0900 I/Tizen::App( 1231): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-03 03:26:58.107+0900 I/Tizen::App( 1231): (131) > Enter
04-03 03:26:58.107+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-03 03:26:58.117+0900 I/Tizen::App( 1231): (703) > Exit.
04-03 03:26:58.117+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-03 03:26:58.117+0900 I/Tizen::App( 1231): (137) > org.example.client does not have launch condition
04-03 03:26:58.117+0900 I/Tizen::App( 1231): (883) > Exit.
04-03 03:26:58.137+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-03 03:26:58.137+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-03 03:26:58.137+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-03 03:26:58.137+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-03 03:26:58.147+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-03 03:26:58.147+0900 E/HOME_APPS(  858): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-03 03:26:58.147+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-03 03:26:58.147+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-03 03:26:58.167+0900 E/util-view(  858): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-03 03:26:58.187+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-03 03:26:59.999+0900 E/PKGMGR_SERVER( 3565): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-03 03:26:59.999+0900 E/PKGMGR_SERVER( 3565): pkgmgr-server.c: main(2471) > package manager server terminated.
04-03 03:27:00.119+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-03 03:27:00.119+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:27
04-03 03:27:00.119+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 3:27"
04-03 03:27:00.119+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:27"
04-03 03:27:00.119+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-03 03:27:00.119+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146844958 Time: <font_size=31> </font_size> <font_size=31> 오전 3:27</font_size></font>"
04-03 03:27:02.351+0900 W/AUL     ( 3677): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-03 03:27:02.351+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-03 03:27:02.361+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-03 03:27:02.371+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-03 03:27:02.371+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-03 03:27:02.371+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 3677
04-03 03:27:02.371+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-03 03:27:02.381+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-03 03:27:02.381+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-03 03:27:02.381+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-4)
04-03 03:27:02.491+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 3679, appid: org.example.client
04-03 03:27:02.491+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-03 03:27:02.511+0900 W/AUL     ( 3677): launch.c: app_request_to_launchpad(425) > request cmd(0) result(3679)
04-03 03:27:03.502+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-03 03:27:03.502+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-03 03:27:07.496+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(3679)
04-03 03:27:07.496+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 3679, appid: org.example.client, status: bg
04-03 03:27:10.899+0900 I/abc     ( 3679): abc
04-03 03:27:10.909+0900 I/CAPI_APPFW_APPLICATION( 3679): app_main.c: ui_app_main(789) > app_efl_main
04-03 03:27:12.041+0900 I/CAPI_APPFW_APPLICATION( 3679): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-03 03:27:14.223+0900 E/TBM     ( 3679): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-03 03:27:51.329+0900 I/Tizen::System( 1231): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
04-03 03:27:56.564+0900 E/PKGMGR_SERVER( 3740): pkgmgr-server.c: main(2414) > package manager server start
04-03 03:27:56.614+0900 E/PKGMGR  ( 3738): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-03 03:27:56.654+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-03 03:27:56.654+0900 E/AUL_AMD (  610): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 3679
04-03 03:27:56.654+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-03 03:27:56.664+0900 E/PKGMGR_SERVER( 3740): pkgmgr-server.c: sighandler(417) > child NORMAL exit [3743]
04-03 03:27:58.326+0900 E/VOLUME  (  854): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
04-03 03:27:58.326+0900 E/VOLUME  (  854): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
04-03 03:27:58.356+0900 W/LOCKSCREEN(  842): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[timeout] (status:3)
04-03 03:27:58.356+0900 W/LOCKSCREEN(  842): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:timeout
04-03 03:27:58.356+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30000:LCD_WILL_OFF
04-03 03:27:58.356+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:30000 event_info:10f2a30
04-03 03:27:58.356+0900 W/LOCKSCREEN(  842): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
04-03 03:27:58.356+0900 W/LOCKSCREEN(  842): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
04-03 03:27:58.366+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-03 03:27:58.366+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-03 03:27:58.366+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-03 03:27:58.416+0900 E/LOCKSCREEN(  842): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-03 03:27:58.446+0900 E/LOCKSCREEN(  842): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
04-03 03:27:58.446+0900 E/LOCKSCREEN(  842): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
04-03 03:27:58.446+0900 W/LOCKSCREEN(  842): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:5
04-03 03:27:58.446+0900 W/LOCKSCREEN(  842): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
04-03 03:27:58.456+0900 W/AUL     (  842): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
04-03 03:27:58.456+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-03 03:27:58.456+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 842
04-03 03:27:58.456+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
04-03 03:27:58.466+0900 W/INDICATOR(  661): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
04-03 03:27:58.466+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 3781
04-03 03:27:58.466+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-03 03:27:58.506+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 3781
04-03 03:27:58.506+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 3781, appid: com.samsung.weather-m-agent
04-03 03:27:58.516+0900 W/AUL     (  842): launch.c: app_request_to_launchpad(425) > request cmd(0) result(3781)
04-03 03:27:58.516+0900 I/Tizen::App( 1231): (499) > LaunchedApp(com.samsung.weather-m-agent)
04-03 03:27:58.516+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 3781.
04-03 03:27:58.716+0900 W/APP_CORE(  858): appcore-efl.c: __cmsg_cb(1038) > LCD Off. Pause the topmost app
04-03 03:27:58.716+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-03 03:27:58.716+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-03 03:27:58.716+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-03 03:27:58.726+0900 E/VOLUME  (  854): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
04-03 03:27:58.726+0900 E/VOLUME  (  854): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
04-03 03:27:58.726+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-03 03:27:58.736+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: PAUSED
04-03 03:27:58.736+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(842) status(3)
04-03 03:27:58.736+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-03 03:27:58.736+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-03 03:27:58.736+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.lockscreen(842)
04-03 03:27:58.736+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 842, appid: com.samsung.lockscreen, status: fg
04-03 03:27:58.736+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-03 03:27:58.736+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-03 03:27:58.736+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-03 03:27:58.746+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(842) status(0)
04-03 03:27:58.756+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-03 03:27:58.756+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-03 03:27:58.796+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [com.samsun] 
04-03 03:27:58.796+0900 I/Tizen::System( 1231): (273) > Current App[com.samsun] is already actived.
04-03 03:27:58.816+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-03 03:27:58.996+0900 E/PKGMGR_SERVER( 3740): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-03 03:27:58.996+0900 E/PKGMGR_SERVER( 3740): pkgmgr-server.c: main(2471) > package manager server terminated.
04-03 03:27:59.006+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:1:LOCK
04-03 03:27:59.006+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:1 event_info:0
04-03 03:27:59.006+0900 E/LOCKSCREEN(  842): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
04-03 03:27:59.006+0900 W/LOCKSCREEN(  842): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
04-03 03:27:59.006+0900 W/LOCKSCREEN(  842): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2A00007] is [visible]
04-03 03:27:59.006+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10001:WIN_BECOME_VISIBLE
04-03 03:27:59.006+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:10001 event_info:0
04-03 03:27:59.006+0900 E/LOCKSCREEN(  842): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
04-03 03:27:59.006+0900 W/APP_CORE(  842): appcore-efl.c: __visibility_cb(989) > LCD status is off, skip the AE_RESUME event
04-03 03:27:59.006+0900 W/INDICATOR(  661): main.c: _indicator_lock_status_cb(413) > Hide Clock
04-03 03:27:59.006+0900 E/weather-agent( 3781): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
04-03 03:27:59.006+0900 E/LOCKSCREEN(  842): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
04-03 03:27:59.016+0900 E/LOCKSCREEN(  842): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
04-03 03:27:59.016+0900 E/LOCKSCREEN(  842): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-03 03:27:59.016+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
04-03 03:27:59.016+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
04-03 03:27:59.016+0900 E/weather-common( 3781): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
04-03 03:27:59.016+0900 W/LOCKSCREEN(  842): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
04-03 03:27:59.016+0900 W/LOCKSCREEN(  842): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
04-03 03:27:59.016+0900 W/LOCKSCREEN(  842): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30002:LCD_OFF
04-03 03:27:59.016+0900 W/LOCKSCREEN(  842): daemon.c: _event_route(838) > [_event_route:838:W] event:30002 event_info:0
04-03 03:27:59.016+0900 W/LOCKSCREEN(  842): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:6
04-03 03:27:59.016+0900 W/LOCKSCREEN(  842): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
04-03 03:27:59.016+0900 E/weather-agent( 3781): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
04-03 03:27:59.036+0900 I/MESSAGE_PORT( 3781): message-port.c: __initialize(872) > initialize
04-03 03:27:59.056+0900 I/MESSAGE_PORT( 3781): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
04-03 03:27:59.066+0900 W/AUL     ( 3798): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-03 03:27:59.066+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-03 03:27:59.076+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-03 03:27:59.086+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-03 03:27:59.086+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-03 03:27:59.086+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 3798
04-03 03:27:59.086+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-03 03:27:59.096+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-03 03:27:59.096+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-03 03:27:59.106+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-03 03:27:59.106+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-03 03:27:59.106+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __message_port_send_message(972) > port exist check !!
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
04-03 03:27:59.116+0900 E/weather-common( 3781): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
04-03 03:27:59.116+0900 I/MESSAGE_PORT(  842): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __message_port_send_message(972) > port exist check !!
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
04-03 03:27:59.116+0900 E/MESSAGE_PORT( 3781): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
04-03 03:27:59.116+0900 E/weather-common( 3781): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __message_port_send_message(972) > port exist check !!
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __message_port_send_message(972) > port exist check !!
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
04-03 03:27:59.116+0900 I/MESSAGE_PORT( 3781): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
04-03 03:27:59.116+0900 I/abc     ( 2112): abc
04-03 03:27:59.126+0900 I/CAPI_APPFW_APPLICATION( 2112): app_main.c: ui_app_main(789) > app_efl_main
04-03 03:27:59.126+0900 E/MESSAGE_PORT( 3781): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
04-03 03:27:59.126+0900 E/weather-common( 3781): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
04-03 03:27:59.126+0900 E/weather-common( 3781): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
04-03 03:27:59.126+0900 E/weather-common( 3781): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : 흑석동[0;m
04-03 03:27:59.126+0900 E/weather-common( 3781): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Heukseok-dong[0;m
04-03 03:27:59.126+0900 E/weather-common( 3781): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 7.000000[0;m
04-03 03:27:59.126+0900 E/weather-common( 3781): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 16.400000[0;m
04-03 03:27:59.126+0900 E/weather-common( 3781): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 36.900000[0;m
04-03 03:27:59.126+0900 E/weather-common( 3781): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 18[0;m
04-03 03:27:59.126+0900 E/weather-common( 3781): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1491143948[0;m
04-03 03:27:59.126+0900 E/weather-common( 3781): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
04-03 03:27:59.126+0900 E/weather-common( 3781): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : On[0;m
04-03 03:27:59.126+0900 I/MESSAGE_PORT( 1448): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
04-03 03:27:59.126+0900 E/weather-agent( 3781): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
04-03 03:27:59.126+0900 E/weather-agent( 3781): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
04-03 03:27:59.126+0900 I/MESSAGE_PORT( 3781): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
04-03 03:27:59.126+0900 I/MESSAGE_PORT( 3781): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
04-03 03:27:59.126+0900 I/CAPI_APPFW_APPLICATION( 2112): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-03 03:27:59.146+0900 E/TBM     ( 2112): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-03 03:27:59.207+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 2112, appid: org.example.client
04-03 03:27:59.207+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-03 03:27:59.207+0900 W/AUL     ( 3798): launch.c: app_request_to_launchpad(425) > request cmd(0) result(2112)
04-03 03:27:59.217+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-03 03:27:59.227+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-03 03:27:59.257+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-03 03:27:59.297+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
04-03 03:27:59.297+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
04-03 03:27:59.437+0900 W/CRASH_MANAGER( 3815): worker.c: worker_job(1199) > 0602112636c69149115767
