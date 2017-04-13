S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 9311
Date: 2017-04-14 03:25:49+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9311, uid 5000)

Register Information
r0   = 0xbe87beec, r1   = 0xd2bdf846
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xb277d3f1, r5   = 0xb7394090
r6   = 0xb755a008, r7   = 0xbe87bfd0
r8   = 0x800fabd9, r9   = 0xb5e80708
r10  = 0xb7575f60, fp   = 0x00000000
ip   = 0x800fabd9, sp   = 0xbe87bfb8
lr   = 0xb277d415, pc   = 0xd2bdf844
cpsr = 0x600f0010

Memory Information
MemTotal:   987012 KB
MemFree:    144004 KB
Buffers:     47936 KB
Cached:     324624 KB
VmPeak:     136416 KB
VmSize:     135112 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       30792 KB
VmRSS:       29880 KB
VmData:      47000 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35828 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 9311 TID = 9311
9311 9312 9339 9340 9348 

Maps Information
af12e000 af92d000 rw-p [stack:9348]
b0e63000 b0e74000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0e84000 b0e89000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1319000 b1321000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1333000 b1b32000 rw-p [stack:9340]
b1b32000 b1b33000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b43000 b1b57000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b6b000 b1b6c000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b7c000 b1b7f000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1b90000 b1b91000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1ba1000 b1ba3000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bb3000 b1bb5000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bc5000 b1bd5000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1be5000 b1bf1000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c03000 b2402000 rw-p [stack:9339]
b2733000 b273a000 r-xp /usr/lib/libefl-extension.so.0.1.0
b274d000 b2753000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2763000 b278b000 r-xp /opt/usr/apps/org.example.client/bin/client
b28e4000 b29c7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b29fe000 b2a26000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a38000 b3237000 rw-p [stack:9312]
b3237000 b3239000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3249000 b3253000 r-xp /lib/libnss_files-2.20-2014.11.so
b3264000 b326d000 r-xp /lib/libnss_nis-2.20-2014.11.so
b327e000 b328f000 r-xp /lib/libnsl-2.20-2014.11.so
b32a2000 b32a8000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32b9000 b32ba000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32e2000 b32e9000 r-xp /usr/lib/libminizip.so.1.0.0
b32f9000 b32fe000 r-xp /usr/lib/libstorage.so.0.1
b330e000 b336d000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3383000 b3397000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33a7000 b33eb000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b33fb000 b3403000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3413000 b3443000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3456000 b350f000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3523000 b3576000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3587000 b35a2000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35b2000 b3673000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3686000 b3696000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36a6000 b36b3000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36c4000 b36cb000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36db000 b371c000 r-xp /usr/lib/libmdm.so.1.2.12
b372c000 b3734000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3743000 b3753000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3774000 b37d4000 r-xp /usr/lib/libasound.so.2.0.0
b37e6000 b37e9000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b37f9000 b37fc000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b380c000 b3811000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3821000 b3822000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3832000 b383d000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3851000 b3858000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3868000 b386e000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b387e000 b3883000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3893000 b38ae000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38be000 b38c5000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38d5000 b38d8000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38e9000 b3917000 r-xp /usr/lib/libidn.so.11.5.44
b3927000 b393d000 r-xp /usr/lib/libnghttp2.so.5.4.0
b394e000 b3958000 r-xp /usr/lib/libcares.so.2.1.0
b3968000 b3972000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3982000 b3984000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3994000 b3995000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39a5000 b39a9000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39ba000 b39e2000 r-xp /usr/lib/libui-extension.so.0.1.0
b39f3000 b3a1c000 r-xp /usr/lib/libturbojpeg.so
b3a3c000 b3a42000 r-xp /usr/lib/libgif.so.4.1.6
b3a52000 b3a98000 r-xp /usr/lib/libcurl.so.4.3.0
b3aa9000 b3aca000 r-xp /usr/lib/libexif.so.12.3.3
b3ae5000 b3afa000 r-xp /usr/lib/libtts.so
b3b0b000 b3b13000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b23000 b3be9000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c09000 b3d01000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d20000 b3dee000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e05000 b3e07000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e17000 b3e1d000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e2d000 b3e50000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e61000 b3e63000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e73000 b3e75000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e86000 b3e8b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ea2000 b3ea4000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3eb4000 b3ebb000 r-xp /usr/lib/libsensord-share.so
b3ecb000 b3ee3000 r-xp /usr/lib/libsensor.so.1.1.0
b3ef4000 b3ef7000 r-xp /usr/lib/libXv.so.1.0.0
b3f07000 b3f0c000 r-xp /usr/lib/libutilX.so.1.1.0
b3f1c000 b3f21000 r-xp /usr/lib/libappcore-common.so.1.1
b3f31000 b3f38000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f4b000 b3f4f000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f60000 b403e000 r-xp /usr/lib/libCOREGL.so.4.0
b405e000 b4061000 r-xp /usr/lib/libuuid.so.1.3.0
b4071000 b4088000 r-xp /usr/lib/libblkid.so.1.1.0
b4099000 b409b000 r-xp /usr/lib/libXau.so.6.0.0
b40ab000 b40f2000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4104000 b410a000 r-xp /usr/lib/libjson-c.so.2.0.1
b411b000 b411f000 r-xp /usr/lib/libogg.so.0.7.1
b412f000 b4151000 r-xp /usr/lib/libvorbis.so.0.4.3
b4161000 b4245000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4261000 b4264000 r-xp /usr/lib/libEGL.so.1.4
b4275000 b427b000 r-xp /usr/lib/libxcb-render.so.0.0.0
b428b000 b428d000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b429d000 b42aa000 r-xp /usr/lib/libGLESv2.so.2.0
b42bb000 b431d000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4332000 b434a000 r-xp /usr/lib/libmount.so.1.1.0
b435c000 b4370000 r-xp /usr/lib/libxcb.so.1.1.0
b4380000 b4387000 r-xp /lib/libcrypt-2.20-2014.11.so
b43bf000 b43c1000 r-xp /usr/lib/libiri.so
b43d1000 b43dc000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43ed000 b4423000 r-xp /usr/lib/libpulse.so.0.16.2
b4434000 b4477000 r-xp /usr/lib/libsndfile.so.1.0.25
b448c000 b44a1000 r-xp /lib/libexpat.so.1.5.2
b44b3000 b4571000 r-xp /usr/lib/libcairo.so.2.11200.14
b4585000 b458d000 r-xp /usr/lib/libdrm.so.2.4.0
b459d000 b45a0000 r-xp /usr/lib/libdri2.so.0.0.0
b45b0000 b45fe000 r-xp /usr/lib/libssl.so.1.0.0
b4613000 b461f000 r-xp /usr/lib/libeeze.so.1.13.0
b4630000 b4639000 r-xp /usr/lib/libethumb.so.1.13.0
b4649000 b464c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b465c000 b4813000 r-xp /usr/lib/libcrypto.so.1.0.0
b55fe000 b5607000 r-xp /usr/lib/libXi.so.6.1.0
b5617000 b5619000 r-xp /usr/lib/libXgesture.so.7.0.0
b5629000 b562d000 r-xp /usr/lib/libXtst.so.6.1.0
b563d000 b5643000 r-xp /usr/lib/libXrender.so.1.3.0
b5653000 b5659000 r-xp /usr/lib/libXrandr.so.2.2.0
b5669000 b566b000 r-xp /usr/lib/libXinerama.so.1.0.0
b567c000 b567f000 r-xp /usr/lib/libXfixes.so.3.1.0
b568f000 b569a000 r-xp /usr/lib/libXext.so.6.4.0
b56aa000 b56ac000 r-xp /usr/lib/libXdamage.so.1.1.0
b56bc000 b56be000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56ce000 b57b0000 r-xp /usr/lib/libX11.so.6.3.0
b57c4000 b57cb000 r-xp /usr/lib/libXcursor.so.1.0.2
b57db000 b57f3000 r-xp /usr/lib/libudev.so.1.6.0
b57f5000 b57f8000 r-xp /lib/libattr.so.1.1.0
b5808000 b5828000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5829000 b582e000 r-xp /usr/lib/libffi.so.6.0.2
b583f000 b5857000 r-xp /lib/libz.so.1.2.8
b5867000 b5869000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5879000 b594e000 r-xp /usr/lib/libxml2.so.2.9.2
b5963000 b59fe000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a1a000 b5a1d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a2d000 b5a46000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a57000 b5a68000 r-xp /lib/libresolv-2.20-2014.11.so
b5a7c000 b5af6000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b0b000 b5b0d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b1d000 b5b24000 r-xp /usr/lib/libembryo.so.1.13.0
b5b34000 b5b3e000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b4f000 b5b67000 r-xp /usr/lib/libpng12.so.0.50.0
b5b78000 b5b9b000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bbc000 b5bd0000 r-xp /usr/lib/libector.so.1.13.0
b5be1000 b5bf9000 r-xp /usr/lib/liblua-5.1.so
b5c0a000 b5c61000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c75000 b5c9d000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cae000 b5cc1000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cd2000 b5d0c000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d1d000 b5d2b000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d3b000 b5d43000 r-xp /usr/lib/libtbm.so.1.0.0
b5d53000 b5d60000 r-xp /usr/lib/libeio.so.1.13.0
b5d70000 b5d72000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d82000 b5d87000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d97000 b5dae000 r-xp /usr/lib/libefreet.so.1.13.0
b5dc0000 b5de0000 r-xp /usr/lib/libeldbus.so.1.13.0
b5df0000 b5e10000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e12000 b5e18000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e28000 b5e39000 r-xp /usr/lib/libemotion.so.1.13.0
b5e4a000 b5e51000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e61000 b5e70000 r-xp /usr/lib/libeo.so.1.13.0
b5e81000 b5e93000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ea4000 b5ea9000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eb9000 b5ed2000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ee2000 b5eff000 r-xp /usr/lib/libeet.so.1.13.0
b5f18000 b5f60000 r-xp /usr/lib/libeina.so.1.13.0
b5f71000 b5f81000 r-xp /usr/lib/libefl.so.1.13.0
b5f92000 b6077000 r-xp /usr/lib/libicuuc.so.51.1
b6094000 b61d4000 r-xp /usr/lib/libicui18n.so.51.1
b61eb000 b6223000 r-xp /usr/lib/libecore_x.so.1.13.0
b6235000 b6238000 r-xp /lib/libcap.so.2.21
b6248000 b6271000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6282000 b6289000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b629b000 b62d2000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62e3000 b63ce000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63e1000 b645a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b646c000 b6471000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6481000 b648b000 r-xp /usr/lib/libvconf.so.0.2.45
b649b000 b649d000 r-xp /usr/lib/libvasum.so.0.3.1
b64ad000 b64af000 r-xp /usr/lib/libttrace.so.1.1
b64bf000 b64c2000 r-xp /usr/lib/libiniparser.so.0
b64d2000 b64f8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6508000 b650d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b651e000 b6535000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6546000 b65b1000 r-xp /lib/libm-2.20-2014.11.so
b65c2000 b65c8000 r-xp /lib/librt-2.20-2014.11.so
b65d9000 b65e6000 r-xp /usr/lib/libunwind.so.8.0.1
b661c000 b6740000 r-xp /lib/libc-2.20-2014.11.so
b6755000 b676e000 r-xp /lib/libgcc_s-4.9.so.1
b677e000 b6860000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6871000 b689b000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68ac000 b68e8000 r-xp /usr/lib/libsystemd.so.0.4.0
b68ea000 b696d000 r-xp /usr/lib/libedje.so.1.13.0
b6980000 b699e000 r-xp /usr/lib/libecore.so.1.13.0
b69be000 b6b45000 r-xp /usr/lib/libevas.so.1.13.0
b6b7a000 b6b8e000 r-xp /lib/libpthread-2.20-2014.11.so
b6ba2000 b6dd6000 r-xp /usr/lib/libelementary.so.1.13.0
b6e05000 b6e09000 r-xp /usr/lib/libsmack.so.1.0.0
b6e19000 b6e20000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e30000 b6e32000 r-xp /usr/lib/libdlog.so.0.0.0
b6e42000 b6e45000 r-xp /usr/lib/libbundle.so.0.1.22
b6e55000 b6e57000 r-xp /lib/libdl-2.20-2014.11.so
b6e68000 b6e80000 r-xp /usr/lib/libaul.so.0.1.0
b6e94000 b6e99000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eaa000 b6eb7000 r-xp /usr/lib/liblptcp.so
b6ec9000 b6ecd000 r-xp /usr/lib/libsys-assert.so
b6ede000 b6efe000 r-xp /lib/ld-2.20-2014.11.so
b6f0f000 b6f14000 r-xp /usr/bin/launchpad-loader
b70be000 b75d0000 rw-p [heap]
be85c000 be87d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9311)
Call Stack Count: 1
 0: (0xd2bdf844) (null)
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
error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-14 03:25:17.970+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-14 03:25:17.970+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-14 03:25:17.981+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:25:18.031+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_create(409) > New handle created[0xb8711d10]
04-14 03:25:18.031+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_get_type(463) > Connected Network = 2
04-14 03:25:18.031+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_destroy(427) > Destroy handle: 0xb8711d10
04-14 03:25:18.031+0900 E/weather-common( 1405): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-14 03:25:18.031+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-14 03:25:18.031+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-14 03:25:18.031+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-14 03:25:18.031+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: fg
04-14 03:25:18.541+0900 E/VCONF   ( 8774): vconf-kdb.c: _vconf_kdb_del_notify(468) > Error: inotify_add_watch() [/opt/var/kdb/db/ise+keysound]: Permission denied
04-14 03:25:18.541+0900 E/VCONF   ( 8774): vconf.c: vconf_ignore_key_changed(3218) > vconf_ignore_key_changed() failed: key(db/ise/keysound)
04-14 03:25:18.571+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 8774 pgid = 8774
04-14 03:25:18.571+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(143) > dead_pid(8774)
04-14 03:25:18.611+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-14 03:25:18.611+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-14 03:25:18.611+0900 E/AUL_PAD ( 1560): launchpad.c: main(698) > error reading sigchld info
04-14 03:25:18.611+0900 I/ESD     (  895): esd_main.c: __esd_app_dead_handler(1773) > pid: 8774
04-14 03:25:18.611+0900 I/Tizen::App( 1305): (243) > App[org.example.client] pid[8774] terminate event is forwarded
04-14 03:25:18.611+0900 I/Tizen::System( 1305): (256) > osp.accessorymanager.service provider is found.
04-14 03:25:18.611+0900 I/Tizen::System( 1305): (196) > Accessory Owner is removed [org.example.client, 8774, ]
04-14 03:25:18.611+0900 I/Tizen::System( 1305): (256) > osp.system.service provider is found.
04-14 03:25:18.611+0900 I/Tizen::App( 1305): (506) > TerminatedApp(org.example.client)
04-14 03:25:18.611+0900 I/Tizen::App( 1305): (512) > Not registered pid(8774)
04-14 03:25:18.611+0900 I/Tizen::System( 1305): (246) > Terminated app [org.example.client]
04-14 03:25:18.611+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:18.611+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8774
04-14 03:25:18.621+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:18.621+0900 I/Tizen::App( 1305): (782) > Finished invoking application event listener for org.example.client, 8774.
04-14 03:25:18.831+0900 W/ISF_PANEL_EFL(  681): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5e00002 FAILED!
04-14 03:25:19.552+0900 E/PKGMGR_SERVER( 9092): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-14 03:25:19.552+0900 E/PKGMGR_SERVER( 9092): pkgmgr-server.c: main(2471) > package manager server terminated.
04-14 03:25:21.834+0900 E/PKGMGR  ( 9185): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-14 03:25:21.914+0900 E/PKGMGR_SERVER( 9187): pkgmgr-server.c: main(2414) > package manager server start
04-14 03:25:21.964+0900 E/PKGMGR_SERVER( 9187): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-14 03:25:21.974+0900 E/PKGMGR_SERVER( 9187): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-14 03:25:21.974+0900 E/PKGMGR  ( 9185): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[91850002]
04-14 03:25:22.125+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-14 03:25:22.125+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-14 03:25:22.135+0900 W/AUL_AMD (  616): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-14 03:25:22.145+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-14 03:25:22.145+0900 I/Tizen::App( 1305): (119) > InstallationInProgress [30]
04-14 03:25:22.145+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-14 03:25:22.315+0900 W/CERT_SVC_VCORE( 9190): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-14 03:25:22.415+0900 E/rpm-installer( 9190): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-14 03:25:22.415+0900 E/rpm-installer( 9190): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-14 03:25:22.465+0900 E/PKGMGR_PARSER( 9190): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-14 03:25:22.485+0900 I/PRIVACY-MANAGER-CLIENT( 9190): SocketClient.cpp: SocketClient(37) > Client created
04-14 03:25:22.485+0900 I/PRIVACY-MANAGER-CLIENT( 9190): SocketClient.cpp: connect(62) > Client connected
04-14 03:25:22.485+0900 I/PRIVACY-MANAGER-SERVER(  910): SocketService.cpp: mainloop(230) > Got incoming connection
04-14 03:25:22.485+0900 I/PRIVACY-MANAGER-CLIENT( 9190): SocketClient.cpp: disconnect(72) > Client disconnected
04-14 03:25:22.495+0900 E/PKGMGR_CERT( 9190): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-14 03:25:22.495+0900 E/PKGMGR_CERT( 9190): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-14 03:25:22.505+0900 E/PKGMGR_CERT( 9190): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-14 03:25:22.535+0900 E/rpm-installer( 9190): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-14 03:25:22.535+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-14 03:25:22.545+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
04-14 03:25:22.545+0900 E/ESD     (  895): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-14 03:25:22.545+0900 W/AUL_AMD (  616): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-14 03:25:22.545+0900 W/ISF_PANEL_EFL(  681): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-14 03:25:22.555+0900 W/ISF_PANEL_EFL(  681): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-14 03:25:22.765+0900 W/AUL_AMD (  616): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-14 03:25:22.765+0900 W/AUL_AMD (  616): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-14 03:25:24.307+0900 E/PKGMGR_SERVER( 9187): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9190]
04-14 03:25:24.557+0900 E/PKGMGR_SERVER( 9187): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-14 03:25:24.557+0900 E/PKGMGR_SERVER( 9187): pkgmgr-server.c: main(2471) > package manager server terminated.
04-14 03:25:25.158+0900 E/PKGMGR  ( 9239): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-14 03:25:25.238+0900 E/PKGMGR_SERVER( 9241): pkgmgr-server.c: main(2414) > package manager server start
04-14 03:25:25.288+0900 E/PKGMGR_SERVER( 9241): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-14 03:25:25.298+0900 E/PKGMGR_INFO( 9241): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-14 03:25:25.308+0900 E/rpm-installer( 9241): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-14 03:25:25.308+0900 E/PKGMGR_SERVER( 9241): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-14 03:25:25.318+0900 E/PKGMGR  ( 9239): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[92390002]
04-14 03:25:25.438+0900 E/PKGMGR_INSTALLER( 9244): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-14 03:25:25.438+0900 E/rpm-installer( 9244): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-14 03:25:25.448+0900 E/rpm-installer( 9244): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-14 03:25:25.448+0900 E/rpm-installer( 9244): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-14 03:25:25.448+0900 E/rpm-installer( 9244): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-14 03:25:25.448+0900 E/rpm-installer( 9244): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-14 03:25:25.448+0900 E/rpm-installer( 9244): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-14 03:25:25.498+0900 W/CERT_SVC_VCORE( 9244): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-14 03:25:25.548+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-14 03:25:25.548+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
04-14 03:25:25.558+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-14 03:25:25.558+0900 I/Tizen::App( 1305): (119) > InstallationInProgress [30]
04-14 03:25:25.558+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-14 03:25:25.818+0900 E/rpm-installer( 9244): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-14 03:25:25.818+0900 E/rpm-installer( 9244): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-14 03:25:25.818+0900 E/rpm-installer( 9244): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-14 03:25:25.818+0900 E/rpm-installer( 9244): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-14 03:25:25.818+0900 E/rpm-installer( 9244): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-14 03:25:25.818+0900 E/rpm-installer( 9244): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-14 03:25:25.828+0900 E/PKGMGR_PARSER( 9244): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-14 03:25:25.828+0900 E/PKGMGR_PARSER( 9244): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-14 03:25:25.868+0900 I/PRIVACY-MANAGER-CLIENT( 9244): SocketClient.cpp: SocketClient(37) > Client created
04-14 03:25:26.068+0900 E/PKGMGR_PARSER( 9244): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-14 03:25:26.088+0900 E/PKGMGR_CERT( 9244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-14 03:25:26.088+0900 E/PKGMGR_CERT( 9244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 110
04-14 03:25:26.088+0900 E/PKGMGR_CERT( 9244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 110
04-14 03:25:26.088+0900 E/PKGMGR_CERT( 9244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-14 03:25:26.088+0900 E/PKGMGR_CERT( 9244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 5
04-14 03:25:26.088+0900 E/PKGMGR_CERT( 9244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 5
04-14 03:25:26.088+0900 E/PKGMGR_CERT( 9244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-14 03:25:26.098+0900 E/PKGMGR_CERT( 9244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-14 03:25:26.098+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-14 03:25:26.098+0900 I/Tizen::App( 1305): (119) > InstallationInProgress [60]
04-14 03:25:26.098+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
04-14 03:25:26.118+0900 E/rpm-installer( 9244): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-14 03:25:26.138+0900 E/rpm-installer( 9244): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-14 03:25:26.138+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-14 03:25:26.138+0900 I/Tizen::App( 1305): (119) > InstallationInProgress [100]
04-14 03:25:26.138+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-14 03:25:27.560+0900 E/PKGMGR_SERVER( 9241): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-14 03:25:28.020+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-14 03:25:28.020+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-14 03:25:28.020+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-14 03:25:28.020+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-14 03:25:28.020+0900 I/Tizen::App( 1305): (78) > Installation is Completed. [Package = org.example.client]
04-14 03:25:28.020+0900 I/Tizen::App( 1305): (671) > Enter. package(org.example.client), installationResult(0)
04-14 03:25:28.040+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-14 03:25:28.040+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-14 03:25:28.040+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-14 03:25:28.040+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-14 03:25:28.040+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-14 03:25:28.050+0900 W/ISF_PANEL_EFL(  681): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-14 03:25:28.050+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-14 03:25:28.050+0900 E/HOME_APPS(  860): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-14 03:25:28.060+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-14 03:25:28.060+0900 I/Tizen::App( 1305): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-14 03:25:28.060+0900 W/HOME_APPS(  860): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-14 03:25:28.070+0900 I/Tizen::App( 1305): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-14 03:25:28.080+0900 I/Tizen::App( 1305): (416) > appName = [client]
04-14 03:25:28.080+0900 I/Tizen::App( 1305): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-14 03:25:28.080+0900 E/PKGMGR_INFO( 1305): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-14 03:25:28.080+0900 I/Tizen::App( 1305): (683) > Application count(1) in this package
04-14 03:25:28.080+0900 I/Tizen::App( 1305): (840) > Enter.
04-14 03:25:28.080+0900 I/Tizen::App( 1305): (703) > Exit.
04-14 03:25:28.080+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-14 03:25:28.090+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-14 03:25:28.090+0900 E/PKGMGR_SERVER( 9241): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9244]
04-14 03:25:28.100+0900 I/Tizen::App( 1305): (416) > appName = [client]
04-14 03:25:28.100+0900 I/Tizen::App( 1305): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-14 03:25:28.100+0900 I/Tizen::App( 1305): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-14 03:25:28.100+0900 I/Tizen::App( 1305): (131) > Enter
04-14 03:25:28.110+0900 I/Tizen::App( 1305): (137) > org.example.client does not have launch condition
04-14 03:25:28.110+0900 I/Tizen::App( 1305): (883) > Exit.
04-14 03:25:28.120+0900 W/HOME_APPS(  860): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-14 03:25:29.552+0900 E/PKGMGR_SERVER( 9241): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-14 03:25:29.552+0900 E/PKGMGR_SERVER( 9241): pkgmgr-server.c: main(2471) > package manager server terminated.
04-14 03:25:32.244+0900 W/AUL     ( 9298): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-14 03:25:32.244+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 0
04-14 03:25:32.254+0900 I/AUL     (  616): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-14 03:25:32.264+0900 I/AUL     (  616): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-14 03:25:32.264+0900 E/AUL_AMD (  616): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-14 03:25:32.264+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(2508) > caller pid : 9298
04-14 03:25:32.264+0900 E/AUL_AMD (  616): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-14 03:25:32.264+0900 E/RESOURCED(  648): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-14 03:25:32.264+0900 E/RESOURCED(  648): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-14 03:25:32.274+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(3052) > pad pid(-5)
04-14 03:25:32.274+0900 W/AUL_PAD ( 1560): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-14 03:25:32.274+0900 W/AUL_PAD ( 1560): launchpad.c: __send_result_to_caller(267) > Check app launching
04-14 03:25:32.284+0900 I/abc     ( 9035): abc
04-14 03:25:32.284+0900 I/CAPI_APPFW_APPLICATION( 9035): app_main.c: ui_app_main(789) > app_efl_main
04-14 03:25:32.284+0900 I/CAPI_APPFW_APPLICATION( 9035): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-14 03:25:32.314+0900 E/TBM     ( 9035): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-14 03:25:32.375+0900 W/AUL     (  616): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9035, appid: org.example.client
04-14 03:25:32.375+0900 E/AUL     (  616): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-14 03:25:32.385+0900 W/AUL     ( 9298): launch.c: app_request_to_launchpad(425) > request cmd(0) result(9035)
04-14 03:25:32.595+0900 I/APP_CORE( 9035): appcore-efl.c: __do_app(514) > [APP 9035] Event: RESET State: CREATED
04-14 03:25:32.595+0900 I/CAPI_APPFW_APPLICATION( 9035): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-14 03:25:32.605+0900 E/EFL     ( 9035): edje<9035> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:32.605+0900 E/EFL     ( 9035): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:32.615+0900 E/EFL     ( 9035): edje<9035> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:32.615+0900 E/EFL     ( 9035): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:32.615+0900 E/EFL     ( 9035): edje<9035> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:32.615+0900 E/EFL     ( 9035): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:32.625+0900 W/APP_CORE( 9035): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000002
04-14 03:25:32.625+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 35
04-14 03:25:32.635+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:32.635+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:32.645+0900 I/Tizen::System( 1305): (259) > Active app [org.exampl], current [com.samsun] 
04-14 03:25:32.645+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:32.655+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:32.665+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:25:32.745+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
04-14 03:25:32.745+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-14 03:25:32.745+0900 I/APP_CORE( 9035): appcore-efl.c: __do_app(514) > [APP 9035] Event: RESUME State: CREATED
04-14 03:25:32.745+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
04-14 03:25:32.745+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
04-14 03:25:32.745+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
04-14 03:25:32.745+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
04-14 03:25:32.745+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9035) status(3)
04-14 03:25:32.745+0900 W/AUL_AMD (  616): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-14 03:25:32.745+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-14 03:25:32.745+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(9035)
04-14 03:25:32.745+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9035, appid: org.example.client, status: fg
04-14 03:25:32.755+0900 I/APP_CORE( 9035): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-14 03:25:32.755+0900 I/APP_CORE( 9035): appcore-efl.c: __do_app(625) > [APP 9035] Initial Launching, call the resume_cb
04-14 03:25:32.755+0900 I/CAPI_APPFW_APPLICATION( 9035): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:25:32.765+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-14 03:25:32.765+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-14 03:25:32.765+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: bg
04-14 03:25:33.105+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9035) status(0)
04-14 03:25:33.436+0900 I/Tizen::App( 1305): (499) > LaunchedApp(org.example.client)
04-14 03:25:33.436+0900 I/Tizen::App( 1305): (733) > Finished invoking application event listener for org.example.client, 9035.
04-14 03:25:33.446+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.678
04-14 03:25:33.956+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28861401
04-14 03:25:34.046+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28861489
04-14 03:25:34.206+0900 I/UXT     ( 9311): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-14 03:25:34.346+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28861797
04-14 03:25:34.356+0900 I/MY_LOG  ( 9035): Button pressed
04-14 03:25:34.437+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28861885
04-14 03:25:34.447+0900 E/VCONF   ( 9035): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-14 03:25:34.447+0900 E/VCONF   ( 9035): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-14 03:25:34.447+0900 E/VCONF   ( 9035): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-14 03:25:34.447+0900 E/VCONF   ( 9035): vconf.c: vconf_get_bool(2729) > vconf_get_bool(9035) : db/ise/keysound error
04-14 03:25:34.447+0900 E/VCONF   ( 9035): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-14 03:25:34.447+0900 E/VCONF   ( 9035): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-14 03:25:34.497+0900 I/MY_LOG  ( 9035): Button unpressed
04-14 03:25:35.157+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28862598
04-14 03:25:35.157+0900 I/MY_LOG  ( 9035): Button pressed
04-14 03:25:35.257+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28862697
04-14 03:25:35.267+0900 I/MY_LOG  ( 9035): Button unpressed
04-14 03:25:35.297+0900 D/basicui ( 9035): successed to load edc file
04-14 03:25:36.789+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28864235
04-14 03:25:36.879+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28864323
04-14 03:25:36.909+0900 D/basicui ( 9035): successed to load edc file
04-14 03:25:36.939+0900 I/MY_LOG  ( 9035): change
04-14 03:25:37.009+0900 I/MY_LOG  ( 9035): change
04-14 03:25:37.750+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: MEM_FLUSH State: PAUSED
04-14 03:25:38.440+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28865888
04-14 03:25:39.381+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28866826
04-14 03:25:39.722+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28867164
04-14 03:25:40.162+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28867605
04-14 03:25:40.402+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28867848
04-14 03:25:40.543+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9035 pgid = 9035
04-14 03:25:40.543+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(143) > dead_pid(9035)
04-14 03:25:40.553+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:40.563+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
04-14 03:25:40.563+0900 W/AUL_AMD (  616): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-14 03:25:40.563+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-14 03:25:40.563+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
04-14 03:25:40.563+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
04-14 03:25:40.593+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-14 03:25:40.593+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-14 03:25:40.593+0900 E/AUL_PAD ( 1560): launchpad.c: main(698) > error reading sigchld info
04-14 03:25:40.593+0900 I/ESD     (  895): esd_main.c: __esd_app_dead_handler(1773) > pid: 9035
04-14 03:25:40.593+0900 I/Tizen::App( 1305): (243) > App[org.example.client] pid[9035] terminate event is forwarded
04-14 03:25:40.593+0900 I/Tizen::System( 1305): (256) > osp.accessorymanager.service provider is found.
04-14 03:25:40.593+0900 I/Tizen::System( 1305): (196) > Accessory Owner is removed [org.example.client, 9035, ]
04-14 03:25:40.593+0900 I/Tizen::System( 1305): (256) > osp.system.service provider is found.
04-14 03:25:40.593+0900 I/Tizen::App( 1305): (506) > TerminatedApp(org.example.client)
04-14 03:25:40.593+0900 I/Tizen::App( 1305): (512) > Not registered pid(9035)
04-14 03:25:40.593+0900 I/Tizen::System( 1305): (246) > Terminated app [org.example.client]
04-14 03:25:40.593+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:40.593+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9035
04-14 03:25:40.593+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9035
04-14 03:25:40.603+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.682
04-14 03:25:40.613+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
04-14 03:25:40.623+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:40.623+0900 I/Tizen::App( 1305): (782) > Finished invoking application event listener for org.example.client, 9035.
04-14 03:25:40.643+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
04-14 03:25:40.643+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:25:40.643+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
04-14 03:25:40.643+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:40.653+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-14 03:25:40.673+0900 I/Tizen::System( 1305): (259) > Active app [com.samsun], current [org.exampl] 
04-14 03:25:40.673+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:40.693+0900 E/weather-widget( 1405): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-14 03:25:40.693+0900 W/CRASH_MANAGER( 9317): worker.c: worker_job(1199) > 1109035636c691492107940
04-14 03:25:40.713+0900 E/weather-common( 1405): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-14 03:25:40.723+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:40.733+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-14 03:25:40.733+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-14 03:25:40.743+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-14 03:25:40.743+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-14 03:25:40.743+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:25:40.793+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_create(409) > New handle created[0xb86d2890]
04-14 03:25:40.793+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_get_type(463) > Connected Network = 2
04-14 03:25:40.793+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_destroy(427) > Destroy handle: 0xb86d2890
04-14 03:25:40.793+0900 E/weather-common( 1405): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-14 03:25:40.793+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-14 03:25:40.793+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-14 03:25:40.793+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-14 03:25:40.793+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: fg
04-14 03:25:40.923+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28868376
04-14 03:25:41.243+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28868697
04-14 03:25:41.503+0900 W/cluster-view(  860): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
04-14 03:25:41.794+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28869241
04-14 03:25:42.244+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28869694
04-14 03:25:42.504+0900 W/cluster-view(  860): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
04-14 03:25:42.745+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28870198
04-14 03:25:42.845+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28870297
04-14 03:25:42.855+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-14 03:25:42.855+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 1
04-14 03:25:42.855+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(2508) > caller pid : 860
04-14 03:25:42.865+0900 E/RESOURCED(  648): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-14 03:25:42.865+0900 E/RESOURCED(  648): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-14 03:25:42.865+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(3052) > pad pid(-5)
04-14 03:25:42.865+0900 W/AUL_PAD ( 1560): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-14 03:25:42.865+0900 W/AUL_PAD ( 1560): launchpad.c: __send_result_to_caller(267) > Check app launching
04-14 03:25:42.885+0900 I/abc     ( 9311): abc
04-14 03:25:42.885+0900 I/CAPI_APPFW_APPLICATION( 9311): app_main.c: ui_app_main(789) > app_efl_main
04-14 03:25:42.885+0900 I/CAPI_APPFW_APPLICATION( 9311): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-14 03:25:42.915+0900 E/TBM     ( 9311): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-14 03:25:42.965+0900 W/AUL     (  616): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9311, appid: org.example.client
04-14 03:25:42.965+0900 E/AUL     (  616): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-14 03:25:42.965+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(9311)
04-14 03:25:43.185+0900 I/APP_CORE( 9311): appcore-efl.c: __do_app(514) > [APP 9311] Event: RESET State: CREATED
04-14 03:25:43.185+0900 I/CAPI_APPFW_APPLICATION( 9311): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-14 03:25:43.195+0900 E/EFL     ( 9311): edje<9311> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:43.195+0900 E/EFL     ( 9311): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:43.205+0900 E/EFL     ( 9311): edje<9311> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:43.205+0900 E/EFL     ( 9311): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:43.205+0900 E/EFL     ( 9311): edje<9311> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:43.205+0900 E/EFL     ( 9311): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:43.215+0900 W/APP_CORE( 9311): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
04-14 03:25:43.215+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 35
04-14 03:25:43.215+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:43.215+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:43.235+0900 I/Tizen::System( 1305): (259) > Active app [org.exampl], current [com.samsun] 
04-14 03:25:43.235+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:43.245+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:25:43.255+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:43.325+0900 I/APP_CORE( 9311): appcore-efl.c: __do_app(514) > [APP 9311] Event: RESUME State: CREATED
04-14 03:25:43.325+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
04-14 03:25:43.325+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-14 03:25:43.325+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
04-14 03:25:43.325+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
04-14 03:25:43.325+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
04-14 03:25:43.325+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
04-14 03:25:43.335+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9311) status(3)
04-14 03:25:43.335+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(9311)
04-14 03:25:43.335+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9311, appid: org.example.client, status: fg
04-14 03:25:43.335+0900 I/APP_CORE( 9311): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-14 03:25:43.335+0900 I/APP_CORE( 9311): appcore-efl.c: __do_app(625) > [APP 9311] Initial Launching, call the resume_cb
04-14 03:25:43.335+0900 I/CAPI_APPFW_APPLICATION( 9311): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:25:43.345+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-14 03:25:43.345+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-14 03:25:43.345+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: bg
04-14 03:25:43.686+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9311) status(0)
04-14 03:25:44.006+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.685
04-14 03:25:44.016+0900 I/Tizen::App( 1305): (499) > LaunchedApp(org.example.client)
04-14 03:25:44.016+0900 I/Tizen::App( 1305): (733) > Finished invoking application event listener for org.example.client, 9311.
04-14 03:25:44.146+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28871596
04-14 03:25:44.246+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28871695
04-14 03:25:44.556+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28872003
04-14 03:25:44.556+0900 I/MY_LOG  ( 9311): Button pressed
04-14 03:25:44.637+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28872080
04-14 03:25:44.647+0900 E/VCONF   ( 9311): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-14 03:25:44.647+0900 E/VCONF   ( 9311): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-14 03:25:44.647+0900 E/VCONF   ( 9311): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-14 03:25:44.647+0900 E/VCONF   ( 9311): vconf.c: vconf_get_bool(2729) > vconf_get_bool(9311) : db/ise/keysound error
04-14 03:25:44.647+0900 E/VCONF   ( 9311): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-14 03:25:44.647+0900 E/VCONF   ( 9311): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-14 03:25:44.697+0900 I/MY_LOG  ( 9311): Button unpressed
04-14 03:25:45.017+0900 I/UXT     ( 9346): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-14 03:25:45.497+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28872945
04-14 03:25:45.497+0900 I/MY_LOG  ( 9311): Button pressed
04-14 03:25:45.587+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28873033
04-14 03:25:45.587+0900 I/MY_LOG  ( 9311): Button unpressed
04-14 03:25:45.617+0900 D/basicui ( 9311): successed to load edc file
04-14 03:25:47.009+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28874453
04-14 03:25:47.099+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28874541
04-14 03:25:47.119+0900 D/basicui ( 9311): successed to load edc file
04-14 03:25:47.139+0900 I/MY_LOG  ( 9311): change
04-14 03:25:47.209+0900 I/MY_LOG  ( 9311): change
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:25:47.639+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:25:47.900+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28875345
04-14 03:25:48.340+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: MEM_FLUSH State: PAUSED
04-14 03:25:48.741+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28876185
04-14 03:25:49.391+0900 E/EFL     ( 9311): ecore_x<9311> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28876835
04-14 03:25:49.491+0900 W/CRASH_MANAGER( 9317): worker.c: worker_job(1199) > 1109311636c69149210794
