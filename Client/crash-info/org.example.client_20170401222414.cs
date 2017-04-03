S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 11643
Date: 2017-04-01 22:24:14+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 11643, uid 5000)

Register Information
r0   = 0x74706f2f, r1   = 0x00000000
r2   = 0x00000001, r3   = 0x00000000
r4   = 0xb89f1a58, r5   = 0xb4038a3c
r6   = 0xb4038a50, r7   = 0xbe96947c
r8   = 0xbe969478, r9   = 0xb8859c98
r10  = 0xbe969498, fp   = 0x00000004
ip   = 0x000000ec, sp   = 0xbe96940c
lr   = 0xb4026601, pc   = 0xb6766954
cpsr = 0x20040010

Memory Information
MemTotal:   987012 KB
MemFree:    119128 KB
Buffers:     49020 KB
Cached:     279648 KB
VmPeak:     124824 KB
VmSize:     106708 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       33344 KB
VmRSS:       23132 KB
VmData:      33484 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35732 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 11643 TID = 11643
11643 11644 12768 

Maps Information
b132f000 b1340000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1350000 b1355000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b141a000 b1422000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1434000 b1c33000 rw-p [stack:12768]
b1c33000 b1c34000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c44000 b1c58000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c6c000 b1c6d000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c7d000 b1c80000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c91000 b1c92000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1ca2000 b1ca4000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1cb4000 b1cb6000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1cc6000 b1cd6000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1ce6000 b1cf2000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2834000 b283b000 r-xp /usr/lib/libefl-extension.so.0.1.0
b284e000 b2854000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2864000 b2874000 r-xp /opt/usr/apps/org.example.client/bin/client
b29bd000 b2aa0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ad7000 b2aff000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b11000 b3310000 rw-p [stack:11644]
b3310000 b3312000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3322000 b332c000 r-xp /lib/libnss_files-2.20-2014.11.so
b333d000 b3346000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3357000 b3368000 r-xp /lib/libnsl-2.20-2014.11.so
b337b000 b3381000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3392000 b3393000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33bb000 b33c2000 r-xp /usr/lib/libminizip.so.1.0.0
b33d2000 b33d7000 r-xp /usr/lib/libstorage.so.0.1
b33e7000 b3446000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b345c000 b3470000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3480000 b34c4000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34d4000 b34dc000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34ec000 b351c000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b352f000 b35e8000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35fc000 b364f000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3660000 b367b000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b368b000 b374c000 r-xp /usr/lib/libprotobuf.so.9.0.1
b375f000 b376f000 r-xp /usr/lib/libefl-assist.so.0.1.0
b377f000 b378c000 r-xp /usr/lib/libmdm-common.so.1.0.98
b379d000 b37a4000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b37b4000 b37f5000 r-xp /usr/lib/libmdm.so.1.2.12
b3805000 b380d000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b381c000 b382c000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b384d000 b38ad000 r-xp /usr/lib/libasound.so.2.0.0
b38bf000 b38c2000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38d2000 b38d5000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38e5000 b38ea000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38fa000 b38fb000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b390b000 b3916000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b392a000 b3931000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3941000 b3947000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3957000 b395c000 r-xp /usr/lib/libmmfsession.so.0.0.1
b396c000 b3987000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3997000 b399e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b39ae000 b39b1000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39c2000 b39f0000 r-xp /usr/lib/libidn.so.11.5.44
b3a00000 b3a16000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a27000 b3a31000 r-xp /usr/lib/libcares.so.2.1.0
b3a41000 b3a4b000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a5b000 b3a5d000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a6d000 b3a6e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a7e000 b3a82000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a93000 b3abb000 r-xp /usr/lib/libui-extension.so.0.1.0
b3acc000 b3af5000 r-xp /usr/lib/libturbojpeg.so
b3b15000 b3b1b000 r-xp /usr/lib/libgif.so.4.1.6
b3b2b000 b3b71000 r-xp /usr/lib/libcurl.so.4.3.0
b3b82000 b3ba3000 r-xp /usr/lib/libexif.so.12.3.3
b3bbe000 b3bd3000 r-xp /usr/lib/libtts.so
b3be4000 b3bec000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bfc000 b3cc2000 r-xp /usr/lib/libdali-core.so.0.0.0
b3ce2000 b3dda000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3df9000 b3ec7000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ede000 b3ee0000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ef0000 b3ef6000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3f06000 b3f29000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f3a000 b3f3c000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f4c000 b3f4e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f5f000 b3f64000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f7b000 b3f7d000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f8d000 b3f94000 r-xp /usr/lib/libsensord-share.so
b3fa4000 b3fbc000 r-xp /usr/lib/libsensor.so.1.1.0
b3fcd000 b3fd0000 r-xp /usr/lib/libXv.so.1.0.0
b3fe0000 b3fe5000 r-xp /usr/lib/libutilX.so.1.1.0
b3ff5000 b3ffa000 r-xp /usr/lib/libappcore-common.so.1.1
b400a000 b4011000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b4024000 b4028000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4039000 b4117000 r-xp /usr/lib/libCOREGL.so.4.0
b4137000 b413a000 r-xp /usr/lib/libuuid.so.1.3.0
b414a000 b4161000 r-xp /usr/lib/libblkid.so.1.1.0
b4172000 b4174000 r-xp /usr/lib/libXau.so.6.0.0
b4184000 b41cb000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41dd000 b41e3000 r-xp /usr/lib/libjson-c.so.2.0.1
b41f4000 b41f8000 r-xp /usr/lib/libogg.so.0.7.1
b4208000 b422a000 r-xp /usr/lib/libvorbis.so.0.4.3
b423a000 b431e000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b433a000 b433d000 r-xp /usr/lib/libEGL.so.1.4
b434e000 b4354000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4364000 b4366000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4376000 b4383000 r-xp /usr/lib/libGLESv2.so.2.0
b4394000 b43f6000 r-xp /usr/lib/libpixman-1.so.0.28.2
b440b000 b4423000 r-xp /usr/lib/libmount.so.1.1.0
b4435000 b4449000 r-xp /usr/lib/libxcb.so.1.1.0
b4459000 b4460000 r-xp /lib/libcrypt-2.20-2014.11.so
b4498000 b449a000 r-xp /usr/lib/libiri.so
b44aa000 b44b5000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44c6000 b44fc000 r-xp /usr/lib/libpulse.so.0.16.2
b450d000 b4550000 r-xp /usr/lib/libsndfile.so.1.0.25
b4565000 b457a000 r-xp /lib/libexpat.so.1.5.2
b458c000 b464a000 r-xp /usr/lib/libcairo.so.2.11200.14
b465e000 b4666000 r-xp /usr/lib/libdrm.so.2.4.0
b4676000 b4679000 r-xp /usr/lib/libdri2.so.0.0.0
b4689000 b46d7000 r-xp /usr/lib/libssl.so.1.0.0
b46ec000 b46f8000 r-xp /usr/lib/libeeze.so.1.13.0
b4709000 b4712000 r-xp /usr/lib/libethumb.so.1.13.0
b4722000 b4725000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4735000 b48ec000 r-xp /usr/lib/libcrypto.so.1.0.0
b56d7000 b56e0000 r-xp /usr/lib/libXi.so.6.1.0
b56f0000 b56f2000 r-xp /usr/lib/libXgesture.so.7.0.0
b5702000 b5706000 r-xp /usr/lib/libXtst.so.6.1.0
b5716000 b571c000 r-xp /usr/lib/libXrender.so.1.3.0
b572c000 b5732000 r-xp /usr/lib/libXrandr.so.2.2.0
b5742000 b5744000 r-xp /usr/lib/libXinerama.so.1.0.0
b5755000 b5758000 r-xp /usr/lib/libXfixes.so.3.1.0
b5768000 b5773000 r-xp /usr/lib/libXext.so.6.4.0
b5783000 b5785000 r-xp /usr/lib/libXdamage.so.1.1.0
b5795000 b5797000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57a7000 b5889000 r-xp /usr/lib/libX11.so.6.3.0
b589d000 b58a4000 r-xp /usr/lib/libXcursor.so.1.0.2
b58b4000 b58cc000 r-xp /usr/lib/libudev.so.1.6.0
b58ce000 b58d1000 r-xp /lib/libattr.so.1.1.0
b58e1000 b5901000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5902000 b5907000 r-xp /usr/lib/libffi.so.6.0.2
b5918000 b5930000 r-xp /lib/libz.so.1.2.8
b5940000 b5942000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5952000 b5a27000 r-xp /usr/lib/libxml2.so.2.9.2
b5a3c000 b5ad7000 r-xp /usr/lib/libstdc++.so.6.0.20
b5af3000 b5af6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b06000 b5b1f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b30000 b5b41000 r-xp /lib/libresolv-2.20-2014.11.so
b5b55000 b5bcf000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5be4000 b5be6000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bf6000 b5bfd000 r-xp /usr/lib/libembryo.so.1.13.0
b5c0d000 b5c17000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c28000 b5c40000 r-xp /usr/lib/libpng12.so.0.50.0
b5c51000 b5c74000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c95000 b5ca9000 r-xp /usr/lib/libector.so.1.13.0
b5cba000 b5cd2000 r-xp /usr/lib/liblua-5.1.so
b5ce3000 b5d3a000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d4e000 b5d76000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d87000 b5d9a000 r-xp /usr/lib/libfribidi.so.0.3.1
b5dab000 b5de5000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5df6000 b5e04000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e14000 b5e1c000 r-xp /usr/lib/libtbm.so.1.0.0
b5e2c000 b5e39000 r-xp /usr/lib/libeio.so.1.13.0
b5e49000 b5e4b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e5b000 b5e60000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e70000 b5e87000 r-xp /usr/lib/libefreet.so.1.13.0
b5e99000 b5eb9000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ec9000 b5ee9000 r-xp /usr/lib/libecore_con.so.1.13.0
b5eeb000 b5ef1000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f01000 b5f12000 r-xp /usr/lib/libemotion.so.1.13.0
b5f23000 b5f2a000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f3a000 b5f49000 r-xp /usr/lib/libeo.so.1.13.0
b5f5a000 b5f6c000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f7d000 b5f82000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f92000 b5fab000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fbb000 b5fd8000 r-xp /usr/lib/libeet.so.1.13.0
b5ff1000 b6039000 r-xp /usr/lib/libeina.so.1.13.0
b604a000 b605a000 r-xp /usr/lib/libefl.so.1.13.0
b606b000 b6150000 r-xp /usr/lib/libicuuc.so.51.1
b616d000 b62ad000 r-xp /usr/lib/libicui18n.so.51.1
b62c4000 b62fc000 r-xp /usr/lib/libecore_x.so.1.13.0
b630e000 b6311000 r-xp /lib/libcap.so.2.21
b6321000 b634a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b635b000 b6362000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6374000 b63ab000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63bc000 b64a7000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64ba000 b6533000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6545000 b654a000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b655a000 b6564000 r-xp /usr/lib/libvconf.so.0.2.45
b6574000 b6576000 r-xp /usr/lib/libvasum.so.0.3.1
b6586000 b6588000 r-xp /usr/lib/libttrace.so.1.1
b6598000 b659b000 r-xp /usr/lib/libiniparser.so.0
b65ab000 b65d1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65e1000 b65e6000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65f7000 b660e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b661f000 b668a000 r-xp /lib/libm-2.20-2014.11.so
b669b000 b66a1000 r-xp /lib/librt-2.20-2014.11.so
b66b2000 b66bf000 r-xp /usr/lib/libunwind.so.8.0.1
b66f5000 b6819000 r-xp /lib/libc-2.20-2014.11.so
b682e000 b6847000 r-xp /lib/libgcc_s-4.9.so.1
b6857000 b6939000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b694a000 b6974000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6985000 b69c1000 r-xp /usr/lib/libsystemd.so.0.4.0
b69c3000 b6a46000 r-xp /usr/lib/libedje.so.1.13.0
b6a59000 b6a77000 r-xp /usr/lib/libecore.so.1.13.0
b6a97000 b6c1e000 r-xp /usr/lib/libevas.so.1.13.0
b6c53000 b6c67000 r-xp /lib/libpthread-2.20-2014.11.so
b6c7b000 b6eaf000 r-xp /usr/lib/libelementary.so.1.13.0
b6ede000 b6ee2000 r-xp /usr/lib/libsmack.so.1.0.0
b6ef2000 b6ef9000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f09000 b6f0b000 r-xp /usr/lib/libdlog.so.0.0.0
b6f1b000 b6f1e000 r-xp /usr/lib/libbundle.so.0.1.22
b6f2e000 b6f30000 r-xp /lib/libdl-2.20-2014.11.so
b6f41000 b6f59000 r-xp /usr/lib/libaul.so.0.1.0
b6f6d000 b6f72000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f83000 b6f90000 r-xp /usr/lib/liblptcp.so
b6fa2000 b6fa6000 r-xp /usr/lib/libsys-assert.so
b6fb7000 b6fd7000 r-xp /lib/ld-2.20-2014.11.so
b6fe8000 b6fed000 r-xp /usr/bin/launchpad-loader
b87f3000 b8b60000 rw-p [heap]
be949000 be96a000 rw-p [stack]
b87f3000 b8b60000 rw-p [heap]
be949000 be96a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11643)
Call Stack Count: 1
 0: cfree + 0x28 (0xb6766954) [/lib/libc.so.6] + 0x71954
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
p: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.655+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-01 22:23:15.655+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.655+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.655+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.655+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.655+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.655+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.655+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.655+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.655+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
04-01 22:23:15.665+0900 I/ISE_MULTI(  858): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
04-01 22:23:15.665+0900 W/CANDIDATE(  858): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-01 22:23:15.665+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
04-01 22:23:15.665+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.665+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-01 22:23:15.675+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.675+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.675+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.675+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.675+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.675+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.675+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.675+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.675+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
04-01 22:23:15.755+0900 W/CANDIDATE(  858): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-01 22:23:15.755+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
04-01 22:23:15.755+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.755+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-01 22:23:15.755+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.755+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.755+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.765+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-01 22:23:15.765+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.765+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.765+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.765+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.765+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:15.765+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
04-01 22:23:15.835+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(11643) status(0)
04-01 22:23:15.835+0900 W/ISF_PANEL_EFL(  775): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
04-01 22:23:15.835+0900 W/ISF_PANEL_EFL(  775): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
04-01 22:23:16.116+0900 E/RESOURCED(  685): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.976
04-01 22:23:16.126+0900 I/Tizen::App( 1247): (499) > LaunchedApp(org.example.client)
04-01 22:23:16.126+0900 I/Tizen::App( 1247): (733) > Finished invoking application event listener for org.example.client, 11643.
04-01 22:23:16.856+0900 I/UXT     (12774): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-01 22:23:17.637+0900 E/EFL     (11643): ecore_x<11643> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=29606340
04-01 22:23:17.637+0900 E/EFL     (11643): ecore_x<11643> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=29606400
04-01 22:23:17.637+0900 I/ISE_MULTI(  858): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
04-01 22:23:17.647+0900 W/ISF_PANEL_EFL(  775): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x7800002 FAILED!
04-01 22:23:17.657+0900 I/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
04-01 22:23:17.707+0900 I/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
04-01 22:23:17.717+0900 I/SWIFTKEY(  712): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
04-01 22:23:17.717+0900 W/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
04-01 22:23:17.797+0900 I/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-01 22:23:17.807+0900 W/CANDIDATE(  858): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-01 22:23:17.817+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
04-01 22:23:17.817+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:17.817+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-01 22:23:17.817+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:17.817+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:17.817+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:17.817+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:17.817+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:17.817+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:17.817+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:17.817+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 22:23:17.817+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
04-01 22:23:18.298+0900 E/EFL     (11643): ecore_x<11643> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=29606979
04-01 22:23:18.298+0900 E/EFL     (11643): ecore_x<11643> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=29607062
04-01 22:23:18.308+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(10946) status(3)
04-01 22:23:18.308+0900 W/AUL_AMD (  605): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-01 22:23:18.308+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-01 22:23:18.308+0900 W/AUL     (  605): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.myfile-lite(10946)
04-01 22:23:18.308+0900 W/AUL     (  605): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 10946, appid: com.samsung.myfile-lite, status: fg
04-01 22:23:18.348+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-01 22:23:18.348+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-01 22:23:18.368+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(10946) status(0)
04-01 22:23:18.388+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(11643) status(4)
04-01 22:23:18.388+0900 W/AUL     (  605): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(11643)
04-01 22:23:18.388+0900 W/AUL     (  605): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 11643, appid: org.example.client, status: bg
04-01 22:23:18.398+0900 I/Tizen::System( 1247): (259) > Active app [com.samsun], current [org.exampl] 
04-01 22:23:18.398+0900 I/Tizen::Io( 1247): (729) > Entry not found
04-01 22:23:18.398+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 36
04-01 22:23:18.408+0900 I/ISE_MULTI(  858): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:true][0m
04-01 22:23:18.428+0900 I/SWIFTKEY(  712): swiftkey_engine.cpp: IME_Learn_sentence(2373) > [0;36mDLM write[0m
04-01 22:23:18.438+0900 I/Tizen::System( 1247): (157) > change brightness system value.
04-01 22:23:18.438+0900 I/TIZEN_N_SOUND_MANAGER(  932): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-01 22:23:18.438+0900 E/TIZEN_N_SOUND_MANAGER(  932): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-01 22:23:18.448+0900 I/TIZEN_N_SOUND_MANAGER(  932): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-01 22:23:18.448+0900 E/TIZEN_N_SOUND_MANAGER(  932): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-01 22:23:18.448+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 15
04-01 22:23:18.488+0900 I/APP_CORE(10946): appcore-efl.c: __do_app(514) > [APP 10946] Event: RESUME State: PAUSED
04-01 22:23:18.488+0900 I/CAPI_APPFW_APPLICATION(10946): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-01 22:23:18.498+0900 I/APP_CORE(11643): appcore-efl.c: __do_app(514) > [APP 11643] Event: PAUSE State: RUNNING
04-01 22:23:18.498+0900 I/CAPI_APPFW_APPLICATION(11643): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-01 22:23:18.508+0900 I/TIZEN_N_EFL_UTIL_WINDOW(11643): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 17
04-01 22:23:18.508+0900 E/APP_CORE(11643): appcore-efl.c: _capture_and_make_file(1619) > win[7800002] widget[720] height[1280]
04-01 22:23:18.518+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 33
04-01 22:23:19.729+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=29608492
04-01 22:23:19.839+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=29608614
04-01 22:23:20.540+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=29609317
04-01 22:23:20.670+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=29609439
04-01 22:23:20.690+0900 E/MYFILES (10946): mf-callback.c: mf_callback_upper_click_cb(372) > [31map->mf_Status.preViewType is [1] view_type is [5] [0m
04-01 22:23:20.690+0900 E/MYFILES (10946): mf-util.c: mf_util_path_top_get(2793) > [31mFailed to get the top[0m
04-01 22:23:20.690+0900 E/MYFILES (10946): mf-view.c: mf_view_naviframe_is_tabbar_style(699) > [31m[0m
04-01 22:23:20.690+0900 E/MYFILES (10946): mf-navi-bar.c: mf_navi_bar_layout_state_set(409) > [31m>>>  type is [5][0m
04-01 22:23:20.690+0900 E/MYFILES (10946): mf-view.c: mf_view_naviframe_layout_clean(768) > [31m[0m
04-01 22:23:20.730+0900 E/MYFILES (10946): mf-tray-item.c: mf_category_widgets_create(751) > [31mbegin[0m
04-01 22:23:20.740+0900 E/MYFILES (10946): mf-tray-item.c: mf_category_widgets_create(818) > [31mmf_category_widget_create_count=1[0m
04-01 22:23:20.740+0900 E/MYFILES (10946): mf-tray-item.c: mf_category_create(1155) > [31m[0m
04-01 22:23:20.740+0900 E/MYFILES (10946): mf-storage-space.c: mf_storage_get_history_files_size(709) > [31mdownload history db open failed[0m
04-01 22:23:20.750+0900 E/MYFILES (10946): mf-util.c: mf_util_generate_root_view_file_list(1637) > [31mStorage_state is [1] [0m
04-01 22:23:20.760+0900 E/CLOUD_CONTENT_SYNC_CLIENT(10946): cs_client.c: cloud_content_sync_folder_destroy(1163) > [0;31m* Critical * Invalid param[0;m
04-01 22:23:20.760+0900 E/CLOUD_CONTENT_SYNC_CLIENT(10946): cs_client.c: cloud_content_sync_folder_get_root(998) > [0;31m* Critical * Invalid handle[0;m
04-01 22:23:20.790+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_group_index_label_get(1780) > [31mparams->m_ItemName->str, mf_util_get_text(params->m_ItemName->str) is [IDS_MF_HEADER_LOCAL_STORAGE_ABB] [로컬 저장공간][0m
04-01 22:23:20.800+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_group_index_label_get(1780) > [31mparams->m_ItemName->str, mf_util_get_text(params->m_ItemName->str) is [IDS_MF_HEADER_CLOUD_STORAGE] [클라우드 저장공간][0m
04-01 22:23:20.800+0900 E/MYFILES (10946): mf-cloud-view.c: mf_cloud_root_item_label_get(669) > [31m>>> part : elm.text.main.left.top[0m
04-01 22:23:20.800+0900 E/MYFILES (10946): mf-cloud-view.c: mf_cloud_root_item_label_get(669) > [31m>>> part : elm.text.sub.left.bottom[0m
04-01 22:23:20.800+0900 E/MYFILES (10946): mf-cloud-item-operation.c: mf_cloud_root_item_size_get(1092) > [31msize is [로그인되지 않았습니다.][0m
04-01 22:23:21.571+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=29610338
04-01 22:23:21.711+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=29610483
04-01 22:23:21.771+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_selected_cb(1069) > [31mlist_type : [6], storage_type : [1][0m
04-01 22:23:21.771+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_gl_selected(1127) > [31mitem : 0x801d7ac5[0m
04-01 22:23:21.771+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_gl_selected(1182) > [31mstorage type : 1[0m
04-01 22:23:21.771+0900 E/MYFILES (10946): mf-root-view.c: mf_root_view_content_unset(905) > [31m----------------------------[0m
04-01 22:23:21.771+0900 E/MYFILES (10946): mf-root-view.c: mf_root_view_content_unset(909) > [31m----------------------------[0m
04-01 22:23:21.771+0900 E/MYFILES (10946): mf-root-view.c: mf_root_view_content_unset(918) > [31m----------------------------[0m
04-01 22:23:21.771+0900 E/MYFILES (10946): mf-view.c: mf_view_naviframe_is_tabbar_style(699) > [31m[0m
04-01 22:23:21.771+0900 E/MYFILES (10946): mf-navi-bar.c: mf_navi_bar_layout_state_set(409) > [31m>>>  type is [1][0m
04-01 22:23:21.771+0900 E/MYFILES (10946): mf-fm-svc-wrapper.c: mf_fm_svc_wrapper_get_file_list(299) > [31msuccess get the file list
04-01 22:23:21.771+0900 E/MYFILES (10946): [0m
04-01 22:23:21.771+0900 E/VCONF   (10946): vconf.c: _vconf_check_install_key_list(1135) > key : db/private/com.samsung.myfile-lite/list_by
04-01 22:23:21.771+0900 E/VCONF   (10946): vconf.c: _vconf_check_retry_err(1368) > db/private/com.samsung.myfile-lite/list_by : check retry err (-21/2).
04-01 22:23:21.771+0900 E/VCONF   (10946): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/private/com.samsung.myfile-lite/list_by) step(-21) failed(2 / No such file or directory) retry(0) 
04-01 22:23:21.771+0900 E/VCONF   (10946): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/private/com.samsung.myfile-lite/list_by) step(-21) failed(2 / No such file or directory)
04-01 22:23:21.771+0900 E/VCONF   (10946): vconf.c: vconf_get_int(2650) > vconf_get_int(10946) : db/private/com.samsung.myfile-lite/list_by error
04-01 22:23:21.771+0900 E/MYFILES (10946): mf-view.c: mf_view_genlist_create(805) > [31m=====================  mf_view_genlist_create[0m
04-01 22:23:21.771+0900 E/MYFILES (10946): mf-view.c: mf_view_genlist_create(808) > [31m=====================  g_mf_pre_content_type is [0] g_mf_content_type is [0][0m
04-01 22:23:21.771+0900 E/MYFILES (10946): mf-view.c: mf_view_genlist_create(820) > [31mgenlist is [0x8007319a][0m
04-01 22:23:21.781+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:21.781+0900 W/MYFILES (10946): mf-thumb-gen.c: mf_view_refresh_thumbnail_for_otg(719) > file_list is NULL
04-01 22:23:21.831+0900 E/MYFILES (10946): mf-util.c: mf_util_path_top_get(2793) > [31mFailed to get the top[0m
04-01 22:23:21.831+0900 E/MYFILES (10946): mf-util.c: mf_util_path_push(2609) > [31m2----> is_same_mode_with_previous is [0][0m
04-01 22:23:21.841+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:21.841+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:21.841+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:21.851+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:21.851+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:21.851+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:21.861+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:22.452+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=29611216
04-01 22:23:22.652+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=29611416
04-01 22:23:23.122+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=29611892
04-01 22:23:23.363+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=29612136
04-01 22:23:23.513+0900 I/APP_CORE(11643): appcore-efl.c: __do_app(514) > [APP 11643] Event: MEM_FLUSH State: PAUSED
04-01 22:23:23.673+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=29612442
04-01 22:23:24.254+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=29613020
04-01 22:23:24.814+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:23:24.814+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:23:24.814+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:23:24.814+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:23:24.814+0900 E/INDICATOR(  683): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 22:23:24.814+0900 E/INDICATOR(  683): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 22:23:24.814+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-01 22:23:24.814+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:23:24.814+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:23:24.814+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:23:24.814+0900 E/INDICATOR(  683): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 22:23:24.814+0900 E/INDICATOR(  683): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 22:23:29.589+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=29618358
04-01 22:23:29.689+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=29618457
04-01 22:23:29.739+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_selected_cb(1069) > [31mlist_type : [6], storage_type : [1][0m
04-01 22:23:29.749+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_gl_selected(1127) > [31mitem : 0x801f85ca[0m
04-01 22:23:29.749+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_gl_selected(1182) > [31mstorage type : 1[0m
04-01 22:23:29.749+0900 E/MYFILES (10946): mf-view.c: mf_view_naviframe_is_tabbar_style(699) > [31m[0m
04-01 22:23:29.749+0900 E/MYFILES (10946): mf-navi-bar.c: mf_navi_bar_layout_state_set(409) > [31m>>>  type is [1][0m
04-01 22:23:29.749+0900 E/MYFILES (10946): mf-fm-svc-wrapper.c: mf_fm_svc_wrapper_get_file_list(299) > [31msuccess get the file list
04-01 22:23:29.749+0900 E/MYFILES (10946): [0m
04-01 22:23:29.749+0900 E/VCONF   (10946): vconf.c: _vconf_check_install_key_list(1135) > key : db/private/com.samsung.myfile-lite/list_by
04-01 22:23:29.749+0900 E/VCONF   (10946): vconf.c: _vconf_check_retry_err(1368) > db/private/com.samsung.myfile-lite/list_by : check retry err (-21/2).
04-01 22:23:29.749+0900 E/VCONF   (10946): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/private/com.samsung.myfile-lite/list_by) step(-21) failed(2 / No such file or directory) retry(0) 
04-01 22:23:29.749+0900 E/VCONF   (10946): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/private/com.samsung.myfile-lite/list_by) step(-21) failed(2 / No such file or directory)
04-01 22:23:29.749+0900 E/VCONF   (10946): vconf.c: vconf_get_int(2650) > vconf_get_int(10946) : db/private/com.samsung.myfile-lite/list_by error
04-01 22:23:29.759+0900 E/MYFILES (10946): mf-view.c: mf_view_genlist_create(805) > [31m=====================  mf_view_genlist_create[0m
04-01 22:23:29.759+0900 E/MYFILES (10946): mf-view.c: mf_view_genlist_create(808) > [31m=====================  g_mf_pre_content_type is [0] g_mf_content_type is [0][0m
04-01 22:23:29.789+0900 E/MYFILES (10946): mf-view.c: mf_view_genlist_create(820) > [31mgenlist is [0x8007319a][0m
04-01 22:23:29.789+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:29.789+0900 W/MYFILES (10946): mf-thumb-gen.c: mf_view_refresh_thumbnail_for_otg(719) > file_list is NULL
04-01 22:23:29.789+0900 W/MYFILES (10946): mf-inotify-handle.c: mf_inotify_handle_add_watch(279) > The mf_notify module supports single instance, the watch descript [4] is removed automatically
04-01 22:23:29.789+0900 W/MYFILES (10946): 
04-01 22:23:29.849+0900 E/MYFILES (10946): mf-util.c: mf_util_path_push(2609) > [31m2----> is_same_mode_with_previous is [0][0m
04-01 22:23:30.500+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=29619266
04-01 22:23:30.590+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=29619354
04-01 22:23:30.640+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_selected_cb(1069) > [31mlist_type : [6], storage_type : [1][0m
04-01 22:23:30.640+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_gl_selected(1127) > [31mitem : 0x800effdc[0m
04-01 22:23:30.640+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_gl_selected(1182) > [31mstorage type : 1[0m
04-01 22:23:30.640+0900 E/MYFILES (10946): mf-view.c: mf_view_naviframe_is_tabbar_style(699) > [31m[0m
04-01 22:23:30.640+0900 E/MYFILES (10946): mf-navi-bar.c: mf_navi_bar_layout_state_set(409) > [31m>>>  type is [1][0m
04-01 22:23:30.640+0900 E/MYFILES (10946): mf-fm-svc-wrapper.c: mf_fm_svc_wrapper_get_file_list(299) > [31msuccess get the file list
04-01 22:23:30.640+0900 E/MYFILES (10946): [0m
04-01 22:23:30.650+0900 E/VCONF   (10946): vconf.c: _vconf_check_install_key_list(1135) > key : db/private/com.samsung.myfile-lite/list_by
04-01 22:23:30.650+0900 E/VCONF   (10946): vconf.c: _vconf_check_retry_err(1368) > db/private/com.samsung.myfile-lite/list_by : check retry err (-21/2).
04-01 22:23:30.650+0900 E/VCONF   (10946): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/private/com.samsung.myfile-lite/list_by) step(-21) failed(2 / No such file or directory) retry(0) 
04-01 22:23:30.650+0900 E/VCONF   (10946): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/private/com.samsung.myfile-lite/list_by) step(-21) failed(2 / No such file or directory)
04-01 22:23:30.650+0900 E/VCONF   (10946): vconf.c: vconf_get_int(2650) > vconf_get_int(10946) : db/private/com.samsung.myfile-lite/list_by error
04-01 22:23:30.650+0900 E/EFL     (10946): elementary<10946> elm_layout.c:853 _elm_layout_efl_file_file_set() failed to set edje file 'myfile.edj', group 'no_contents_base_layout': File Does Not Exist
04-01 22:23:30.650+0900 E/MYFILES (10946): mf-view.c: mf_view_nocontent_create(858) > [31mNo content base layout : 0 [-1311474840][0m
04-01 22:23:30.690+0900 W/MYFILES (10946): mf-inotify-handle.c: mf_inotify_handle_add_watch(279) > The mf_notify module supports single instance, the watch descript [5] is removed automatically
04-01 22:23:30.690+0900 W/MYFILES (10946): 
04-01 22:23:30.740+0900 E/MYFILES (10946): mf-util.c: mf_util_path_push(2609) > [31m2----> is_same_mode_with_previous is [0][0m
04-01 22:23:31.290+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=29620053
04-01 22:23:31.400+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=29620175
04-01 22:23:31.410+0900 E/MYFILES (10946): mf-callback.c: mf_callback_upper_click_cb(372) > [31map->mf_Status.preViewType is [1] view_type is [5] [0m
04-01 22:23:31.410+0900 E/MYFILES (10946): mf-view.c: mf_view_naviframe_is_tabbar_style(699) > [31m[0m
04-01 22:23:31.410+0900 E/MYFILES (10946): mf-navi-bar.c: mf_navi_bar_layout_state_set(409) > [31m>>>  type is [1][0m
04-01 22:23:31.410+0900 E/MYFILES (10946): mf-fm-svc-wrapper.c: mf_fm_svc_wrapper_get_file_list(299) > [31msuccess get the file list
04-01 22:23:31.410+0900 E/MYFILES (10946): [0m
04-01 22:23:31.410+0900 E/VCONF   (10946): vconf.c: _vconf_check_install_key_list(1135) > key : db/private/com.samsung.myfile-lite/list_by
04-01 22:23:31.410+0900 E/VCONF   (10946): vconf.c: _vconf_check_retry_err(1368) > db/private/com.samsung.myfile-lite/list_by : check retry err (-21/2).
04-01 22:23:31.410+0900 E/VCONF   (10946): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/private/com.samsung.myfile-lite/list_by) step(-21) failed(2 / No such file or directory) retry(0) 
04-01 22:23:31.410+0900 E/VCONF   (10946): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/private/com.samsung.myfile-lite/list_by) step(-21) failed(2 / No such file or directory)
04-01 22:23:31.410+0900 E/VCONF   (10946): vconf.c: vconf_get_int(2650) > vconf_get_int(10946) : db/private/com.samsung.myfile-lite/list_by error
04-01 22:23:31.410+0900 E/MYFILES (10946): mf-view.c: mf_view_genlist_create(805) > [31m=====================  mf_view_genlist_create[0m
04-01 22:23:31.410+0900 E/MYFILES (10946): mf-view.c: mf_view_genlist_create(808) > [31m=====================  g_mf_pre_content_type is [0] g_mf_content_type is [0][0m
04-01 22:23:31.410+0900 E/MYFILES (10946): mf-view.c: mf_view_genlist_create(820) > [31mgenlist is [0x8007319a][0m
04-01 22:23:31.420+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:31.420+0900 W/MYFILES (10946): mf-thumb-gen.c: mf_view_refresh_thumbnail_for_otg(719) > file_list is NULL
04-01 22:23:31.721+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=29620485
04-01 22:23:31.851+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=29620619
04-01 22:23:31.861+0900 E/MYFILES (10946): mf-callback.c: mf_callback_upper_click_cb(372) > [31map->mf_Status.preViewType is [1] view_type is [5] [0m
04-01 22:23:31.861+0900 E/MYFILES (10946): mf-view.c: mf_view_naviframe_is_tabbar_style(699) > [31m[0m
04-01 22:23:31.861+0900 E/MYFILES (10946): mf-navi-bar.c: mf_navi_bar_layout_state_set(409) > [31m>>>  type is [1][0m
04-01 22:23:31.861+0900 E/MYFILES (10946): mf-fm-svc-wrapper.c: mf_fm_svc_wrapper_get_file_list(299) > [31msuccess get the file list
04-01 22:23:31.861+0900 E/MYFILES (10946): [0m
04-01 22:23:31.861+0900 E/VCONF   (10946): vconf.c: _vconf_check_install_key_list(1135) > key : db/private/com.samsung.myfile-lite/list_by
04-01 22:23:31.861+0900 E/VCONF   (10946): vconf.c: _vconf_check_retry_err(1368) > db/private/com.samsung.myfile-lite/list_by : check retry err (-21/2).
04-01 22:23:31.861+0900 E/VCONF   (10946): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/private/com.samsung.myfile-lite/list_by) step(-21) failed(2 / No such file or directory) retry(0) 
04-01 22:23:31.861+0900 E/VCONF   (10946): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/private/com.samsung.myfile-lite/list_by) step(-21) failed(2 / No such file or directory)
04-01 22:23:31.861+0900 E/VCONF   (10946): vconf.c: vconf_get_int(2650) > vconf_get_int(10946) : db/private/com.samsung.myfile-lite/list_by error
04-01 22:23:31.861+0900 E/MYFILES (10946): mf-view.c: mf_view_genlist_create(805) > [31m=====================  mf_view_genlist_create[0m
04-01 22:23:31.861+0900 E/MYFILES (10946): mf-view.c: mf_view_genlist_create(808) > [31m=====================  g_mf_pre_content_type is [0] g_mf_content_type is [0][0m
04-01 22:23:31.871+0900 E/MYFILES (10946): mf-view.c: mf_view_genlist_create(820) > [31mgenlist is [0x8007319a][0m
04-01 22:23:31.871+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:31.881+0900 W/MYFILES (10946): mf-thumb-gen.c: mf_view_refresh_thumbnail_for_otg(719) > file_list is NULL
04-01 22:23:31.951+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:31.951+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:31.961+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:31.961+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:31.961+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:31.971+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:31.971+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:32.592+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=29621362
04-01 22:23:32.702+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=29621473
04-01 22:23:32.752+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_selected_cb(1069) > [31mlist_type : [6], storage_type : [1][0m
04-01 22:23:32.762+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_gl_selected(1127) > [31mitem : 0x80162695[0m
04-01 22:23:32.762+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_gl_selected(1182) > [31mstorage type : 1[0m
04-01 22:23:32.762+0900 E/MYFILES (10946): mf-view.c: mf_view_naviframe_is_tabbar_style(699) > [31m[0m
04-01 22:23:32.762+0900 E/MYFILES (10946): mf-navi-bar.c: mf_navi_bar_layout_state_set(409) > [31m>>>  type is [1][0m
04-01 22:23:32.762+0900 E/MYFILES (10946): mf-fm-svc-wrapper.c: mf_fm_svc_wrapper_get_file_list(299) > [31msuccess get the file list
04-01 22:23:32.762+0900 E/MYFILES (10946): [0m
04-01 22:23:32.762+0900 E/VCONF   (10946): vconf.c: _vconf_check_install_key_list(1135) > key : db/private/com.samsung.myfile-lite/list_by
04-01 22:23:32.762+0900 E/VCONF   (10946): vconf.c: _vconf_check_retry_err(1368) > db/private/com.samsung.myfile-lite/list_by : check retry err (-21/2).
04-01 22:23:32.762+0900 E/VCONF   (10946): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/private/com.samsung.myfile-lite/list_by) step(-21) failed(2 / No such file or directory) retry(0) 
04-01 22:23:32.762+0900 E/VCONF   (10946): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/private/com.samsung.myfile-lite/list_by) step(-21) failed(2 / No such file or directory)
04-01 22:23:32.762+0900 E/VCONF   (10946): vconf.c: vconf_get_int(2650) > vconf_get_int(10946) : db/private/com.samsung.myfile-lite/list_by error
04-01 22:23:32.762+0900 E/MYFILES (10946): mf-view.c: mf_view_genlist_create(805) > [31m=====================  mf_view_genlist_create[0m
04-01 22:23:32.762+0900 E/MYFILES (10946): mf-view.c: mf_view_genlist_create(808) > [31m=====================  g_mf_pre_content_type is [0] g_mf_content_type is [0][0m
04-01 22:23:32.802+0900 E/MYFILES (10946): mf-view.c: mf_view_genlist_create(820) > [31mgenlist is [0x8007319a][0m
04-01 22:23:32.812+0900 E/MYFILES (10946): mf-media-content.c: mf_media_info_handle_get_by_path(200) > [31merror : 0[0m
04-01 22:23:32.812+0900 E/MYFILES (10946): mf-genlist.c: __mf_genlist_make_layout(627) > [31mmedia_info_destroy : 0[0m
04-01 22:23:32.812+0900 E/MYFILES (10946): mf-file-attr.c: __mf_local_data_get_media_thumbnail_cb(1144) > [31mmedia is [0xb7fa1fe0][0m
04-01 22:23:32.812+0900 E/MYFILES (10946): mf-file-attr.c: mf_file_attr_get_file_icon(1233) > [31mError : 0, Temporary media handle : 0xb800b160[0m
04-01 22:23:32.812+0900 E/MYFILES (10946): mf-file-attr.c: mf_file_attr_get_file_icon(1264) > [31mtmp_data.media : 0xb800b160[0m
04-01 22:23:32.812+0900 E/EFL     (10946): elementary<10946> elm_image.c:697 _elm_image_evas_object_smart_del() Thread is running , cancellation of thread has been pending.
04-01 22:23:32.812+0900 W/MYFILES (10946): mf-inotify-handle.c: mf_inotify_handle_add_watch(279) > The mf_notify module supports single instance, the watch descript [8] is removed automatically
04-01 22:23:32.812+0900 W/MYFILES (10946): 
04-01 22:23:32.862+0900 E/MYFILES (10946): mf-util.c: mf_util_path_push(2609) > [31m2----> is_same_mode_with_previous is [0][0m
04-01 22:23:32.902+0900 E/MYFILES (10946): mf-object.c: mf_object_create_thumbnail_result_cb(47) > [31mload image successfully	[0][0m
04-01 22:23:33.192+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=29621965
04-01 22:23:33.302+0900 E/EFL     (10946): ecore_x<10946> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=29622075
04-01 22:23:33.312+0900 E/MYFILES (10946): mf-callback.c: mf_callback_upper_click_cb(372) > [31map->mf_Status.preViewType is [1] view_type is [5] [0m
04-01 22:23:33.312+0900 E/MYFILES (10946): mf-view.c: mf_view_naviframe_is_tabbar_style(699) > [31m[0m
04-01 22:23:33.312+0900 E/MYFILES (10946): mf-navi-bar.c: mf_navi_bar_layout_state_set(409) > [31m>>>  type is [1][0m
04-01 22:23:33.312+0900 E/MYFILES (10946): mf-fm-svc-wrapper.c: mf_fm_svc_wrapper_get_file_list(299) > [31msuccess get the file list
04-01 22:23:33.312+0900 E/MYFILES (10946): [0m
04-01 22:23:33.312+0900 E/VCONF   (10946): vconf.c: _vconf_check_install_key_list(1135) > key : db/private/com.samsung.myfile-lite/list_by
04-01 22:23:33.312+0900 E/VCONF   (10946): vconf.c: _vconf_check_retry_err(1368) > db/private/com.samsung.myfile-lite/list_by : check retry err (-21/2).
04-01 22:23:33.312+0900 E/VCONF   (10946): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/private/com.samsung.myfile-lite/list_by) step(-21) failed(2 / No such file or directory) retry(0) 
04-01 22:23:33.312+0900 E/VCONF   (10946): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/private/com.samsung.myfile-lite/list_by) step(-21) failed(2 / No such file or directory)
04-01 22:23:33.312+0900 E/VCONF   (10946): vconf.c: vconf_get_int(2650) > vconf_get_int(10946) : db/private/com.samsung.myfile-lite/list_by error
04-01 22:23:33.312+0900 E/MYFILES (10946): mf-view.c: mf_view_genlist_create(805) > [31m=====================  mf_view_genlist_create[0m
04-01 22:23:33.312+0900 E/MYFILES (10946): mf-view.c: mf_view_genlist_create(808) > [31m=====================  g_mf_pre_content_type is [0] g_mf_content_type is [0][0m
04-01 22:23:33.312+0900 E/MYFILES (10946): mf-view.c: mf_view_genlist_create(820) > [31mgenlist is [0x8007319a][0m
04-01 22:23:33.322+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:33.322+0900 W/MYFILES (10946): mf-thumb-gen.c: mf_view_refresh_thumbnail_for_otg(719) > file_list is NULL
04-01 22:23:33.382+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:33.382+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:33.392+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:33.392+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:33.392+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:33.402+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:33.402+0900 E/MYFILES (10946): mf-genlist.c: mf_genlist_get_thumbnail(141) > [31mstorage type : 1[0m
04-01 22:23:52.972+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:23:52.972+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:23:52.972+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:23:52.972+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:23:52.972+0900 E/INDICATOR(  683): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 22:23:52.972+0900 E/INDICATOR(  683): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 22:23:52.972+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-01 22:23:52.972+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:23:52.972+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:23:52.972+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 22:23:52.982+0900 E/INDICATOR(  683): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 22:23:52.982+0900 E/INDICATOR(  683): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 22:24:00.199+0900 I/INDICATOR(  683): clock.c: indicator_clock_changed_cb(195) > ""
04-01 22:24:00.199+0900 E/UXT     (  683): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 10:24
04-01 22:24:00.199+0900 I/INDICATOR(  683): clock.c: getTimeFormatted(176) > "time format : 오후 10:24"
04-01 22:24:00.199+0900 I/INDICATOR(  683): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 10:24"
04-01 22:24:00.199+0900 W/INDICATOR(  683): clock.c: indicator_clock_changed_cb(272) > 
04-01 22:24:00.199+0900 I/INDICATOR(  683): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147182973 Time: <font_size=31> </font_size> <font_size=31> 오후 10:24</font_size></font>"
04-01 22:24:13.972+0900 E/PKGMGR_SERVER(12825): pkgmgr-server.c: main(2414) > package manager server start
04-01 22:24:14.022+0900 E/PKGMGR  (12823): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-01 22:24:14.052+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 14
04-01 22:24:14.052+0900 W/AUL_AMD (  605): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 11643
04-01 22:24:14.052+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 12
04-01 22:24:14.062+0900 W/AUL     (12828): launch.c: app_request_to_launchpad(396) > request cmd(5) to(11061)
04-01 22:24:14.062+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 5
04-01 22:24:14.062+0900 E/AUL_AMD (  605): amd_request.c: __app_process_by_pid(272) > pid(11061) is dead. cmd(5) is canceled
04-01 22:24:14.062+0900 W/AUL     (12828): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-01 22:24:14.062+0900 E/PKGMGR_SERVER(12828): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-01 22:24:14.062+0900 E/PKGMGR_SERVER(12828): [0;m
04-01 22:24:14.062+0900 W/AUL     (12828): launch.c: app_request_to_launchpad(396) > request cmd(5) to(11373)
04-01 22:24:14.062+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 5
04-01 22:24:14.062+0900 E/AUL_AMD (  605): amd_request.c: __app_process_by_pid(272) > pid(11373) is dead. cmd(5) is canceled
04-01 22:24:14.062+0900 W/AUL     (12828): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-01 22:24:14.062+0900 E/PKGMGR_SERVER(12828): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-01 22:24:14.062+0900 E/PKGMGR_SERVER(12828): [0;m
04-01 22:24:14.062+0900 W/AUL     (12828): launch.c: app_request_to_launchpad(396) > request cmd(5) to(12062)
04-01 22:24:14.062+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 5
04-01 22:24:14.062+0900 E/AUL_AMD (  605): amd_request.c: __app_process_by_pid(272) > pid(12062) is dead. cmd(5) is canceled
04-01 22:24:14.062+0900 W/AUL     (12828): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-01 22:24:14.062+0900 E/PKGMGR_SERVER(12828): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-01 22:24:14.062+0900 E/PKGMGR_SERVER(12828): [0;m
04-01 22:24:14.062+0900 W/AUL     (12828): launch.c: app_request_to_launchpad(396) > request cmd(5) to(12305)
04-01 22:24:14.062+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 5
04-01 22:24:14.062+0900 E/AUL_AMD (  605): amd_request.c: __app_process_by_pid(272) > pid(12305) is dead. cmd(5) is canceled
04-01 22:24:14.062+0900 W/AUL     (12828): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-01 22:24:14.062+0900 E/PKGMGR_SERVER(12828): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-01 22:24:14.062+0900 E/PKGMGR_SERVER(12828): [0;m
04-01 22:24:14.062+0900 W/AUL     (12828): launch.c: app_request_to_launchpad(396) > request cmd(5) to(11643)
04-01 22:24:14.062+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 5
04-01 22:24:14.062+0900 I/APP_CORE(11643): appcore-efl.c: __do_app(514) > [APP 11643] Event: TERMINATE State: PAUSED
04-01 22:24:14.062+0900 W/AUL_AMD (  605): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(11643), cmd(4)
04-01 22:24:14.062+0900 W/AUL     (12828): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
04-01 22:24:14.062+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 22
04-01 22:24:14.062+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(1201) > app status : 5
04-01 22:24:14.062+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 22
04-01 22:24:14.062+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(1201) > app status : 5
04-01 22:24:14.072+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 14
04-01 22:24:14.072+0900 W/AUL_AMD (  605): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-01 22:24:14.082+0900 I/TIZEN_N_EFL_UTIL_WINDOW(11643): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 11
04-01 22:24:14.082+0900 E/APP_CORE(11643): appcore-efl.c: _capture_and_make_file(1619) > win[7800002] widget[720] height[1280]
04-01 22:24:14.082+0900 E/PKGMGR_SERVER(12825): pkgmgr-server.c: sighandler(417) > child NORMAL exit [12828]
04-01 22:24:14.082+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 33
04-01 22:24:14.082+0900 E/APP_CORE(11643): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.client]
04-01 22:24:14.082+0900 I/CAPI_APPFW_APPLICATION(11643): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-01 22:24:14.182+0900 I/AUL_PAD ( 1508): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 11643 pgid = 11643
04-01 22:24:14.182+0900 I/AUL_PAD ( 1508): sigchild.h: __sigchild_action(143) > dead_pid(11643)
04-01 22:24:14.212+0900 I/AUL_PAD ( 1508): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-01 22:24:14.212+0900 I/AUL_PAD ( 1508): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-01 22:24:14.212+0900 E/AUL_PAD ( 1508): launchpad.c: main(698) > error reading sigchld info
04-01 22:24:14.212+0900 I/ESD     (  913): esd_main.c: __esd_app_dead_handler(1773) > pid: 11643
04-01 22:24:14.212+0900 I/Tizen::App( 1247): (243) > App[org.example.client] pid[11643] terminate event is forwarded
04-01 22:24:14.212+0900 I/Tizen::System( 1247): (256) > osp.accessorymanager.service provider is found.
04-01 22:24:14.212+0900 I/Tizen::System( 1247): (196) > Accessory Owner is removed [org.example.client, 11643, ]
04-01 22:24:14.212+0900 I/Tizen::System( 1247): (256) > osp.system.service provider is found.
04-01 22:24:14.212+0900 I/Tizen::App( 1247): (506) > TerminatedApp(org.example.client)
04-01 22:24:14.212+0900 I/Tizen::App( 1247): (512) > Not registered pid(11643)
04-01 22:24:14.212+0900 I/Tizen::System( 1247): (246) > Terminated app [org.example.client]
04-01 22:24:14.212+0900 I/Tizen::Io( 1247): (729) > Entry not found
04-01 22:24:14.212+0900 W/AUL_AMD (  605): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 11643
04-01 22:24:14.212+0900 E/RESOURCED(  685): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.981
04-01 22:24:14.222+0900 I/Tizen::System( 1247): (157) > change brightness system value.
04-01 22:24:14.222+0900 I/Tizen::App( 1247): (782) > Finished invoking application event listener for org.example.client, 11643.
04-01 22:24:14.252+0900 W/CRASH_MANAGER(12831): worker.c: worker_job(1199) > 1111643636c69149105305
