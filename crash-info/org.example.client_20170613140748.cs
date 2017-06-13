S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 17781
Date: 2017-06-13 14:07:48+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 17781, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00004575
r2   = 0x00000006, r3   = 0xb40c54c0
r4   = 0x00000002, r5   = 0xb40c5000
r6   = 0xb67bf09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb8b72ae8
r10  = 0xbe916498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbe916004
lr   = 0xb66b5f18, pc   = 0xb66b4b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     68828 KB
Buffers:     64076 KB
Cached:     228680 KB
VmPeak:      90536 KB
VmSize:      90532 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19636 KB
VmRSS:       19636 KB
VmData:      22012 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35776 KB
VmPTE:          70 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 17781 TID = 17781
17781 17783 18065 

Maps Information
b1b7d000 b1b85000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b96000 b1b97000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1ba7000 b1bbb000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bcf000 b1bd0000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1be0000 b1be3000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bf4000 b1bf5000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c05000 b1c07000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c17000 b1c19000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c29000 b1c39000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c49000 b1c55000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c67000 b2466000 rw-p [stack:18065]
b2797000 b279e000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27b1000 b27b7000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27c7000 b27f8000 r-xp /opt/usr/apps/org.example.client/bin/client
b2951000 b2a34000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a6b000 b2a93000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2aa5000 b32a4000 rw-p [stack:17783]
b32a4000 b32a6000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32b6000 b32c0000 r-xp /lib/libnss_files-2.20-2014.11.so
b32d1000 b32da000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32eb000 b32fc000 r-xp /lib/libnsl-2.20-2014.11.so
b330f000 b3315000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3326000 b3327000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b334f000 b3356000 r-xp /usr/lib/libminizip.so.1.0.0
b3366000 b336b000 r-xp /usr/lib/libstorage.so.0.1
b337b000 b33da000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33f0000 b3404000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3414000 b3458000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3468000 b3470000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3480000 b34b0000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34c3000 b357c000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3590000 b35e3000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35f4000 b360f000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b361f000 b36e0000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36f3000 b3703000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3713000 b3720000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3731000 b3738000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3748000 b3789000 r-xp /usr/lib/libmdm.so.1.2.12
b3799000 b37a1000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37b0000 b37c0000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37e1000 b3841000 r-xp /usr/lib/libasound.so.2.0.0
b3853000 b3856000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3866000 b3869000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3879000 b387e000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b388e000 b388f000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b389f000 b38aa000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38be000 b38c5000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38d5000 b38db000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38eb000 b38f0000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3900000 b391b000 r-xp /usr/lib/libmmfsound.so.0.1.0
b392b000 b3932000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3942000 b3945000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3956000 b3984000 r-xp /usr/lib/libidn.so.11.5.44
b3994000 b39aa000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39bb000 b39c5000 r-xp /usr/lib/libcares.so.2.1.0
b39d5000 b39df000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39ef000 b39f1000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a01000 b3a02000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a12000 b3a16000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a27000 b3a4f000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a60000 b3a89000 r-xp /usr/lib/libturbojpeg.so
b3aa9000 b3aaf000 r-xp /usr/lib/libgif.so.4.1.6
b3abf000 b3b05000 r-xp /usr/lib/libcurl.so.4.3.0
b3b16000 b3b37000 r-xp /usr/lib/libexif.so.12.3.3
b3b52000 b3b67000 r-xp /usr/lib/libtts.so
b3b78000 b3b80000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b90000 b3c56000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c76000 b3d6e000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d8d000 b3e5b000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e72000 b3e74000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e84000 b3e8a000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e9a000 b3ebd000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ece000 b3ed0000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ee0000 b3ee2000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ef3000 b3ef8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f0f000 b3f11000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f21000 b3f28000 r-xp /usr/lib/libsensord-share.so
b3f38000 b3f50000 r-xp /usr/lib/libsensor.so.1.1.0
b3f61000 b3f64000 r-xp /usr/lib/libXv.so.1.0.0
b3f74000 b3f79000 r-xp /usr/lib/libutilX.so.1.1.0
b3f89000 b3f8e000 r-xp /usr/lib/libappcore-common.so.1.1
b3f9e000 b3fa5000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fb8000 b3fbc000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fcd000 b40ab000 r-xp /usr/lib/libCOREGL.so.4.0
b40cb000 b40ce000 r-xp /usr/lib/libuuid.so.1.3.0
b40de000 b40f5000 r-xp /usr/lib/libblkid.so.1.1.0
b4106000 b4108000 r-xp /usr/lib/libXau.so.6.0.0
b4118000 b415f000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4171000 b4177000 r-xp /usr/lib/libjson-c.so.2.0.1
b4188000 b418c000 r-xp /usr/lib/libogg.so.0.7.1
b419c000 b41be000 r-xp /usr/lib/libvorbis.so.0.4.3
b41ce000 b42b2000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42ce000 b42d1000 r-xp /usr/lib/libEGL.so.1.4
b42e2000 b42e8000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42f8000 b42fa000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b430a000 b4317000 r-xp /usr/lib/libGLESv2.so.2.0
b4328000 b438a000 r-xp /usr/lib/libpixman-1.so.0.28.2
b439f000 b43b7000 r-xp /usr/lib/libmount.so.1.1.0
b43c9000 b43dd000 r-xp /usr/lib/libxcb.so.1.1.0
b43ed000 b43f4000 r-xp /lib/libcrypt-2.20-2014.11.so
b442c000 b442e000 r-xp /usr/lib/libiri.so
b443e000 b4449000 r-xp /usr/lib/libgpg-error.so.0.15.0
b445a000 b4490000 r-xp /usr/lib/libpulse.so.0.16.2
b44a1000 b44e4000 r-xp /usr/lib/libsndfile.so.1.0.25
b44f9000 b450e000 r-xp /lib/libexpat.so.1.5.2
b4520000 b45de000 r-xp /usr/lib/libcairo.so.2.11200.14
b45f2000 b45fa000 r-xp /usr/lib/libdrm.so.2.4.0
b460a000 b460d000 r-xp /usr/lib/libdri2.so.0.0.0
b461d000 b466b000 r-xp /usr/lib/libssl.so.1.0.0
b4680000 b468c000 r-xp /usr/lib/libeeze.so.1.13.0
b469d000 b46a6000 r-xp /usr/lib/libethumb.so.1.13.0
b46b6000 b46b9000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46c9000 b4880000 r-xp /usr/lib/libcrypto.so.1.0.0
b566b000 b5674000 r-xp /usr/lib/libXi.so.6.1.0
b5684000 b5686000 r-xp /usr/lib/libXgesture.so.7.0.0
b5696000 b569a000 r-xp /usr/lib/libXtst.so.6.1.0
b56aa000 b56b0000 r-xp /usr/lib/libXrender.so.1.3.0
b56c0000 b56c6000 r-xp /usr/lib/libXrandr.so.2.2.0
b56d6000 b56d8000 r-xp /usr/lib/libXinerama.so.1.0.0
b56e9000 b56ec000 r-xp /usr/lib/libXfixes.so.3.1.0
b56fc000 b5707000 r-xp /usr/lib/libXext.so.6.4.0
b5717000 b5719000 r-xp /usr/lib/libXdamage.so.1.1.0
b5729000 b572b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b573b000 b581d000 r-xp /usr/lib/libX11.so.6.3.0
b5831000 b5838000 r-xp /usr/lib/libXcursor.so.1.0.2
b5848000 b5860000 r-xp /usr/lib/libudev.so.1.6.0
b5862000 b5865000 r-xp /lib/libattr.so.1.1.0
b5875000 b5895000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5896000 b589b000 r-xp /usr/lib/libffi.so.6.0.2
b58ac000 b58c4000 r-xp /lib/libz.so.1.2.8
b58d4000 b58d6000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58e6000 b59bb000 r-xp /usr/lib/libxml2.so.2.9.2
b59d0000 b5a6b000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a87000 b5a8a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a9a000 b5ab3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ac4000 b5ad5000 r-xp /lib/libresolv-2.20-2014.11.so
b5ae9000 b5b63000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b78000 b5b7a000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b8a000 b5b91000 r-xp /usr/lib/libembryo.so.1.13.0
b5ba1000 b5bab000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bbc000 b5bd4000 r-xp /usr/lib/libpng12.so.0.50.0
b5be5000 b5c08000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c29000 b5c3d000 r-xp /usr/lib/libector.so.1.13.0
b5c4e000 b5c66000 r-xp /usr/lib/liblua-5.1.so
b5c77000 b5cce000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ce2000 b5d0a000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d1b000 b5d2e000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d3f000 b5d79000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d8a000 b5d98000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5da8000 b5db0000 r-xp /usr/lib/libtbm.so.1.0.0
b5dc0000 b5dcd000 r-xp /usr/lib/libeio.so.1.13.0
b5ddd000 b5ddf000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5def000 b5df4000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e04000 b5e1b000 r-xp /usr/lib/libefreet.so.1.13.0
b5e2d000 b5e4d000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e5d000 b5e7d000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e7f000 b5e85000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e95000 b5ea6000 r-xp /usr/lib/libemotion.so.1.13.0
b5eb7000 b5ebe000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ece000 b5edd000 r-xp /usr/lib/libeo.so.1.13.0
b5eee000 b5f00000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f11000 b5f16000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f26000 b5f3f000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f4f000 b5f6c000 r-xp /usr/lib/libeet.so.1.13.0
b5f85000 b5fcd000 r-xp /usr/lib/libeina.so.1.13.0
b5fde000 b5fee000 r-xp /usr/lib/libefl.so.1.13.0
b5fff000 b60e4000 r-xp /usr/lib/libicuuc.so.51.1
b6101000 b6241000 r-xp /usr/lib/libicui18n.so.51.1
b6258000 b6290000 r-xp /usr/lib/libecore_x.so.1.13.0
b62a2000 b62a5000 r-xp /lib/libcap.so.2.21
b62b5000 b62de000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62ef000 b62f6000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6308000 b633f000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6350000 b643b000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b644e000 b64c7000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64d9000 b64de000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64ee000 b64f8000 r-xp /usr/lib/libvconf.so.0.2.45
b6508000 b650a000 r-xp /usr/lib/libvasum.so.0.3.1
b651a000 b651c000 r-xp /usr/lib/libttrace.so.1.1
b652c000 b652f000 r-xp /usr/lib/libiniparser.so.0
b653f000 b6565000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6575000 b657a000 r-xp /usr/lib/libxdgmime.so.1.1.0
b658b000 b65a2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65b3000 b661e000 r-xp /lib/libm-2.20-2014.11.so
b662f000 b6635000 r-xp /lib/librt-2.20-2014.11.so
b6646000 b6653000 r-xp /usr/lib/libunwind.so.8.0.1
b6689000 b67ad000 r-xp /lib/libc-2.20-2014.11.so
b67c2000 b67db000 r-xp /lib/libgcc_s-4.9.so.1
b67eb000 b68cd000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68de000 b6908000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6919000 b6955000 r-xp /usr/lib/libsystemd.so.0.4.0
b6957000 b69da000 r-xp /usr/lib/libedje.so.1.13.0
b69ed000 b6a0b000 r-xp /usr/lib/libecore.so.1.13.0
b6a2b000 b6bb2000 r-xp /usr/lib/libevas.so.1.13.0
b6be7000 b6bfb000 r-xp /lib/libpthread-2.20-2014.11.so
b6c0f000 b6e43000 r-xp /usr/lib/libelementary.so.1.13.0
b6e72000 b6e76000 r-xp /usr/lib/libsmack.so.1.0.0
b6e86000 b6e8d000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e9d000 b6e9f000 r-xp /usr/lib/libdlog.so.0.0.0
b6eaf000 b6eb2000 r-xp /usr/lib/libbundle.so.0.1.22
b6ec2000 b6ec4000 r-xp /lib/libdl-2.20-2014.11.so
b6ed5000 b6eed000 r-xp /usr/lib/libaul.so.0.1.0
b6f01000 b6f06000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f17000 b6f24000 r-xp /usr/lib/liblptcp.so
b6f36000 b6f3a000 r-xp /usr/lib/libsys-assert.so
b6f4b000 b6f6b000 r-xp /lib/ld-2.20-2014.11.so
b6f7c000 b6f81000 r-xp /usr/bin/launchpad-loader
b8b31000 b8d76000 rw-p [heap]
be8f6000 be917000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17781)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66b4b84) [/lib/libc.so.6] + 0x2bb84
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
900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:07:19.746+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:07:19.746+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:07:19.746+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:07:19.746+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:07:19.746+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:07:19.746+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-13 14:07:19.796+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:07:19.796+0900 I/SWIFTKEY(  713): swiftkey_engine.cpp: IME_Learn_sentence(2373) > [0;36mDLM write[0m
06-13 14:07:19.816+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 14:07:19.826+0900 E/RUA     (17520): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 24, ncols : 5
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 14:07:19.826+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:07:19.826+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 17493
06-13 14:07:19.826+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 14:07:19.826+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 14:07:19.836+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:07:19.836+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:07:19.836+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:07:19.856+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:07:19.866+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:07:19.876+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [org.exampl] 
06-13 14:07:19.876+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:07:19.876+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:07:19.886+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:07:19.886+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x3200002 FAILED!
06-13 14:07:19.896+0900 E/weather-agent(17796): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-13 14:07:19.896+0900 I/CAPI_APPFW_APPLICATION(17796): service_app_main.c: service_app_exit(446) > service_app_exit
06-13 14:07:19.896+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:07:19.896+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:07:19.896+0900 E/weather-agent(17796): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-13 14:07:19.896+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:07:19.906+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:07:19.906+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(3)
06-13 14:07:19.916+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:07:19.936+0900 I/ISE_MULTI(  804): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:true][0m
06-13 14:07:19.936+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:07:19.936+0900 I/APP_CORE(17520): appcore-efl.c: __do_app(514) > [APP 17520] Event: RESET State: CREATED
06-13 14:07:19.936+0900 I/CAPI_APPFW_APPLICATION(17520): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 14:07:19.936+0900 E/EFL     (17520): edje<17520> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:07:19.936+0900 E/EFL     (17520): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:07:19.936+0900 E/EFL     (17520): edje<17520> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:07:19.936+0900 E/EFL     (17520): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:07:19.936+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:07:19.936+0900 W/APP_CORE(17520): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3800003
06-13 14:07:19.946+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
06-13 14:07:20.036+0900 W/AUL_AMD (  607): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-13 14:07:20.046+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 17796
06-13 14:07:20.046+0900 I/Tizen::App( 1175): (243) > App[com.samsung.weather-m-agent] pid[17796] terminate event is forwarded
06-13 14:07:20.046+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:07:20.046+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 17796, ]
06-13 14:07:20.046+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:07:20.046+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-13 14:07:20.046+0900 I/Tizen::App( 1175): (512) > Not registered pid(17796)
06-13 14:07:20.046+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.weather-m-agent]
06-13 14:07:20.046+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:07:20.046+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 17796
06-13 14:07:20.046+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:07:20.046+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 17796.
06-13 14:07:20.056+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(17520) status(0)
06-13 14:07:20.056+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(17520) status(0)
06-13 14:07:20.056+0900 I/APP_CORE(17493): appcore-efl.c: __do_app(514) > [APP 17493] Event: PAUSE State: RUNNING
06-13 14:07:20.056+0900 I/CAPI_APPFW_APPLICATION(17493): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:07:20.066+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(17493) status(4)
06-13 14:07:20.066+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(17493)
06-13 14:07:20.066+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 17493, appid: org.example.client, status: bg
06-13 14:07:20.066+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(17520) status(3)
06-13 14:07:20.066+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:07:20.066+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:07:20.066+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(17520)
06-13 14:07:20.066+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 17520, appid: com.samsung.task-mgr, status: fg
06-13 14:07:20.076+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:07:20.076+0900 I/APP_CORE(17520): appcore-efl.c: __do_app(514) > [APP 17520] Event: RESUME State: CREATED
06-13 14:07:20.086+0900 I/TIZEN_N_EFL_UTIL_WINDOW(17493): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 21
06-13 14:07:20.086+0900 E/APP_CORE(17493): appcore-efl.c: _capture_and_make_file(1619) > win[3200002] widget[720] height[1280]
06-13 14:07:20.086+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
06-13 14:07:20.096+0900 I/APP_CORE(17520): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-13 14:07:20.096+0900 I/APP_CORE(17520): appcore-efl.c: __do_app(625) > [APP 17520] Initial Launching, call the resume_cb
06-13 14:07:20.096+0900 I/CAPI_APPFW_APPLICATION(17520): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:07:20.106+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17426312
06-13 14:07:20.106+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 14:07:20.106+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:07:20.106+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:07:20.106+0900 E/STARTER (  721): )
06-13 14:07:20.106+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:07:20.106+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:07:20.106+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:07:20.106+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:07:20.446+0900 E/EFL     (17520): ecore_x<17520> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17426651
06-13 14:07:20.567+0900 E/EFL     (17520): ecore_x<17520> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17426773
06-13 14:07:20.727+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1776
06-13 14:07:20.737+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 14:07:20.737+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 17520.
06-13 14:07:21.027+0900 E/EFL     (17520): ecore_x<17520> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17427230
06-13 14:07:21.087+0900 E/EFL     (17520): ecore_x<17520> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17427296
06-13 14:07:21.397+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:07:21.397+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:07:21.397+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(17520)
06-13 14:07:21.397+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 17520, appid: com.samsung.task-mgr, status: bg
06-13 14:07:21.407+0900 I/CAPI_APPFW_APPLICATION(17520): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:07:21.407+0900 W/TASK_MGR_LITE(17520): task-mgr-lite.c: _pause_app(406) > 
06-13 14:07:21.407+0900 I/CAPI_APPFW_APPLICATION(17520): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:07:21.407+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:07:21.407+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 17493
06-13 14:07:21.407+0900 W/AUL     (17520): launch.c: app_request_to_launchpad(396) > request cmd(4) to(17493)
06-13 14:07:21.407+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 4
06-13 14:07:21.407+0900 I/APP_CORE(17493): appcore-efl.c: __do_app(514) > [APP 17493] Event: TERMINATE State: PAUSED
06-13 14:07:21.407+0900 W/AUL_AMD (  607): amd_launch.c: __reply_handler(1083) > listen fd(32) , send fd(31), pid(17493), cmd(4)
06-13 14:07:21.407+0900 W/AUL     (17520): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
06-13 14:07:21.407+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:07:21.407+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:07:21.407+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:07:21.407+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:07:21.417+0900 E/TASK_MGR_LITE(17520): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 14:07:21.417+0900 I/TIZEN_N_EFL_UTIL_WINDOW(17493): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 10
06-13 14:07:21.417+0900 E/APP_CORE(17493): appcore-efl.c: _capture_and_make_file(1619) > win[3200002] widget[720] height[1280]
06-13 14:07:21.417+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 33
06-13 14:07:21.417+0900 E/APP_CORE(17493): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.client]
06-13 14:07:21.427+0900 I/CAPI_APPFW_APPLICATION(17493): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:07:21.437+0900 E/TASK_MGR_LITE(17520): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
06-13 14:07:21.437+0900 E/APP_CORE(17520): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 14:07:21.447+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:07:21.447+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:07:21.457+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:07:21.457+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:07:21.457+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:07:21.457+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:07:21.487+0900 I/MALI    (17520): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=17520   close drm_fd=30 
06-13 14:07:21.497+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 14:07:21.537+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:07:21.537+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:07:21.537+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:07:21.537+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:07:21.558+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:07:21.558+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:07:21.568+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 14:07:21.578+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:07:21.578+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:07:21.578+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:07:21.578+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:07:21.578+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:07:21.588+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:07:21.598+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:07:21.598+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 14:07:21.598+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:07:21.598+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:07:21.598+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 14:07:21.618+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:07:21.708+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:07:21.708+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:07:21.748+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17427884
06-13 14:07:21.748+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 14:07:21.748+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17427959
06-13 14:07:21.748+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 14:07:21.778+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 17493 pgid = 17493
06-13 14:07:21.778+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(17493)
06-13 14:07:21.818+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:07:21.818+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:07:21.818+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:07:21.818+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 17493
06-13 14:07:21.818+0900 I/Tizen::App( 1175): (243) > App[org.example.client] pid[17493] terminate event is forwarded
06-13 14:07:21.818+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:07:21.818+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [org.example.client, 17493, ]
06-13 14:07:21.818+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:07:21.818+0900 I/Tizen::App( 1175): (506) > TerminatedApp(org.example.client)
06-13 14:07:21.818+0900 I/Tizen::App( 1175): (512) > Not registered pid(17493)
06-13 14:07:21.818+0900 I/Tizen::System( 1175): (246) > Terminated app [org.example.client]
06-13 14:07:21.818+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:07:21.828+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 17493
06-13 14:07:21.828+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1779
06-13 14:07:21.838+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:07:21.838+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for org.example.client, 17493.
06-13 14:07:21.858+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 17520 pgid = 17520
06-13 14:07:21.858+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(17520)
06-13 14:07:21.868+0900 I/UXT     (17811): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:07:21.918+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:07:21.918+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:07:21.918+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:07:21.918+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[17520] terminate event is forwarded
06-13 14:07:21.918+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:07:21.918+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 17520, ]
06-13 14:07:21.918+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:07:21.918+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 14:07:21.918+0900 I/Tizen::App( 1175): (512) > Not registered pid(17520)
06-13 14:07:21.918+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 14:07:21.918+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:07:21.918+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 17520
06-13 14:07:21.928+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 17520
06-13 14:07:21.928+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 17520
06-13 14:07:21.928+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1780
06-13 14:07:21.948+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:07:21.948+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 17520.
06-13 14:07:21.968+0900 E/TBM     (17811): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:07:21.968+0900 I/MALI    (17811): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=17811   open drm_fd=30 
06-13 14:07:21.988+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17428121
06-13 14:07:21.988+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 14:07:21.998+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17428208
06-13 14:07:21.998+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 14:07:22.108+0900 E/EFL     (17811): edje<17811> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:07:22.108+0900 E/EFL     (17811): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:07:22.108+0900 E/EFL     (17811): edje<17811> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:07:22.108+0900 E/EFL     (17811): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:07:22.108+0900 E/EFL     (17811): edje<17811> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:07:22.108+0900 E/EFL     (17811): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:07:24.290+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: MEM_FLUSH State: PAUSED
06-13 14:07:24.891+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:07:26.402+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:07:26.402+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:07:26.402+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:07:30.726+0900 E/AUL_AMD (  607): amd_launch.c: _amd_proc_find_proc_info(1914) > proc info not found
06-13 14:07:31.617+0900 E/PKGMGR_SERVER(17855): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:07:31.667+0900 E/PKGMGR  (17853): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
06-13 14:07:31.707+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:07:31.717+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:07:31.727+0900 E/PKGMGR_SERVER(17855): pkgmgr-server.c: sighandler(417) > child NORMAL exit [17858]
06-13 14:07:33.789+0900 E/PKGMGR_SERVER(17855): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:07:33.789+0900 E/PKGMGR_SERVER(17855): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:07:36.722+0900 E/PKGMGR  (17944): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
06-13 14:07:36.802+0900 E/PKGMGR_SERVER(17946): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:07:36.852+0900 E/PKGMGR_SERVER(17946): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
06-13 14:07:36.862+0900 E/PKGMGR_SERVER(17946): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
06-13 14:07:36.862+0900 E/PKGMGR  (17944): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[179440002]
06-13 14:07:37.013+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
06-13 14:07:37.013+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [96]
06-13 14:07:37.013+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:07:37.013+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:07:37.023+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
06-13 14:07:37.033+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-13 14:07:37.033+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [30]
06-13 14:07:37.033+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
06-13 14:07:37.033+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:07:37.033+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:07:37.323+0900 E/rpm-installer(17949): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
06-13 14:07:37.323+0900 E/rpm-installer(17949): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
06-13 14:07:37.383+0900 E/PKGMGR_PARSER(17949): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
06-13 14:07:37.393+0900 I/PRIVACY-MANAGER-CLIENT(17949): SocketClient.cpp: SocketClient(37) > Client created
06-13 14:07:37.393+0900 I/PRIVACY-MANAGER-CLIENT(17949): SocketClient.cpp: connect(62) > Client connected
06-13 14:07:37.393+0900 I/PRIVACY-MANAGER-SERVER(  914): SocketService.cpp: mainloop(230) > Got incoming connection
06-13 14:07:37.403+0900 I/PRIVACY-MANAGER-CLIENT(17949): SocketClient.cpp: disconnect(72) > Client disconnected
06-13 14:07:37.403+0900 E/PKGMGR_CERT(17949): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
06-13 14:07:37.403+0900 E/PKGMGR_CERT(17949): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
06-13 14:07:37.413+0900 E/PKGMGR_CERT(17949): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
06-13 14:07:37.443+0900 E/rpm-installer(17949): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
06-13 14:07:37.453+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:07:37.453+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:07:37.453+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
06-13 14:07:37.453+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
06-13 14:07:37.453+0900 E/ESD     (  898): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
06-13 14:07:37.463+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
06-13 14:07:37.463+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
06-13 14:07:37.463+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
06-13 14:07:38.794+0900 E/PKGMGR_SERVER(17946): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-13 14:07:39.175+0900 E/PKGMGR_SERVER(17946): pkgmgr-server.c: sighandler(417) > child NORMAL exit [17949]
06-13 14:07:40.796+0900 E/PKGMGR_SERVER(17946): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:07:40.796+0900 E/PKGMGR_SERVER(17946): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:07:41.447+0900 E/PKGMGR  (17997): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
06-13 14:07:41.527+0900 E/PKGMGR_SERVER(17999): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:07:41.577+0900 E/PKGMGR_SERVER(17999): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
06-13 14:07:41.587+0900 E/PKGMGR_INFO(17999): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
06-13 14:07:41.597+0900 E/rpm-installer(17999): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
06-13 14:07:41.607+0900 E/PKGMGR_SERVER(17999): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-13 14:07:41.607+0900 E/PKGMGR  (17997): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[179970002]
06-13 14:07:41.737+0900 E/PKGMGR_INSTALLER(18002): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
06-13 14:07:41.737+0900 E/rpm-installer(18002): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
06-13 14:07:41.747+0900 E/rpm-installer(18002): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
06-13 14:07:41.747+0900 E/rpm-installer(18002): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
06-13 14:07:41.747+0900 E/rpm-installer(18002): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-13 14:07:41.747+0900 E/rpm-installer(18002): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
06-13 14:07:41.747+0900 E/rpm-installer(18002): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-13 14:07:41.847+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
06-13 14:07:41.847+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
06-13 14:07:41.857+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-13 14:07:41.857+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [30]
06-13 14:07:41.857+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
06-13 14:07:41.857+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:07:41.857+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:07:41.857+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:07:41.857+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:07:42.158+0900 E/rpm-installer(18002): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-13 14:07:42.158+0900 E/rpm-installer(18002): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-13 14:07:42.158+0900 E/rpm-installer(18002): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-13 14:07:42.158+0900 E/rpm-installer(18002): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-13 14:07:42.158+0900 E/rpm-installer(18002): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-13 14:07:42.158+0900 E/rpm-installer(18002): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-13 14:07:42.168+0900 E/PKGMGR_PARSER(18002): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-13 14:07:42.168+0900 E/PKGMGR_PARSER(18002): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-13 14:07:42.208+0900 I/PRIVACY-MANAGER-CLIENT(18002): SocketClient.cpp: SocketClient(37) > Client created
06-13 14:07:42.408+0900 E/PKGMGR_PARSER(18002): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-13 14:07:42.428+0900 E/PKGMGR_CERT(18002): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-13 14:07:42.428+0900 E/PKGMGR_CERT(18002): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 107
06-13 14:07:42.428+0900 E/PKGMGR_CERT(18002): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 107
06-13 14:07:42.428+0900 E/PKGMGR_CERT(18002): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 44 1
06-13 14:07:42.428+0900 E/PKGMGR_CERT(18002): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 38 2
06-13 14:07:42.428+0900 E/PKGMGR_CERT(18002): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 39 2
06-13 14:07:42.428+0900 E/PKGMGR_CERT(18002): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 45 1
06-13 14:07:42.438+0900 E/PKGMGR_CERT(18002): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-13 14:07:42.438+0900 E/rpm-installer(18002): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1956) > skip! empty dirpath=[/opt/usr/apps/org.example.client/lib]
06-13 14:07:42.438+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
06-13 14:07:42.438+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [60]
06-13 14:07:42.438+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
06-13 14:07:42.438+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:07:42.438+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:07:42.458+0900 E/rpm-installer(18002): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-13 14:07:42.478+0900 E/rpm-installer(18002): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-13 14:07:42.478+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:07:42.478+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
06-13 14:07:42.478+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:07:42.478+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [100]
06-13 14:07:42.478+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
06-13 14:07:43.789+0900 E/PKGMGR_SERVER(17999): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-13 14:07:44.370+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
06-13 14:07:44.370+0900 I/Tizen::App( 1175): (78) > Installation is Completed. [Package = org.example.client]
06-13 14:07:44.370+0900 I/Tizen::App( 1175): (671) > Enter. package(org.example.client), installationResult(0)
06-13 14:07:44.380+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-13 14:07:44.380+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-13 14:07:44.380+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-13 14:07:44.420+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:07:44.420+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:07:44.430+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-13 14:07:44.430+0900 I/Tizen::App( 1175): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
06-13 14:07:44.440+0900 I/Tizen::App( 1175): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
06-13 14:07:44.450+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
06-13 14:07:44.450+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
06-13 14:07:44.450+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-13 14:07:44.450+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-13 14:07:44.450+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
06-13 14:07:44.460+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
06-13 14:07:44.460+0900 E/HOME_APPS( 1167): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
06-13 14:07:44.460+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
06-13 14:07:44.460+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 14:07:44.460+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 14:07:44.460+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
06-13 14:07:44.460+0900 E/PKGMGR_INFO( 1175): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-13 14:07:44.460+0900 I/Tizen::App( 1175): (683) > Application count(1) in this package
06-13 14:07:44.460+0900 I/Tizen::App( 1175): (840) > Enter.
06-13 14:07:44.470+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 14:07:44.470+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 14:07:44.470+0900 I/Tizen::App( 1175): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
06-13 14:07:44.470+0900 I/Tizen::App( 1175): (131) > Enter
06-13 14:07:44.480+0900 I/Tizen::App( 1175): (703) > Exit.
06-13 14:07:44.480+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
06-13 14:07:44.480+0900 I/Tizen::App( 1175): (137) > org.example.client does not have launch condition
06-13 14:07:44.480+0900 I/Tizen::App( 1175): (883) > Exit.
06-13 14:07:44.480+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-13 14:07:44.500+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-13 14:07:44.570+0900 E/PKGMGR_SERVER(17999): pkgmgr-server.c: sighandler(417) > child NORMAL exit [18002]
06-13 14:07:45.010+0900 I/Tizen::System( 1175): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
06-13 14:07:45.791+0900 E/PKGMGR_SERVER(17999): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:07:45.791+0900 E/PKGMGR_SERVER(17999): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:07:48.694+0900 W/AUL     (18058): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 14:07:48.694+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:07:48.704+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-13 14:07:48.714+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-13 14:07:48.714+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:07:48.714+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 18058
06-13 14:07:48.714+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:07:48.724+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 14:07:48.724+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:07:48.724+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:07:48.724+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:07:48.724+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:07:48.744+0900 I/abc     (17781): abc
06-13 14:07:48.744+0900 I/CAPI_APPFW_APPLICATION(17781): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:07:48.744+0900 I/CAPI_APPFW_APPLICATION(17781): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:07:48.774+0900 E/TBM     (17781): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:07:48.824+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 17781, appid: org.example.client
06-13 14:07:48.824+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:07:48.834+0900 W/AUL     (18058): launch.c: app_request_to_launchpad(425) > request cmd(0) result(17781)
06-13 14:07:49.064+0900 W/CRASH_MANAGER(18073): worker.c: worker_job(1199) > 0617781636c69149733046
