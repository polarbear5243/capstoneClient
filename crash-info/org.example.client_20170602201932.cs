S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 19452
Date: 2017-06-02 20:19:32+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 19452, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00004bfc
r2   = 0x00000006, r3   = 0xb40854c0
r4   = 0x00000002, r5   = 0xb4085000
r6   = 0xb677f09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5ead708
r10  = 0xb820be90, fp   = 0x80155ab3
ip   = 0x00000000, sp   = 0xbeed3eb4
lr   = 0xb6675f18, pc   = 0xb6674b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     60060 KB
Buffers:     82384 KB
Cached:     276288 KB
VmPeak:     147744 KB
VmSize:     147444 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31276 KB
VmRSS:       31276 KB
VmData:      48052 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35860 KB
VmPTE:         108 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 19452 TID = 19452
19452 19453 19712 19713 19721 

Maps Information
af001000 af800000 rw-p [stack:19721]
b101b000 b102c000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b103c000 b1041000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b133f000 b1347000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1359000 b1b58000 rw-p [stack:19713]
b1b58000 b1b59000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b69000 b1b7d000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b91000 b1b92000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1ba2000 b1ba5000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bb6000 b1bb7000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bc7000 b1bc9000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bd9000 b1bdb000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1beb000 b1bfb000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c0b000 b1c17000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c29000 b2428000 rw-p [stack:19712]
b2759000 b2760000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2773000 b2779000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2789000 b27b9000 r-xp /opt/usr/apps/org.example.client/bin/client
b2911000 b29f4000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a2b000 b2a53000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a65000 b3264000 rw-p [stack:19453]
b3264000 b3266000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3276000 b3280000 r-xp /lib/libnss_files-2.20-2014.11.so
b3291000 b329a000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32ab000 b32bc000 r-xp /lib/libnsl-2.20-2014.11.so
b32cf000 b32d5000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32e6000 b32e7000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b330f000 b3316000 r-xp /usr/lib/libminizip.so.1.0.0
b3326000 b332b000 r-xp /usr/lib/libstorage.so.0.1
b333b000 b339a000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33b0000 b33c4000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33d4000 b3418000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3428000 b3430000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3440000 b3470000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3483000 b353c000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3550000 b35a3000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35b4000 b35cf000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35df000 b36a0000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36b3000 b36c3000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36d3000 b36e0000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36f1000 b36f8000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3708000 b3749000 r-xp /usr/lib/libmdm.so.1.2.12
b3759000 b3761000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3770000 b3780000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37a1000 b3801000 r-xp /usr/lib/libasound.so.2.0.0
b3813000 b3816000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3826000 b3829000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3839000 b383e000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b384e000 b384f000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b385f000 b386a000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b387e000 b3885000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3895000 b389b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38ab000 b38b0000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38c0000 b38db000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38eb000 b38f2000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3902000 b3905000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3916000 b3944000 r-xp /usr/lib/libidn.so.11.5.44
b3954000 b396a000 r-xp /usr/lib/libnghttp2.so.5.4.0
b397b000 b3985000 r-xp /usr/lib/libcares.so.2.1.0
b3995000 b399f000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39af000 b39b1000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39c1000 b39c2000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39d2000 b39d6000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39e7000 b3a0f000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a20000 b3a49000 r-xp /usr/lib/libturbojpeg.so
b3a69000 b3a6f000 r-xp /usr/lib/libgif.so.4.1.6
b3a7f000 b3ac5000 r-xp /usr/lib/libcurl.so.4.3.0
b3ad6000 b3af7000 r-xp /usr/lib/libexif.so.12.3.3
b3b12000 b3b27000 r-xp /usr/lib/libtts.so
b3b38000 b3b40000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b50000 b3c16000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c36000 b3d2e000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d4d000 b3e1b000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e32000 b3e34000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e44000 b3e4a000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e5a000 b3e7d000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e8e000 b3e90000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ea0000 b3ea2000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3eb3000 b3eb8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ecf000 b3ed1000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ee1000 b3ee8000 r-xp /usr/lib/libsensord-share.so
b3ef8000 b3f10000 r-xp /usr/lib/libsensor.so.1.1.0
b3f21000 b3f24000 r-xp /usr/lib/libXv.so.1.0.0
b3f34000 b3f39000 r-xp /usr/lib/libutilX.so.1.1.0
b3f49000 b3f4e000 r-xp /usr/lib/libappcore-common.so.1.1
b3f5e000 b3f65000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f78000 b3f7c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f8d000 b406b000 r-xp /usr/lib/libCOREGL.so.4.0
b408b000 b408e000 r-xp /usr/lib/libuuid.so.1.3.0
b409e000 b40b5000 r-xp /usr/lib/libblkid.so.1.1.0
b40c6000 b40c8000 r-xp /usr/lib/libXau.so.6.0.0
b40d8000 b411f000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4131000 b4137000 r-xp /usr/lib/libjson-c.so.2.0.1
b4148000 b414c000 r-xp /usr/lib/libogg.so.0.7.1
b415c000 b417e000 r-xp /usr/lib/libvorbis.so.0.4.3
b418e000 b4272000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b428e000 b4291000 r-xp /usr/lib/libEGL.so.1.4
b42a2000 b42a8000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42b8000 b42ba000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42ca000 b42d7000 r-xp /usr/lib/libGLESv2.so.2.0
b42e8000 b434a000 r-xp /usr/lib/libpixman-1.so.0.28.2
b435f000 b4377000 r-xp /usr/lib/libmount.so.1.1.0
b4389000 b439d000 r-xp /usr/lib/libxcb.so.1.1.0
b43ad000 b43b4000 r-xp /lib/libcrypt-2.20-2014.11.so
b43ec000 b43ee000 r-xp /usr/lib/libiri.so
b43fe000 b4409000 r-xp /usr/lib/libgpg-error.so.0.15.0
b441a000 b4450000 r-xp /usr/lib/libpulse.so.0.16.2
b4461000 b44a4000 r-xp /usr/lib/libsndfile.so.1.0.25
b44b9000 b44ce000 r-xp /lib/libexpat.so.1.5.2
b44e0000 b459e000 r-xp /usr/lib/libcairo.so.2.11200.14
b45b2000 b45ba000 r-xp /usr/lib/libdrm.so.2.4.0
b45ca000 b45cd000 r-xp /usr/lib/libdri2.so.0.0.0
b45dd000 b462b000 r-xp /usr/lib/libssl.so.1.0.0
b4640000 b464c000 r-xp /usr/lib/libeeze.so.1.13.0
b465d000 b4666000 r-xp /usr/lib/libethumb.so.1.13.0
b4676000 b4679000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4689000 b4840000 r-xp /usr/lib/libcrypto.so.1.0.0
b562b000 b5634000 r-xp /usr/lib/libXi.so.6.1.0
b5644000 b5646000 r-xp /usr/lib/libXgesture.so.7.0.0
b5656000 b565a000 r-xp /usr/lib/libXtst.so.6.1.0
b566a000 b5670000 r-xp /usr/lib/libXrender.so.1.3.0
b5680000 b5686000 r-xp /usr/lib/libXrandr.so.2.2.0
b5696000 b5698000 r-xp /usr/lib/libXinerama.so.1.0.0
b56a9000 b56ac000 r-xp /usr/lib/libXfixes.so.3.1.0
b56bc000 b56c7000 r-xp /usr/lib/libXext.so.6.4.0
b56d7000 b56d9000 r-xp /usr/lib/libXdamage.so.1.1.0
b56e9000 b56eb000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56fb000 b57dd000 r-xp /usr/lib/libX11.so.6.3.0
b57f1000 b57f8000 r-xp /usr/lib/libXcursor.so.1.0.2
b5808000 b5820000 r-xp /usr/lib/libudev.so.1.6.0
b5822000 b5825000 r-xp /lib/libattr.so.1.1.0
b5835000 b5855000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5856000 b585b000 r-xp /usr/lib/libffi.so.6.0.2
b586c000 b5884000 r-xp /lib/libz.so.1.2.8
b5894000 b5896000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58a6000 b597b000 r-xp /usr/lib/libxml2.so.2.9.2
b5990000 b5a2b000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a47000 b5a4a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a5a000 b5a73000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a84000 b5a95000 r-xp /lib/libresolv-2.20-2014.11.so
b5aa9000 b5b23000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b38000 b5b3a000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b4a000 b5b51000 r-xp /usr/lib/libembryo.so.1.13.0
b5b61000 b5b6b000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b7c000 b5b94000 r-xp /usr/lib/libpng12.so.0.50.0
b5ba5000 b5bc8000 r-xp /usr/lib/libjpeg.so.8.0.2
b5be9000 b5bfd000 r-xp /usr/lib/libector.so.1.13.0
b5c0e000 b5c26000 r-xp /usr/lib/liblua-5.1.so
b5c37000 b5c8e000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ca2000 b5cca000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cdb000 b5cee000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cff000 b5d39000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d4a000 b5d58000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d68000 b5d70000 r-xp /usr/lib/libtbm.so.1.0.0
b5d80000 b5d8d000 r-xp /usr/lib/libeio.so.1.13.0
b5d9d000 b5d9f000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5daf000 b5db4000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dc4000 b5ddb000 r-xp /usr/lib/libefreet.so.1.13.0
b5ded000 b5e0d000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e1d000 b5e3d000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e3f000 b5e45000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e55000 b5e66000 r-xp /usr/lib/libemotion.so.1.13.0
b5e77000 b5e7e000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e8e000 b5e9d000 r-xp /usr/lib/libeo.so.1.13.0
b5eae000 b5ec0000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ed1000 b5ed6000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ee6000 b5eff000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f0f000 b5f2c000 r-xp /usr/lib/libeet.so.1.13.0
b5f45000 b5f8d000 r-xp /usr/lib/libeina.so.1.13.0
b5f9e000 b5fae000 r-xp /usr/lib/libefl.so.1.13.0
b5fbf000 b60a4000 r-xp /usr/lib/libicuuc.so.51.1
b60c1000 b6201000 r-xp /usr/lib/libicui18n.so.51.1
b6218000 b6250000 r-xp /usr/lib/libecore_x.so.1.13.0
b6262000 b6265000 r-xp /lib/libcap.so.2.21
b6275000 b629e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62af000 b62b6000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62c8000 b62ff000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6310000 b63fb000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b640e000 b6487000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6499000 b649e000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64ae000 b64b8000 r-xp /usr/lib/libvconf.so.0.2.45
b64c8000 b64ca000 r-xp /usr/lib/libvasum.so.0.3.1
b64da000 b64dc000 r-xp /usr/lib/libttrace.so.1.1
b64ec000 b64ef000 r-xp /usr/lib/libiniparser.so.0
b64ff000 b6525000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6535000 b653a000 r-xp /usr/lib/libxdgmime.so.1.1.0
b654b000 b6562000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6573000 b65de000 r-xp /lib/libm-2.20-2014.11.so
b65ef000 b65f5000 r-xp /lib/librt-2.20-2014.11.so
b6606000 b6613000 r-xp /usr/lib/libunwind.so.8.0.1
b6649000 b676d000 r-xp /lib/libc-2.20-2014.11.so
b6782000 b679b000 r-xp /lib/libgcc_s-4.9.so.1
b67ab000 b688d000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b689e000 b68c8000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68d9000 b6915000 r-xp /usr/lib/libsystemd.so.0.4.0
b6917000 b699a000 r-xp /usr/lib/libedje.so.1.13.0
b69ad000 b69cb000 r-xp /usr/lib/libecore.so.1.13.0
b69eb000 b6b72000 r-xp /usr/lib/libevas.so.1.13.0
b6ba7000 b6bbb000 r-xp /lib/libpthread-2.20-2014.11.so
b6bcf000 b6e03000 r-xp /usr/lib/libelementary.so.1.13.0
b6e32000 b6e36000 r-xp /usr/lib/libsmack.so.1.0.0
b6e46000 b6e4d000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e5d000 b6e5f000 r-xp /usr/lib/libdlog.so.0.0.0
b6e6f000 b6e72000 r-xp /usr/lib/libbundle.so.0.1.22
b6e82000 b6e84000 r-xp /lib/libdl-2.20-2014.11.so
b6e95000 b6ead000 r-xp /usr/lib/libaul.so.0.1.0
b6ec1000 b6ec6000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ed7000 b6ee4000 r-xp /usr/lib/liblptcp.so
b6ef6000 b6efa000 r-xp /usr/lib/libsys-assert.so
b6f0b000 b6f2b000 r-xp /lib/ld-2.20-2014.11.so
b6f3c000 b6f41000 r-xp /usr/bin/launchpad-loader
b7db5000 b82bf000 rw-p [heap]
beeb4000 beed5000 rw-p [stack]
beeb4000 beed5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19452)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6674b84) [/lib/libc.so.6] + 0x2bb84
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
info(312) > tmp is NULL
06-02 20:18:31.578+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:31.578+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:31.578+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:31.578+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:31.578+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:31.578+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:31.578+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:31.578+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:31.588+0900 W/AUL_AMD (  612): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
06-02 20:18:31.588+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
06-02 20:18:31.598+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
06-02 20:18:31.688+0900 W/AUL_AMD (  612): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-02 20:18:31.688+0900 W/AUL_AMD (  612): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-02 20:18:32.839+0900 E/PKGMGR_SERVER(19597): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-02 20:18:33.290+0900 E/PKGMGR_SERVER(19597): pkgmgr-server.c: sighandler(417) > child NORMAL exit [19600]
06-02 20:18:34.231+0900 E/PKGMGR  (19648): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
06-02 20:18:34.261+0900 E/PKGMGR_SERVER(19597): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
06-02 20:18:34.271+0900 E/PKGMGR_INFO(19597): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
06-02 20:18:34.281+0900 E/rpm-installer(19597): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
06-02 20:18:34.291+0900 E/PKGMGR_SERVER(19597): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-02 20:18:34.291+0900 E/PKGMGR  (19648): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[196480002]
06-02 20:18:34.421+0900 E/PKGMGR_INSTALLER(19650): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
06-02 20:18:34.421+0900 E/rpm-installer(19650): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
06-02 20:18:34.441+0900 E/rpm-installer(19650): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
06-02 20:18:34.441+0900 E/rpm-installer(19650): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
06-02 20:18:34.441+0900 E/rpm-installer(19650): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-02 20:18:34.441+0900 E/rpm-installer(19650): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
06-02 20:18:34.441+0900 E/rpm-installer(19650): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-02 20:18:34.491+0900 W/CERT_SVC_VCORE(19650): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
06-02 20:18:34.541+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
06-02 20:18:34.541+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.541+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.551+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-02 20:18:34.551+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [30]
06-02 20:18:34.551+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
06-02 20:18:34.551+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.551+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.551+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.551+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.551+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.551+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.551+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.561+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:34.831+0900 E/rpm-installer(19650): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-02 20:18:34.831+0900 E/rpm-installer(19650): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-02 20:18:34.831+0900 E/rpm-installer(19650): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-02 20:18:34.831+0900 E/rpm-installer(19650): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-02 20:18:34.831+0900 E/rpm-installer(19650): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-02 20:18:34.831+0900 E/rpm-installer(19650): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-02 20:18:34.841+0900 E/PKGMGR_PARSER(19650): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-02 20:18:34.841+0900 E/PKGMGR_SERVER(19597): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-02 20:18:34.841+0900 E/PKGMGR_PARSER(19650): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-02 20:18:34.881+0900 I/PRIVACY-MANAGER-CLIENT(19650): SocketClient.cpp: SocketClient(37) > Client created
06-02 20:18:35.092+0900 E/PKGMGR_PARSER(19650): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-02 20:18:35.112+0900 E/PKGMGR_CERT(19650): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-02 20:18:35.112+0900 E/PKGMGR_CERT(19650): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 110
06-02 20:18:35.112+0900 E/PKGMGR_CERT(19650): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 110
06-02 20:18:35.112+0900 E/PKGMGR_CERT(19650): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
06-02 20:18:35.112+0900 E/PKGMGR_CERT(19650): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 5
06-02 20:18:35.112+0900 E/PKGMGR_CERT(19650): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 5
06-02 20:18:35.112+0900 E/PKGMGR_CERT(19650): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
06-02 20:18:35.122+0900 E/PKGMGR_CERT(19650): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-02 20:18:35.122+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
06-02 20:18:35.122+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [60]
06-02 20:18:35.122+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.122+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.132+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.132+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.132+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.132+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.132+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.142+0900 E/rpm-installer(19650): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-02 20:18:35.162+0900 E/rpm-installer(19650): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-02 20:18:35.162+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
06-02 20:18:35.162+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [100]
06-02 20:18:35.162+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.162+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.172+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.172+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.172+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.172+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.172+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.172+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.172+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.172+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.172+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.172+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.172+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.172+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.172+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.172+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:35.172+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:36.843+0900 E/PKGMGR_SERVER(19597): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-02 20:18:37.063+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
06-02 20:18:37.063+0900 I/Tizen::App( 1233): (78) > Installation is Completed. [Package = org.example.client]
06-02 20:18:37.063+0900 I/Tizen::App( 1233): (671) > Enter. package(org.example.client), installationResult(0)
06-02 20:18:37.083+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-02 20:18:37.083+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-02 20:18:37.083+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-02 20:18:37.093+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.093+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 20:18:37.103+0900 I/Tizen::App( 1233): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
06-02 20:18:37.113+0900 E/PKGMGR_SERVER(19597): pkgmgr-server.c: sighandler(417) > child NORMAL exit [19650]
06-02 20:18:37.134+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
06-02 20:18:37.134+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
06-02 20:18:37.134+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-02 20:18:37.134+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-02 20:18:37.134+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
06-02 20:18:37.134+0900 I/Tizen::App( 1233): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
06-02 20:18:37.144+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
06-02 20:18:37.144+0900 E/HOME_APPS(  867): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
06-02 20:18:37.144+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
06-02 20:18:37.154+0900 I/Tizen::App( 1233): (416) > appName = [client]
06-02 20:18:37.154+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
06-02 20:18:37.154+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-02 20:18:37.154+0900 E/PKGMGR_INFO( 1233): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-02 20:18:37.154+0900 I/Tizen::App( 1233): (683) > Application count(1) in this package
06-02 20:18:37.154+0900 I/Tizen::App( 1233): (840) > Enter.
06-02 20:18:37.154+0900 I/Tizen::App( 1233): (703) > Exit.
06-02 20:18:37.154+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
06-02 20:18:37.164+0900 I/Tizen::App( 1233): (416) > appName = [client]
06-02 20:18:37.164+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-02 20:18:37.164+0900 I/Tizen::App( 1233): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
06-02 20:18:37.164+0900 I/Tizen::App( 1233): (131) > Enter
06-02 20:18:37.164+0900 I/Tizen::App( 1233): (137) > org.example.client does not have launch condition
06-02 20:18:37.164+0900 I/Tizen::App( 1233): (883) > Exit.
06-02 20:18:37.174+0900 E/util-view(  867): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-02 20:18:37.194+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-02 20:18:38.835+0900 E/PKGMGR_SERVER(19597): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-02 20:18:38.835+0900 E/PKGMGR_SERVER(19597): pkgmgr-server.c: main(2471) > package manager server terminated.
06-02 20:18:41.258+0900 W/AUL     (19705): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-02 20:18:41.258+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
06-02 20:18:41.268+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-02 20:18:41.268+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-02 20:18:41.268+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-02 20:18:41.268+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 19705
06-02 20:18:41.268+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-02 20:18:41.278+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
06-02 20:18:41.278+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-02 20:18:41.278+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
06-02 20:18:41.288+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-02 20:18:41.288+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
06-02 20:18:41.298+0900 I/abc     (19452): abc
06-02 20:18:41.298+0900 I/CAPI_APPFW_APPLICATION(19452): app_main.c: ui_app_main(789) > app_efl_main
06-02 20:18:41.298+0900 I/CAPI_APPFW_APPLICATION(19452): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-02 20:18:41.328+0900 E/TBM     (19452): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-02 20:18:41.388+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 19452, appid: org.example.client
06-02 20:18:41.388+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-02 20:18:41.388+0900 W/AUL     (19705): launch.c: app_request_to_launchpad(425) > request cmd(0) result(19452)
06-02 20:18:41.568+0900 D/basicui (19452): successed to load edc file
06-02 20:18:41.608+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:18:41.608+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:18:41.638+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
06-02 20:18:41.638+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:18:41.638+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:18:41.648+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 20:18:41.708+0900 I/MY_LOG  (19452): change
06-02 20:18:41.758+0900 I/APP_CORE(19452): appcore-efl.c: __do_app(514) > [APP 19452] Event: RESET State: CREATED
06-02 20:18:41.758+0900 I/CAPI_APPFW_APPLICATION(19452): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-02 20:18:41.778+0900 E/EFL     (19452): edje<19452> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 20:18:41.778+0900 E/EFL     (19452): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:18:41.778+0900 E/EFL     (19452): edje<19452> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 20:18:41.778+0900 E/EFL     (19452): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:18:41.778+0900 E/EFL     (19452): edje<19452> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 20:18:41.778+0900 E/EFL     (19452): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:18:41.788+0900 I/MY_LOG  (19452): change
06-02 20:18:41.788+0900 W/APP_CORE(19452): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5c00002
06-02 20:18:41.788+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-02 20:18:41.918+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-02 20:18:41.918+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-02 20:18:41.918+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-02 20:18:41.918+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-02 20:18:41.918+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-02 20:18:41.918+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-02 20:18:41.928+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(19452) status(3)
06-02 20:18:41.928+0900 I/APP_CORE(19452): appcore-efl.c: __do_app(514) > [APP 19452] Event: RESUME State: CREATED
06-02 20:18:41.928+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:18:41.928+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:18:41.928+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(19452)
06-02 20:18:41.928+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 19452, appid: org.example.client, status: fg
06-02 20:18:41.938+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-02 20:18:41.938+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-02 20:18:41.938+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-02 20:18:41.938+0900 I/APP_CORE(19452): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-02 20:18:41.938+0900 I/APP_CORE(19452): appcore-efl.c: __do_app(625) > [APP 19452] Initial Launching, call the resume_cb
06-02 20:18:41.938+0900 I/CAPI_APPFW_APPLICATION(19452): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:18:42.289+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(19452) status(0)
06-02 20:18:42.459+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2542
06-02 20:18:42.469+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
06-02 20:18:42.469+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 19452.
06-02 20:18:43.259+0900 I/UXT     (19718): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-02 20:18:44.441+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950921598
06-02 20:18:44.511+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950921675
06-02 20:18:45.161+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950922325
06-02 20:18:45.161+0900 I/MY_LOG  (19452): Button pressed
06-02 20:18:45.251+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950922413
06-02 20:18:45.251+0900 E/VCONF   (19452): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-02 20:18:45.251+0900 E/VCONF   (19452): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-02 20:18:45.251+0900 E/VCONF   (19452): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-02 20:18:45.251+0900 E/VCONF   (19452): vconf.c: vconf_get_bool(2729) > vconf_get_bool(19452) : db/ise/keysound error
06-02 20:18:45.261+0900 E/VCONF   (19452): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-02 20:18:45.261+0900 E/VCONF   (19452): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-02 20:18:45.311+0900 I/MY_LOG  (19452): Button unpressed
06-02 20:18:45.422+0900 I/MY_LOG  (19452): change
06-02 20:18:46.553+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950923714
06-02 20:18:46.653+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950923813
06-02 20:18:46.923+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-02 20:18:47.093+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950924257
06-02 20:18:47.103+0900 I/MY_LOG  (19452): Button pressed
06-02 20:18:47.183+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950924345
06-02 20:18:47.183+0900 I/MY_LOG  (19452): Button unpressed
06-02 20:18:47.394+0900 I/MY_LOG  (19452): change
06-02 20:18:52.348+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950929510
06-02 20:18:52.348+0900 I/MY_LOG  (19452): Button pressed
06-02 20:18:52.448+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950929609
06-02 20:18:52.448+0900 I/MY_LOG  (19452): Button unpressed
06-02 20:18:52.559+0900 I/MY_LOG  (19452): change
06-02 20:18:55.451+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950932609
06-02 20:18:55.451+0900 I/MY_LOG  (19452): Button pressed
06-02 20:18:55.592+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950932753
06-02 20:18:55.592+0900 I/MY_LOG  (19452): Button unpressed
06-02 20:18:55.722+0900 I/MY_LOG  (19452): change
06-02 20:18:57.984+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950935147
06-02 20:18:57.994+0900 I/MY_LOG  (19452): Button pressed
06-02 20:18:58.144+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950935303
06-02 20:18:58.144+0900 I/MY_LOG  (19452): Button unpressed
06-02 20:19:00.436+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-02 20:19:00.436+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 8:19
06-02 20:19:00.436+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 8:19"
06-02 20:19:00.436+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 8:19"
06-02 20:19:00.436+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-02 20:19:00.436+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146107006 Time: <font_size=31> </font_size> <font_size=31> 오후 8:19</font_size></font>"
06-02 20:19:28.544+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950965702
06-02 20:19:28.544+0900 I/MY_LOG  (19452): Button pressed
06-02 20:19:28.634+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950965790
06-02 20:19:28.644+0900 I/MY_LOG  (19452): Button unpressed
06-02 20:19:29.204+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950966365
06-02 20:19:29.364+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950966530
06-02 20:19:29.565+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950966729
06-02 20:19:29.565+0900 I/MY_LOG  (19452): Button pressed
06-02 20:19:29.655+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950966817
06-02 20:19:29.655+0900 I/MY_LOG  (19452): Button unpressed
06-02 20:19:29.695+0900 D/basicui (19452): successed to load edc file
06-02 20:19:29.725+0900 E/EFL     (19452): elementary<19452> elm_layout.c:991 _elm_layout_elm_container_content_set() could not swallow 0x80149651 into part 'swallow_content'
06-02 20:19:30.976+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950968145
06-02 20:19:31.076+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950968233
06-02 20:19:31.116+0900 E/EFL     (19452): edje<19452> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p9';
06-02 20:19:31.116+0900 E/EFL     (19452): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:19:31.927+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=950969096
06-02 20:19:32.047+0900 E/EFL     (19452): ecore_x<19452> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=950969207
06-02 20:19:32.047+0900 E/EFL     (19452): eo<19452> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_widget_item.eo.c:56: unable to resolve regular api func 'elm_wdg_item_part_text_get' 0xb6d6c9e9 in class 'Elm_Hoversel'.
06-02 20:19:32.197+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:19:32.227+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-02 20:19:32.227+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:19:32.227+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:19:32.237+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-02 20:19:32.237+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-02 20:19:32.237+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 19452 pgid = 19452
06-02 20:19:32.237+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(19452)
06-02 20:19:32.267+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-02 20:19:32.277+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-02 20:19:32.277+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:19:32.277+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-02 20:19:32.277+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:19:32.297+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-02 20:19:32.297+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-02 20:19:32.297+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
06-02 20:19:32.307+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 19452
06-02 20:19:32.307+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-02 20:19:32.307+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 19452
06-02 20:19:32.307+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 19452
06-02 20:19:32.317+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2546
06-02 20:19:32.327+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-02 20:19:32.327+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 20:19:32.337+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-02 20:19:32.337+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 20:19:32.337+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 20:19:32.357+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
06-02 20:19:32.357+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:19:32.367+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
06-02 20:19:32.397+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:19:32.397+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[19452] terminate event is forwarded
06-02 20:19:32.397+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
06-02 20:19:32.397+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 19452, ]
06-02 20:19:32.397+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
06-02 20:19:32.397+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
06-02 20:19:32.397+0900 I/Tizen::App( 1233): (512) > Not registered pid(19452)
06-02 20:19:32.397+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
06-02 20:19:32.397+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:19:32.407+0900 W/CRASH_MANAGER(19729): worker.c: worker_job(1199) > 0619452636c69149640237
