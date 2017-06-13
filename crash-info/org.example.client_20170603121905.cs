S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 27304
Date: 2017-06-03 12:19:05+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 27304, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00006aa8
r2   = 0x00000006, r3   = 0xb40594c0
r4   = 0x00000002, r5   = 0xb4059000
r6   = 0xb675309c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5e81708
r10  = 0xb7f94448, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbef7ce34
lr   = 0xb6649f18, pc   = 0xb6648b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     51708 KB
Buffers:     82256 KB
Cached:     261764 KB
VmPeak:     133056 KB
VmSize:     124296 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       30860 KB
VmRSS:       28036 KB
VmData:      45780 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35864 KB
VmPTE:          92 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 27304 TID = 27304
27304 27305 27366 27367 27371 

Maps Information
afc03000 b05d5000 rw-p [stack:27371]
b1226000 b1237000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1247000 b124c000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1311000 b1319000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b132b000 b1b2a000 rw-p [stack:27367]
b1b2a000 b1b2b000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b3b000 b1b4f000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b63000 b1b64000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b74000 b1b77000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1b88000 b1b89000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1b99000 b1b9b000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bab000 b1bad000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bbd000 b1bcd000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1bdd000 b1be9000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1bfb000 b23fa000 rw-p [stack:27366]
b272b000 b2732000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2745000 b274b000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b275b000 b278c000 r-xp /opt/usr/apps/org.example.client/bin/client
b28e5000 b29c8000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b29ff000 b2a27000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a39000 b3238000 rw-p [stack:27305]
b3238000 b323a000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b324a000 b3254000 r-xp /lib/libnss_files-2.20-2014.11.so
b3265000 b326e000 r-xp /lib/libnss_nis-2.20-2014.11.so
b327f000 b3290000 r-xp /lib/libnsl-2.20-2014.11.so
b32a3000 b32a9000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32ba000 b32bb000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32e3000 b32ea000 r-xp /usr/lib/libminizip.so.1.0.0
b32fa000 b32ff000 r-xp /usr/lib/libstorage.so.0.1
b330f000 b336e000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3384000 b3398000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33a8000 b33ec000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b33fc000 b3404000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3414000 b3444000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3457000 b3510000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3524000 b3577000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3588000 b35a3000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35b3000 b3674000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3687000 b3697000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36a7000 b36b4000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36c5000 b36cc000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36dc000 b371d000 r-xp /usr/lib/libmdm.so.1.2.12
b372d000 b3735000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3744000 b3754000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3775000 b37d5000 r-xp /usr/lib/libasound.so.2.0.0
b37e7000 b37ea000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b37fa000 b37fd000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b380d000 b3812000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3822000 b3823000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3833000 b383e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3852000 b3859000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3869000 b386f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b387f000 b3884000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3894000 b38af000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38bf000 b38c6000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38d6000 b38d9000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38ea000 b3918000 r-xp /usr/lib/libidn.so.11.5.44
b3928000 b393e000 r-xp /usr/lib/libnghttp2.so.5.4.0
b394f000 b3959000 r-xp /usr/lib/libcares.so.2.1.0
b3969000 b3973000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3983000 b3985000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3995000 b3996000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39a6000 b39aa000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39bb000 b39e3000 r-xp /usr/lib/libui-extension.so.0.1.0
b39f4000 b3a1d000 r-xp /usr/lib/libturbojpeg.so
b3a3d000 b3a43000 r-xp /usr/lib/libgif.so.4.1.6
b3a53000 b3a99000 r-xp /usr/lib/libcurl.so.4.3.0
b3aaa000 b3acb000 r-xp /usr/lib/libexif.so.12.3.3
b3ae6000 b3afb000 r-xp /usr/lib/libtts.so
b3b0c000 b3b14000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b24000 b3bea000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c0a000 b3d02000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d21000 b3def000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e06000 b3e08000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e18000 b3e1e000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e2e000 b3e51000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e62000 b3e64000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e74000 b3e76000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e87000 b3e8c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ea3000 b3ea5000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3eb5000 b3ebc000 r-xp /usr/lib/libsensord-share.so
b3ecc000 b3ee4000 r-xp /usr/lib/libsensor.so.1.1.0
b3ef5000 b3ef8000 r-xp /usr/lib/libXv.so.1.0.0
b3f08000 b3f0d000 r-xp /usr/lib/libutilX.so.1.1.0
b3f1d000 b3f22000 r-xp /usr/lib/libappcore-common.so.1.1
b3f32000 b3f39000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f4c000 b3f50000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f61000 b403f000 r-xp /usr/lib/libCOREGL.so.4.0
b405f000 b4062000 r-xp /usr/lib/libuuid.so.1.3.0
b4072000 b4089000 r-xp /usr/lib/libblkid.so.1.1.0
b409a000 b409c000 r-xp /usr/lib/libXau.so.6.0.0
b40ac000 b40f3000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4105000 b410b000 r-xp /usr/lib/libjson-c.so.2.0.1
b411c000 b4120000 r-xp /usr/lib/libogg.so.0.7.1
b4130000 b4152000 r-xp /usr/lib/libvorbis.so.0.4.3
b4162000 b4246000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4262000 b4265000 r-xp /usr/lib/libEGL.so.1.4
b4276000 b427c000 r-xp /usr/lib/libxcb-render.so.0.0.0
b428c000 b428e000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b429e000 b42ab000 r-xp /usr/lib/libGLESv2.so.2.0
b42bc000 b431e000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4333000 b434b000 r-xp /usr/lib/libmount.so.1.1.0
b435d000 b4371000 r-xp /usr/lib/libxcb.so.1.1.0
b4381000 b4388000 r-xp /lib/libcrypt-2.20-2014.11.so
b43c0000 b43c2000 r-xp /usr/lib/libiri.so
b43d2000 b43dd000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43ee000 b4424000 r-xp /usr/lib/libpulse.so.0.16.2
b4435000 b4478000 r-xp /usr/lib/libsndfile.so.1.0.25
b448d000 b44a2000 r-xp /lib/libexpat.so.1.5.2
b44b4000 b4572000 r-xp /usr/lib/libcairo.so.2.11200.14
b4586000 b458e000 r-xp /usr/lib/libdrm.so.2.4.0
b459e000 b45a1000 r-xp /usr/lib/libdri2.so.0.0.0
b45b1000 b45ff000 r-xp /usr/lib/libssl.so.1.0.0
b4614000 b4620000 r-xp /usr/lib/libeeze.so.1.13.0
b4631000 b463a000 r-xp /usr/lib/libethumb.so.1.13.0
b464a000 b464d000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b465d000 b4814000 r-xp /usr/lib/libcrypto.so.1.0.0
b55ff000 b5608000 r-xp /usr/lib/libXi.so.6.1.0
b5618000 b561a000 r-xp /usr/lib/libXgesture.so.7.0.0
b562a000 b562e000 r-xp /usr/lib/libXtst.so.6.1.0
b563e000 b5644000 r-xp /usr/lib/libXrender.so.1.3.0
b5654000 b565a000 r-xp /usr/lib/libXrandr.so.2.2.0
b566a000 b566c000 r-xp /usr/lib/libXinerama.so.1.0.0
b567d000 b5680000 r-xp /usr/lib/libXfixes.so.3.1.0
b5690000 b569b000 r-xp /usr/lib/libXext.so.6.4.0
b56ab000 b56ad000 r-xp /usr/lib/libXdamage.so.1.1.0
b56bd000 b56bf000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56cf000 b57b1000 r-xp /usr/lib/libX11.so.6.3.0
b57c5000 b57cc000 r-xp /usr/lib/libXcursor.so.1.0.2
b57dc000 b57f4000 r-xp /usr/lib/libudev.so.1.6.0
b57f6000 b57f9000 r-xp /lib/libattr.so.1.1.0
b5809000 b5829000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b582a000 b582f000 r-xp /usr/lib/libffi.so.6.0.2
b5840000 b5858000 r-xp /lib/libz.so.1.2.8
b5868000 b586a000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b587a000 b594f000 r-xp /usr/lib/libxml2.so.2.9.2
b5964000 b59ff000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a1b000 b5a1e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a2e000 b5a47000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a58000 b5a69000 r-xp /lib/libresolv-2.20-2014.11.so
b5a7d000 b5af7000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b0c000 b5b0e000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b1e000 b5b25000 r-xp /usr/lib/libembryo.so.1.13.0
b5b35000 b5b3f000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b50000 b5b68000 r-xp /usr/lib/libpng12.so.0.50.0
b5b79000 b5b9c000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bbd000 b5bd1000 r-xp /usr/lib/libector.so.1.13.0
b5be2000 b5bfa000 r-xp /usr/lib/liblua-5.1.so
b5c0b000 b5c62000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c76000 b5c9e000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5caf000 b5cc2000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cd3000 b5d0d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d1e000 b5d2c000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d3c000 b5d44000 r-xp /usr/lib/libtbm.so.1.0.0
b5d54000 b5d61000 r-xp /usr/lib/libeio.so.1.13.0
b5d71000 b5d73000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d83000 b5d88000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d98000 b5daf000 r-xp /usr/lib/libefreet.so.1.13.0
b5dc1000 b5de1000 r-xp /usr/lib/libeldbus.so.1.13.0
b5df1000 b5e11000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e13000 b5e19000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e29000 b5e3a000 r-xp /usr/lib/libemotion.so.1.13.0
b5e4b000 b5e52000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e62000 b5e71000 r-xp /usr/lib/libeo.so.1.13.0
b5e82000 b5e94000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ea5000 b5eaa000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eba000 b5ed3000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ee3000 b5f00000 r-xp /usr/lib/libeet.so.1.13.0
b5f19000 b5f61000 r-xp /usr/lib/libeina.so.1.13.0
b5f72000 b5f82000 r-xp /usr/lib/libefl.so.1.13.0
b5f93000 b6078000 r-xp /usr/lib/libicuuc.so.51.1
b6095000 b61d5000 r-xp /usr/lib/libicui18n.so.51.1
b61ec000 b6224000 r-xp /usr/lib/libecore_x.so.1.13.0
b6236000 b6239000 r-xp /lib/libcap.so.2.21
b6249000 b6272000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6283000 b628a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b629c000 b62d3000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62e4000 b63cf000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63e2000 b645b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b646d000 b6472000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6482000 b648c000 r-xp /usr/lib/libvconf.so.0.2.45
b649c000 b649e000 r-xp /usr/lib/libvasum.so.0.3.1
b64ae000 b64b0000 r-xp /usr/lib/libttrace.so.1.1
b64c0000 b64c3000 r-xp /usr/lib/libiniparser.so.0
b64d3000 b64f9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6509000 b650e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b651f000 b6536000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6547000 b65b2000 r-xp /lib/libm-2.20-2014.11.so
b65c3000 b65c9000 r-xp /lib/librt-2.20-2014.11.so
b65da000 b65e7000 r-xp /usr/lib/libunwind.so.8.0.1
b661d000 b6741000 r-xp /lib/libc-2.20-2014.11.so
b6756000 b676f000 r-xp /lib/libgcc_s-4.9.so.1
b677f000 b6861000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6872000 b689c000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68ad000 b68e9000 r-xp /usr/lib/libsystemd.so.0.4.0
b68eb000 b696e000 r-xp /usr/lib/libedje.so.1.13.0
b6981000 b699f000 r-xp /usr/lib/libecore.so.1.13.0
b69bf000 b6b46000 r-xp /usr/lib/libevas.so.1.13.0
b6b7b000 b6b8f000 r-xp /lib/libpthread-2.20-2014.11.so
b6ba3000 b6dd7000 r-xp /usr/lib/libelementary.so.1.13.0
b6e06000 b6e0a000 r-xp /usr/lib/libsmack.so.1.0.0
b6e1a000 b6e21000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e31000 b6e33000 r-xp /usr/lib/libdlog.so.0.0.0
b6e43000 b6e46000 r-xp /usr/lib/libbundle.so.0.1.22
b6e56000 b6e58000 r-xp /lib/libdl-2.20-2014.11.so
b6e69000 b6e81000 r-xp /usr/lib/libaul.so.0.1.0
b6e95000 b6e9a000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eab000 b6eb8000 r-xp /usr/lib/liblptcp.so
b6eca000 b6ece000 r-xp /usr/lib/libsys-assert.so
b6edf000 b6eff000 r-xp /lib/ld-2.20-2014.11.so
b6f10000 b6f15000 r-xp /usr/bin/launchpad-loader
b7c2e000 b7fc1000 rw-p [heap]
bef5d000 bef7e000 rw-p [stack]
bef5d000 bef7e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27304)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6648b84) [/lib/libc.so.6] + 0x2bb84
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
e(492) > [0;33mends[0m
06-03 12:18:48.696+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:48.696+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:48.696+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:48.696+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:48.696+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:48.696+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:48.696+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:48.696+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:48.696+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:48.696+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-03 12:18:48.706+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
06-03 12:18:48.706+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-03 12:18:48.706+0900 E/ISE_MULTI(  837): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 505  rect->height : 577[0m
06-03 12:18:48.716+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-03 12:18:48.716+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-03 12:18:48.716+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-03 12:18:48.716+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(27304) status(3)
06-03 12:18:48.716+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(27304)
06-03 12:18:48.716+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 27304, appid: org.example.client, status: fg
06-03 12:18:48.716+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
06-03 12:18:48.716+0900 W/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
06-03 12:18:48.726+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-03 12:18:48.726+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 12:18:48.726+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-03 12:18:48.726+0900 I/APP_CORE(27304): appcore-efl.c: __do_app(514) > [APP 27304] Event: RESUME State: CREATED
06-03 12:18:48.746+0900 I/APP_CORE(27304): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 12:18:48.746+0900 I/APP_CORE(27304): appcore-efl.c: __do_app(625) > [APP 27304] Initial Launching, call the resume_cb
06-03 12:18:48.746+0900 I/CAPI_APPFW_APPLICATION(27304): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 12:18:48.746+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 12:18:48.746+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 12:18:48.746+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-03 12:18:48.746+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
06-03 12:18:48.746+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
06-03 12:18:48.746+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-03 12:18:48.746+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
06-03 12:18:48.746+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
06-03 12:18:48.766+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
06-03 12:18:48.766+0900 W/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
06-03 12:18:48.766+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-03 12:18:48.766+0900 I/ISE_MULTI(  837): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
06-03 12:18:48.866+0900 I/ISE_MULTI(  837): isemain.cpp: slot_set_caps_mode(1028) > [0;36m[hidden state:false] mode=1[0m
06-03 12:18:48.886+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:48.886+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:48.886+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:48.886+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:48.886+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:48.886+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:48.886+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:48.886+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:48.886+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:48.886+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:48.886+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:48.886+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:48.896+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-03 12:18:48.986+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(3)
06-03 12:18:49.006+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
06-03 12:18:49.006+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:49.016+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:49.016+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:49.016+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:49.016+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:49.016+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:49.016+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:49.016+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:49.016+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:49.016+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:49.016+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:49.016+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:49.016+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-03 12:18:49.036+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:49.046+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:49.046+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:49.046+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:49.046+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:49.046+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:49.046+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:49.046+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:49.046+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:49.046+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:49.046+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:49.046+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:49.046+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-03 12:18:49.067+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(27304) status(0)
06-03 12:18:49.077+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
06-03 12:18:49.077+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
06-03 12:18:49.397+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2985
06-03 12:18:49.407+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
06-03 12:18:49.407+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 27304.
06-03 12:18:50.168+0900 I/UXT     (27368): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 12:18:51.379+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971006147
06-03 12:18:51.379+0900 I/MY_LOG  (27304): Button pressed
06-03 12:18:51.489+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=971006258
06-03 12:18:51.489+0900 I/ISE_MULTI(  837): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
06-03 12:18:51.509+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Learn_sentence(2373) > [0;36mDLM write[0m
06-03 12:18:51.539+0900 E/VCONF   (27304): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-03 12:18:51.539+0900 E/VCONF   (27304): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-03 12:18:51.539+0900 E/VCONF   (27304): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-03 12:18:51.539+0900 E/VCONF   (27304): vconf.c: vconf_get_bool(2729) > vconf_get_bool(27304) : db/ise/keysound error
06-03 12:18:51.539+0900 E/VCONF   (27304): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-03 12:18:51.539+0900 E/VCONF   (27304): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-03 12:18:51.599+0900 I/MY_LOG  (27304): Button unpressed
06-03 12:18:51.609+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x7e00002 FAILED!
06-03 12:18:51.699+0900 D/basicui (27304): successed to load edc file
06-03 12:18:51.719+0900 I/MY_LOG  (27304): change
06-03 12:18:51.739+0900 I/MY_LOG  (27304): change
06-03 12:18:51.749+0900 I/MY_LOG  (27304): change
06-03 12:18:51.769+0900 I/MY_LOG  (27304): change
06-03 12:18:51.769+0900 I/MY_LOG  (27304): change
06-03 12:18:52.150+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x7e00002 FAILED!
06-03 12:18:52.150+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x7e00002 FAILED!
06-03 12:18:52.160+0900 I/ISE_MULTI(  837): isemain.cpp: slot_set_caps_mode(1028) > [0;36m[hidden state:true] mode=1[0m
06-03 12:18:52.170+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
06-03 12:18:52.170+0900 W/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
06-03 12:18:52.180+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
06-03 12:18:52.180+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-03 12:18:52.180+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
06-03 12:18:52.180+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
06-03 12:18:52.180+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-03 12:18:52.180+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
06-03 12:18:52.180+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
06-03 12:18:52.200+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
06-03 12:18:52.200+0900 W/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
06-03 12:18:52.220+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:52.220+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-03 12:18:52.230+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:52.230+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.230+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:52.230+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.230+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.230+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.230+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.230+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.230+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.230+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.230+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.230+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-03 12:18:52.230+0900 E/ISE_MULTI(  837): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 577  rect->height : 577[0m
06-03 12:18:52.270+0900 I/ISE_MULTI(  837): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
06-03 12:18:52.350+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:52.350+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:52.350+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.350+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:52.350+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.350+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.350+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.350+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.350+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.350+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.350+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.350+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.350+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-03 12:18:52.360+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
06-03 12:18:52.360+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:52.370+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:52.370+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.370+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:52.370+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.370+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.370+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.370+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.370+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.370+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.370+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.370+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:52.370+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-03 12:18:52.450+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(3)
06-03 12:18:52.500+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
06-03 12:18:52.500+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
06-03 12:18:53.721+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971008495
06-03 12:18:53.731+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971008495
06-03 12:18:53.731+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-03 12:18:53.831+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=971008606
06-03 12:18:53.831+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[36]  Y[431] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:18:53.841+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-03 12:18:53.851+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
06-03 12:18:53.851+0900 W/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
06-03 12:18:53.871+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
06-03 12:18:53.901+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-03 12:18:53.901+0900 I/ISE_MULTI(  837): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
06-03 12:18:53.941+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:53.951+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:53.951+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:53.951+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:53.951+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:53.951+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:53.951+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:53.951+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:53.951+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:53.951+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:53.951+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:53.951+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:53.951+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-03 12:18:54.272+0900 I/Tizen::Net::Wifi( 1233): (941) > The background scan result updated.
06-03 12:18:54.482+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971009258
06-03 12:18:54.482+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971009258
06-03 12:18:54.552+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=971009335
06-03 12:18:54.552+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[58]  Y[423] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:18:54.552+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-03 12:18:54.572+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
06-03 12:18:54.572+0900 W/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
06-03 12:18:54.572+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
06-03 12:18:54.632+0900 I/ISE_MULTI(  837): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
06-03 12:18:54.632+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-03 12:18:54.672+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:54.682+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:54.682+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:54.682+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:54.682+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:54.682+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:54.682+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:54.682+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:54.682+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:54.682+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:54.682+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:54.682+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:54.682+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-03 12:18:55.142+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971009916
06-03 12:18:55.142+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971009916
06-03 12:18:55.273+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=971010037
06-03 12:18:55.273+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[70]  Y[322] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:18:55.273+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:18:55.273+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:18:55.283+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:18:55.293+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:18:55.313+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:18:55.423+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971010204
06-03 12:18:55.423+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971010204
06-03 12:18:55.523+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=971010304
06-03 12:18:55.523+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[65]  Y[310] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:18:55.523+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:18:55.523+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:18:55.533+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:18:55.533+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:18:55.543+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:18:55.783+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: prediction_gen_timer(159) > [0;36mprediction_gen_timer[0m
06-03 12:18:55.793+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Generate_prediction_TH(1695) > [0;36mGen prediction[0m
06-03 12:18:55.793+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: prediction_gen_thread(144) > [0;36mpredic gen set [1][0m
06-03 12:18:55.793+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 70[0m
06-03 12:18:55.803+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:55.803+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:55.803+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:55.803+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:55.803+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:55.803+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:55.803+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:55.803+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:55.803+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:55.803+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:55.803+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:55.803+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:55.803+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 10, line_count = 2[0m
06-03 12:18:56.814+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971011593
06-03 12:18:56.814+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971011593
06-03 12:18:56.894+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=971011659
06-03 12:18:56.904+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[111]  Y[351] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:18:56.904+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:18:56.904+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:18:56.924+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:18:56.924+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:18:56.934+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:18:57.164+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: prediction_gen_timer(159) > [0;36mprediction_gen_timer[0m
06-03 12:18:57.164+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Generate_prediction_TH(1695) > [0;36mGen prediction[0m
06-03 12:18:57.164+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: prediction_gen_thread(144) > [0;36mpredic gen set [1][0m
06-03 12:18:57.174+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 70[0m
06-03 12:18:57.174+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-03 12:18:57.174+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-03 12:18:57.184+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:57.184+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-03 12:18:57.184+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:57.184+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:57.184+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:57.184+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:57.184+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:57.184+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:57.184+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:57.184+0900 W/CANDIDATE(  837): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-03 12:18:57.184+0900 W/CANDIDATE(  837): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 10, line_count = 2[0m
06-03 12:18:57.625+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971012405
06-03 12:18:57.705+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=971012482
06-03 12:18:58.526+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971013304
06-03 12:18:58.596+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=971013370
06-03 12:18:58.596+0900 I/ISE_MULTI(  837): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
06-03 12:18:58.606+0900 I/SWIFTKEY(  726): swiftkey_engine.cpp: IME_Learn_sentence(2373) > [0;36mDLM write[0m
06-03 12:18:58.856+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x7e00002 FAILED!
06-03 12:18:58.866+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
06-03 12:18:58.866+0900 I/MY_LOG  (27304): change
06-03 12:18:58.866+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
06-03 12:18:58.876+0900 I/ISE_MULTI(  837): xt9-setting.cpp: xt9_change_onoff(165) > [0;36mPrediction OFF[0m
06-03 12:18:58.876+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
06-03 12:18:58.876+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-03 12:18:58.876+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
06-03 12:18:58.876+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
06-03 12:18:58.926+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_hide(927) > [0;33mHide[0m
06-03 12:18:58.926+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-03 12:18:58.926+0900 E/ISE_MULTI(  837): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 577  rect->height : 505[0m
06-03 12:18:58.926+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
06-03 12:18:58.966+0900 I/ISE_MULTI(  837): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
06-03 12:18:59.717+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971014492
06-03 12:18:59.717+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971014492
06-03 12:18:59.827+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:18:59.837+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=971014613
06-03 12:18:59.837+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[79]  Y[244] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:18:59.847+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:18:59.847+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:18:59.847+0900 I/MY_LOG  (27304): change
06-03 12:18:59.847+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=1[0m
06-03 12:18:59.847+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:18:59.857+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:18:59.977+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971014758
06-03 12:18:59.977+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971014758
06-03 12:18:59.997+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-03 12:19:00.007+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 12:19
06-03 12:19:00.007+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 12:19"
06-03 12:19:00.007+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 12:19"
06-03 12:19:00.007+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-03 12:19:00.007+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145518385 Time: <font_size=31> </font_size> <font_size=31> 오후 12:19</font_size></font>"
06-03 12:19:00.067+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=971014835
06-03 12:19:00.067+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[86]  Y[247] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:19:00.067+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:19:00.067+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:19:00.077+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=2[0m
06-03 12:19:00.077+0900 I/MY_LOG  (27304): change
06-03 12:19:00.077+0900 I/MY_LOG  (27304): change
06-03 12:19:00.087+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:19:00.147+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:19:00.147+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:19:00.227+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971015002
06-03 12:19:00.227+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971015002
06-03 12:19:00.297+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=971015079
06-03 12:19:00.307+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[163]  Y[248] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:19:00.307+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:19:00.307+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:19:00.307+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=3[0m
06-03 12:19:00.307+0900 I/MY_LOG  (27304): change
06-03 12:19:00.307+0900 I/MY_LOG  (27304): change
06-03 12:19:00.317+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:19:00.317+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:19:00.327+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:19:00.798+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971015568
06-03 12:19:00.858+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=971015634
06-03 12:19:00.858+0900 I/ISE_MULTI(  837): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
06-03 12:19:00.888+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x7e00002 FAILED!
06-03 12:19:00.938+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
06-03 12:19:00.938+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
06-03 12:19:00.938+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-03 12:19:00.938+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
06-03 12:19:00.938+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
06-03 12:19:00.968+0900 W/CANDIDATE(  837): soft_candidate.cpp: ui_candidate_hide(927) > [0;33mHide[0m
06-03 12:19:00.968+0900 E/ISE_MULTI(  837): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 505  rect->height : 505[0m
06-03 12:19:00.968+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
06-03 12:19:00.968+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-03 12:19:01.008+0900 I/ISE_MULTI(  837): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
06-03 12:19:01.088+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
06-03 12:19:01.679+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971016456
06-03 12:19:01.689+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971016456
06-03 12:19:01.779+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=971016544
06-03 12:19:01.779+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[73]  Y[225] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:19:01.779+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:19:01.779+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:19:01.789+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=1[0m
06-03 12:19:01.789+0900 I/MY_LOG  (27304): change
06-03 12:19:01.789+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:19:01.789+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:19:01.809+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:19:01.869+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971016644
06-03 12:19:01.869+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971016644
06-03 12:19:01.949+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=971016710
06-03 12:19:01.949+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[93]  Y[230] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:19:01.949+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:19:01.949+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:19:01.949+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=2[0m
06-03 12:19:01.949+0900 I/MY_LOG  (27304): change
06-03 12:19:01.949+0900 I/MY_LOG  (27304): change
06-03 12:19:01.959+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:19:01.959+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:19:01.969+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:19:02.129+0900 E/EFL     (  335): ecore_x<335> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971016899
06-03 12:19:02.129+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971016899
06-03 12:19:02.219+0900 E/EFL     (  837): ecore_x<837> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=971016977
06-03 12:19:02.219+0900 E/ISE_MULTI(  837): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[193]  Y[244] aspect ratio is x[1.000000] y[1.000000][0m
06-03 12:19:02.219+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-03 12:19:02.219+0900 I/SWIFTKEY(  726): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-03 12:19:02.219+0900 I/ISE_MULTI(  837): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=3[0m
06-03 12:19:02.219+0900 I/MY_LOG  (27304): change
06-03 12:19:02.219+0900 I/MY_LOG  (27304): change
06-03 12:19:02.219+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-03 12:19:02.229+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-03 12:19:02.239+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(837) status(0)
06-03 12:19:02.309+0900 I/MY_LOG  (27304): change
06-03 12:19:04.221+0900 I/MY_LOG  (27304): change
06-03 12:19:04.542+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971019317
06-03 12:19:04.642+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=971019416
06-03 12:19:05.342+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=971020117
06-03 12:19:05.342+0900 I/MY_LOG  (27304): Button pressed
06-03 12:19:05.442+0900 E/EFL     (27304): ecore_x<27304> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=971020216
06-03 12:19:05.442+0900 I/ISE_MULTI(  837): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
06-03 12:19:05.452+0900 I/MY_LOG  (27304): Button unpressed
06-03 12:19:05.573+0900 W/CRASH_MANAGER(27314): worker.c: worker_job(1199) > 0627304636c69149645994
